using ProductStock.Domain.Enum;

namespace ProductStock.Communication.Request
{
    public class RequestMovement
    {
        public long ProductCode { get; set; }
        public MovementType Type { get; set; }
        public long Quantity { get; set; }
    }
}
