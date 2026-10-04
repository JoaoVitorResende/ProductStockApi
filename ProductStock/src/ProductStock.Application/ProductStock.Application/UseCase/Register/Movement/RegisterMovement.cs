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

            Validate(req, product.Quantity);

            var description = "";

            if((int)req.Type == 1)
            {
                product.Quantity += req.Quantity;
                description = $"Adicionando {req.Quantity} de {product.ProductID} do ao estoque";
            }
            else
            {
                product.Quantity -= req.Quantity;
                description = $"Removendo {req.Quantity} de {product.ProductID} do estoque";
            }

            _stockRepository.Update(product, product.Quantity);

            return new ResponseMovement{
                Description = description,
                ProductCode = req.ProductCode,
                Quantity = product.Quantity
            };
        }

        private void Validate(RequestMovement req, long currentQuantity)
        {
            var result = new RegisterMovenmentValidation().Validate(req);
            var errors = result.Errors.Select(e => e.ErrorMessage).ToList();

            if((int)req.Type == 2 && currentQuantity - req.Quantity < 0)
            {
                errors.Add("Quantidade para remocao seria maior do que tem no estoque");
            }
            if (errors.Count > 0)
                throw new ProductException(errors);
        }
    }
}
