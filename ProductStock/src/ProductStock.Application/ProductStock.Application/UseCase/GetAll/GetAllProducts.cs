using ProductStock.Communication.Response;
using ProductStock.Domain.Repositories;

namespace ProductStock.Application.UseCase.GetAll
{
    public class GetAllProducts : IGetAllProducts
    {
        public readonly IStockRepository _repository;
        public GetAllProducts(IStockRepository repository)
        {
            _repository = repository;
        }
        public ResponseProduct Execute()
        {
            return new ResponseProduct
            {
                Products = _repository.GetAll()
            };
        }
    }
}
