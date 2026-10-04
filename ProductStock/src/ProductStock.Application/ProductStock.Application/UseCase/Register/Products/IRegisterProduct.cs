using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Application.UseCase.Register.Products
{
    public interface IRegisterProduct
    {
        public ResponseProduct Execute(RequestProduct req);
    }
}
