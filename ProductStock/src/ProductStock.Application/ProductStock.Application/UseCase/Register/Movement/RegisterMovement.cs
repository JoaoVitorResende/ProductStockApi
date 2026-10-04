using ProductStock.Communication.Request;
using ProductStock.Communication.Response;
using ProductStock.Domain.Repositories;
using ProductStock.Exception.ExceptionProduct;

namespace ProductStock.Application.UseCase.Register.Movement
{
    public class RegisterMovement : IRegisterMovement
    {
        private readonly IStockRepository _stockRepository;

        public RegisterMovement(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public ResponseMovement Execute(RequestMovement req)
        {
            var product = _stockRepository.GetByCode(req.ProductCode);

            if (product == null) {
                throw new NotFoundException([$"Produto {req.ProductCode} nao encontrado"]);
            }
            
            var description = "";

            if((int)req.Type == 1)
            {
                product.Quantity += req.Quantity;
                description = $"Adicionando {product.ProductID} ao estoque";
            }
            else
            {
                product.Quantity -= req.Quantity;
                description = $"Removendo {product.ProductID} ao estoque";
            }

            _stockRepository.Update(product, product.Quantity);

            return new ResponseMovement{
                Description = description,
                ProductCode = req.ProductCode,
                Quantity = product.Quantity
            };
        }
    }
}
