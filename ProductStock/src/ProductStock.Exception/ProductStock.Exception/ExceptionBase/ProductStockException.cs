namespace ProductStock.Exception.ExceptionBase
{
    public abstract class ProductStockException: SystemException
    {
        protected ProductStockException(string message) : base(message) { }
        public abstract int StatusCode { get; }
        public abstract List<string> GetErros();
    }
}
