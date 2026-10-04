using ProductStock.Domain.Entities;
using System.Text.Json.Serialization;

namespace ProductStock.Communication.Request
{
    public class RequestProduct
    {
        [JsonPropertyName("estoque")]
        public List<Product> Products { get; set; } = [];
    }
}
