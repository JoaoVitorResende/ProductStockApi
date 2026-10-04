using ProductStock.Exception.ExceptionBase;
using System.Net;

namespace ProductStock.Exception.ExceptionProduct
{
    public class ProductException : ProductStockException
    {
        private readonly List<string> _erros;
        public override int StatusCode => (int)HttpStatusCode.BadRequest;
        public ProductException(List<string> errorMessages) : base(string.Empty)
        {
            _erros = errorMessages;
        }
        public override List<string> GetErros()
        {
            return _erros;
        }
    }
}
