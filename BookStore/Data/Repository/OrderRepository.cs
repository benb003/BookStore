using BookStore.Data.Repository.IRepository;
using BookStore.Models;

namespace BookStore.Data.Repository;

public class OrderRepository : Repository<Order>, IOrderRepository
{
    private ApplicationDbContext _db;

    public OrderRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }


    public void Update(Order obj)
    {
        _db.Orders.Update(obj);
    }

    public void UpdateStatus(int id, string orderStatus)
    {
        var orderFromDb = _db.Orders.FirstOrDefault(u => u.Id == id);
        if (orderFromDb != null)
        {
            orderFromDb.OrderStatus = orderStatus;
            
        }
    }
}