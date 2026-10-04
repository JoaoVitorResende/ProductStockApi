using ProductStock.Domain.Entities;

namespace ProductStock.Communication.Request
{
    public class RequestProduct
    {
        public List<Product> Products { get; set; } = [];
    }
}
