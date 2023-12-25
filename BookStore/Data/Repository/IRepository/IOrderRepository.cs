using BookStore.Models;

namespace BookStore.Data.Repository.IRepository;

public interface IOrderRepository : IRepository<Order>
{
    void Update(Order obj);
    void UpdateStatus(int id, string orderStatus);
}