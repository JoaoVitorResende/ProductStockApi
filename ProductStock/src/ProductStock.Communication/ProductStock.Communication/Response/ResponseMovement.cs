using System.Text.Json.Serialization;

namespace ProductStock.Communication.Response
{
    public class ResponseMovement
    {
        [JsonPropertyName("codigoProduto")]
        public long ProductCode { get; set; }
        [JsonPropertyName("Descrição")]
        public string Description { get; set; } = string.Empty;
        [JsonPropertyName("Estoque")]
        public long Quantity { get; set; }
    }
}
