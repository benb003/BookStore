using BookStore.Models;

namespace BookStore.Data.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
        IEnumerable<Product> Search(string? search);
    }
}
