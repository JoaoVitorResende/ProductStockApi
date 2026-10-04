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
                product.RuleFor(p => p.ProductID).GreaterThan(0).WithMessage("O id deve ser maior que zero.");
                product.RuleFor(p => p.ProductDescription).NotEmpty().WithMessage("A descrição não pode ser vazia.");
                product.RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0).WithMessage("O estoque não pode ser negativo.");
            });
        }
    }
}
