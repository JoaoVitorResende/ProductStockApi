using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Application.UseCase.Register
{
    public interface IRegisterProduct
    {
        public ResponseProduct Execute(RequestProduct req);
    }
}
