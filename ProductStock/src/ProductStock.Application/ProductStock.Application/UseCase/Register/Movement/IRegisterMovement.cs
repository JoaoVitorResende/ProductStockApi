using ProductStock.Communication.Request;
using ProductStock.Communication.Response;

namespace ProductStock.Application.UseCase.Register.Movement
{
    public interface IRegisterMovement
    {
        public ResponseMovement Execute(RequestMovement req);
    }
}
