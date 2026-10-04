using ProductStock.Domain.Entities;

namespace ProductStock.Domain.Repositories
{
    public interface IStockRepository
    {
        bool Exists(long code);
        Product? GetByCode(long code);
        List<Product> GetAll();
        void Add(Product product);
        bool Delete(long code);   
    }
}
