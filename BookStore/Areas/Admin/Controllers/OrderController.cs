
using System.Security.Claims;
using BookStore.Data.Repository.IRepository;
using BookStore.Models;
using BookStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Admin.Controllers;

[Area("Admin")]
[Authorize]
public class OrderController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    [BindProperty] 
    public OrderVM OrderVM { get; set; }

    public OrderController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        IEnumerable<Order> orders;
        if (User.IsInRole(Roles.Role_Admin))
        { 
            orders = _unitOfWork.Order.GetAll(includeProperties: "ApplicationUser");
        }
        else
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);
            orders = _unitOfWork.Order.GetAll(u=>u.ApplicationUserId==claim.Value,includeProperties: "ApplicationUser");
        }
            
        return View(orders);
    }

    public IActionResult Details(int orderId)
    {
        OrderVM = new OrderVM()
        {
            Order = _unitOfWork.Order.GetFirstOrDefault(u => u.Id == orderId, includeProperties: "ApplicationUser"),
            OrderDetail = _unitOfWork.OrderDetail.GetAll(u => u.OrderId == orderId, includeProperties: "Product"),
        };
        return View(OrderVM);
    }
    
    [HttpPost]
    [Authorize(Roles = Roles.Role_Admin)]
    [ValidateAntiForgeryToken]
    public IActionResult UpdateOrderDetail()
    {
        var orderHEaderFromDb = _unitOfWork.Order.GetFirstOrDefault(u => u.Id == OrderVM.Order.Id);
        orderHEaderFromDb.Name = OrderVM.Order.Name;
        orderHEaderFromDb.PhoneNumber = OrderVM.Order.PhoneNumber;
        orderHEaderFromDb.StreetAddress = OrderVM.Order.StreetAddress;
        orderHEaderFromDb.City = OrderVM.Order.City;
        orderHEaderFromDb.PostalCode = OrderVM.Order.PostalCode;
        if (OrderVM.Order.Carrier != null)
        {
            orderHEaderFromDb.Carrier = OrderVM.Order.Carrier;
        }
        if (OrderVM.Order.TrackingNumber != null)
        {
            orderHEaderFromDb.TrackingNumber = OrderVM.Order.TrackingNumber;
        }
        _unitOfWork.Order.Update(orderHEaderFromDb);
        _unitOfWork.Save();
        TempData["Success"] = "Order Details Updated Successfully.";
        return RedirectToAction("Details", "Order", new { orderId = orderHEaderFromDb.Id });
    }
    
    [HttpPost]
    [Authorize(Roles = Roles.Role_Admin)]
    [ValidateAntiForgeryToken]
    public IActionResult ConfirmOrder()
    {
        _unitOfWork.Order.UpdateStatus(OrderVM.Order.Id, OrderStatus.StatusApproved);
        _unitOfWork.Save();
        TempData["Success"] = "Order Status Updated Successfully.";
        return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
    }
    
    [HttpPost]
    [Authorize(Roles = Roles.Role_Admin)]
    [ValidateAntiForgeryToken]
    public IActionResult ShipOrder()
    {
        var order = _unitOfWork.Order.GetFirstOrDefault(u => u.Id == OrderVM.Order.Id);
        order.TrackingNumber = OrderVM.Order.TrackingNumber;
        order.Carrier = OrderVM.Order.Carrier;
        order.OrderStatus = OrderStatus.StatusShipped;
        order.ShippingDate = DateTime.Now;
        _unitOfWork.Order.Update(order);
        _unitOfWork.Save();
        TempData["Success"] = "Order Shipped Successfully.";
        return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
    }
    
    [HttpPost]
    [Authorize(Roles = Roles.Role_Admin)]
    [ValidateAntiForgeryToken]
    public IActionResult CancelOrder()
    {
        var order = _unitOfWork.Order.GetFirstOrDefault(u => u.Id == OrderVM.Order.Id);
        _unitOfWork.Order.UpdateStatus(order.Id, OrderStatus.StatusCancelled);
        _unitOfWork.Save();
        TempData["Success"] = "Order Cancelled Successfully.";
        return RedirectToAction("Details", "Order", new { orderId = OrderVM.Order.Id });
    }
    
}

