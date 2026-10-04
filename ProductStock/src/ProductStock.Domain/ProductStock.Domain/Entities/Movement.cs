using ProductStock.Domain.Enum;

namespace ProductStock.Domain.Entities
{
    public class Movement
    {
        public long Id { get; set; }
        public long ProductCode { get; set; }
        public MovementType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public long Quantity { get; set; }
        public long FinalStock { get; set; }
    }
}
