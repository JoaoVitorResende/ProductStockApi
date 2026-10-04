using ProductStock.Exception.ExceptionBase;
using System.Net;

namespace ProductStock.Exception.ExceptionProduct
{
    public class NotFoundException: ProductStockException
    {
        private readonly List<string> _erros;
        public override int StatusCode => (int)HttpStatusCode.BadRequest;
        public NotFoundException(List<string> errorMessages) : base(string.Empty)
        {
            _erros = errorMessages;
        }
        public override List<string> GetErros()
        {
            return _erros;
        }
    }
}
