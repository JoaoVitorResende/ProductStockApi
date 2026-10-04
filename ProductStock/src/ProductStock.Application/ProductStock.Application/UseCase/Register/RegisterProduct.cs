using ProductStock.Communication.Request;
using ProductStock.Communication.Response;
using ProductStock.Exception.ExceptionProduct;
using ProductStock.Infrastructure;

namespace ProductStock.Application.UseCase.Register
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
            if (!result.IsValid)
            {
                var errors = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ProductException(errors);
            }
        }
    }
}
