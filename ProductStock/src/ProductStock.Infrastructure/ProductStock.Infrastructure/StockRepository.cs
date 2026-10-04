using ProductStock.Domain.Entities;
using ProductStock.Domain.Repositories;

namespace ProductStock.Infrastructure
{
    public class StockRepository : IStockRepository
    {
        private readonly Dictionary<long, Product> _products = new();
        public void Update(Product product, long quantity) => _products[product.ProductID].Quantity = quantity;
        public void Add(Product product) => _products.Add(product.ProductID, product);
        public bool Exists(long code) => _products.ContainsKey(code);
        public List<Product> GetAll() => _products.Values.ToList();
        public Product? GetByCode(long code) => _products.TryGetValue(code, out var product) ? product: null;
        public bool Delete(long code) => _products.Remove(code);
    }
}
