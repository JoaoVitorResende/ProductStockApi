using ProductStock.Domain.Entitties;

namespace ProductStock.Infrastructure
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
