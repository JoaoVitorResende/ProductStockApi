using ProductStock.Communication.Request;
using ProductStock.Communication.Response;
using ProductStock.Domain.Repositories;
using ProductStock.Exception.ExceptionProduct;

namespace ProductStock.Application.UseCase.Register.Products
{
    public class RegisterProduct : IRegisterProduct
    {
        private readonly IStockRepository _repository;
        public RegisterProduct(IStockRepository repository)
        {
            _repository = repository;
        }
        public ResponseProduct Execute(RequestProduct req)
        {
            Validate(req);

            foreach (var item in req.Products) 
                _repository.Add(item);

            return new ResponseProduct { Products = req.Products };
        }

        private void Validate(RequestProduct req)
        {
            var result = new RegisterProductValidation().Validate(req);
            var errors = result.Errors.Select(e => e.ErrorMessage).ToList();

            var repeated = req.Products
                .GroupBy(p => p.ProductID)
                .Where(g => g.Count() > 1)
                .Select(g => $"O id {g.Key} aparece mais de uma vez na requisição.");
            errors.AddRange(repeated);

            var existing = req.Products
                .Where(p => _repository.Exists(p.ProductID))
                .Select(p => $"O id {p.ProductID} já está cadastrado.");
            errors.AddRange(existing);

            if (errors.Count > 0)
                throw new ProductException(errors);
        }
    }
}
