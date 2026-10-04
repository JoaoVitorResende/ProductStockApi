using ProductStock.Domain.Entities;

namespace ProductStock.Communication.Response
{
    public class ResponseProduct
    {
        public List<Product> Products { get; set; } = [];
    }
}
