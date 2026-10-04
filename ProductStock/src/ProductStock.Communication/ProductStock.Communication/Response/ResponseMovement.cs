using ProductStock.Domain.Enum;

namespace ProductStock.Communication.Response
{
    public class ResponseMovement
    {
        public long ProductCode { get; set; }
        public string Description { get; set; } = string.Empty;
        public long Quantity { get; set; }
    }
}
