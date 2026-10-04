using ProductStock.Domain.Enum;

namespace ProductStock.Domain.Entitties
{
    public class Movement
    {
        public long Id { get; set; }
        public long ProductCode { get; set; }
        public MovementType type { get; set; }
        public string Description { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public int FinalStock { get; set; }
    }
}
