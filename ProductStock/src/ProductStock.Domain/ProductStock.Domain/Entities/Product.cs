using System.Text.Json.Serialization;

namespace ProductStock.Domain.Entities
{
    public class Product
    {
        [JsonPropertyName("codigoProduto")]
        public long ProductID { get; set; }
        [JsonPropertyName("descricaoProduto")]
        public string ProductDescription { get; set; } = string.Empty;
        [JsonPropertyName("estoque")]
        public long Quantity { get; set; }
    }
}
