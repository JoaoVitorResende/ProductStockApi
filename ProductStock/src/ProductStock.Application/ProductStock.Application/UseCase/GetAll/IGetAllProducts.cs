using ProductStock.Communication.Response;

namespace ProductStock.Application.UseCase.GetAll
{
    public interface IGetAllProducts
    {
        public ResponseProduct Execute();
    }
}
