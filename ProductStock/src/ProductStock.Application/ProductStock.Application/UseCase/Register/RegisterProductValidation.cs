using FluentValidation;
using ProductStock.Communication.Request;

namespace ProductStock.Application.UseCase.Register
{
    public class RegisterProductValidation : AbstractValidator<RequestProduct>
    {
        public RegisterProductValidation()
        {
            RuleFor(request => request.Products).NotEmpty().WithMessage("O input nao pode ser vazio");

            RuleForEach(request => request.Products).ChildRules(product =>
            {
                product.RuleFor(p => p.ProductID)
                .NotEmpty()
                .WithMessage("O id nao pode ser vazio");

                product.RuleFor(p => p.ProductDescription)
                .NotEmpty()
                .WithMessage("O id nao pode ser vazio");

                product.RuleFor(p => p.Quantity)
               .GreaterThanOrEqualTo(0)
               .WithMessage("O estoque nao pode ser negativo");

                product.RuleFor(p => p.ProductID)
                .GreaterThanOrEqualTo(0)
                .WithMessage("O id nao pode ser negativo");
            });
        }
    }
}
