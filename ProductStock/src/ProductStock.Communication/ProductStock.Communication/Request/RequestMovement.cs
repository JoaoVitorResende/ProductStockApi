using ProductStock.Domain.Enum;
using System.Text.Json.Serialization;

namespace ProductStock.Communication.Request
{
    public class RequestMovement
    {
        [JsonPropertyName("codigoProduto")]
        public long ProductCode { get; set; }
        [JsonPropertyName("Tipo de movimentacao")]
        public MovementType Type { get; set; }
        [JsonPropertyName("estoque")]
        public long Quantity { get; set; }
    }
}
