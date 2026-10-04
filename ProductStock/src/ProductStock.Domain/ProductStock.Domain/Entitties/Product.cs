namespace ProductStock.Domain.Entitties
{
    public class Product
    {
        public long ProductID { get; set; }
        public string ProductDescription { get; set; } = string.Empty;
        public long Quantity { get; set; }
    }
}
