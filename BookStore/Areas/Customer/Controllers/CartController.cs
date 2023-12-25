using System.Security.Claims;
using BookStore.Data.Repository.IRepository;
using BookStore.Models;
using BookStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Areas.Customer.Controllers;

[Area("Customer")]
[Authorize]
public class CartController : Controller
{
    private readonly IUnitOfWork _unitOfWork;
    [BindProperty] 
    public ShoppingCartVM ShoppingCartVM { get; set; }

    public CartController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        ShoppingCartVM = new ShoppingCartVM()
        {
            ListCart = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value,
                includeProperties: "Product"),
            Order = new Order()
        };
        foreach (var cart in ShoppingCartVM.ListCart)
        {
            cart.Price = cart.Product.Price;
            ShoppingCartVM.Order.OrderTotal += (cart.Price * cart.Count);
        }
        

        return View(ShoppingCartVM);
    }

    public IActionResult Summary()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        ShoppingCartVM = new ShoppingCartVM()
        {
            ListCart = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value,
                includeProperties: "Product"),
            Order = new()
        };
        ShoppingCartVM.Order.ApplicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(
            u => u.Id == claim.Value);

        ShoppingCartVM.Order.Name = ShoppingCartVM.Order.ApplicationUser.Name;
        ShoppingCartVM.Order.PhoneNumber = ShoppingCartVM.Order.ApplicationUser.PhoneNumber;
        ShoppingCartVM.Order.StreetAddress = ShoppingCartVM.Order.ApplicationUser.StreetAddress;
        ShoppingCartVM.Order.City = ShoppingCartVM.Order.ApplicationUser.City;
        ShoppingCartVM.Order.PostalCode = ShoppingCartVM.Order.ApplicationUser.PostalCode;

        foreach (var cart in ShoppingCartVM.ListCart)
        {
            cart.Price = cart.Product.Price;
            ShoppingCartVM.Order.OrderTotal += (cart.Price * cart.Count);
        }
        return View(ShoppingCartVM);
    }

    [HttpPost]
    [ActionName("Summary")]
    [ValidateAntiForgeryToken]
    public IActionResult SummaryPOST()
    {
        var claimsIdentity = (ClaimsIdentity)User.Identity;
        var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

        ShoppingCartVM.ListCart = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value,
            includeProperties: "Product");


        ShoppingCartVM.Order.OrderDate = System.DateTime.Now;
        ShoppingCartVM.Order.ApplicationUserId = claim.Value;


        foreach (var cart in ShoppingCartVM.ListCart)
        {
            cart.Price = cart.Product.Price;
            ShoppingCartVM.Order.OrderTotal += (cart.Price * cart.Count);
        }

        ApplicationUser applicationUser = _unitOfWork.ApplicationUser.GetFirstOrDefault(u => u.Id == claim.Value);

        ShoppingCartVM.Order.PaymentStatus = OrderStatus.PaymentStatusApproved;
        ShoppingCartVM.Order.OrderStatus = OrderStatus.StatusPending;


        _unitOfWork.Order.Add(ShoppingCartVM.Order);
        _unitOfWork.Save();
        foreach (var cart in ShoppingCartVM.ListCart)
        {
            OrderDetail orderDetail = new()
            {
                ProductId = cart.ProductId,
                OrderId = ShoppingCartVM.Order.Id,
                Price = cart.Price,
                Count = cart.Count
            };
            _unitOfWork.OrderDetail.Add(orderDetail);
            _unitOfWork.Save();
        }

        return RedirectToAction("OrderConfirmation", "Cart", new { id = ShoppingCartVM.Order.Id });
    }

    public IActionResult OrderConfirmation(int id)
    {
        Order order = _unitOfWork.Order.GetFirstOrDefault(u => u.Id == id);
        //_unitOfWork.Order.UpdateStatus(id, OrderStatus.StatusApproved);
        _unitOfWork.Save();


        List<ShoppingCart> shoppingCarts = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId ==
            order.ApplicationUserId).ToList();
        _unitOfWork.ShoppingCart.RemoveRange(shoppingCarts);
        _unitOfWork.Save();
        return View(id);
    }


    public IActionResult Plus(int cartId)
    {
        var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(u => u.Id == cartId);
        _unitOfWork.ShoppingCart.IncrementCount(cart, 1);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Minus(int cartId)
    {
        var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(u => u.Id == cartId);
        if (cart.Count <= 1)
        {
            _unitOfWork.ShoppingCart.Remove(cart);
        }
        else
        {
            _unitOfWork.ShoppingCart.DecrementCount(cart, 1);
        }

        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Remove(int cartId)
    {
        var cart = _unitOfWork.ShoppingCart.GetFirstOrDefault(u => u.Id == cartId);
        _unitOfWork.ShoppingCart.Remove(cart);
        _unitOfWork.Save();
        return RedirectToAction(nameof(Index));
    }
}