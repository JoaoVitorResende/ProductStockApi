using FluentValidation;
using ProductStock.Communication.Request;

namespace ProductStock.Application.UseCase.Register.Movement
{
    public class RegisterMovenmentValidation: AbstractValidator<RequestMovement>
    {
        public RegisterMovenmentValidation()
        {
            RuleFor(request => request.ProductCode).GreaterThanOrEqualTo(0).WithMessage("O id nao pode ser negativo");
            RuleFor(request => request.Type).IsInEnum().WithMessage("O tipo deve ser entrada 1 ou saida 2");
            RuleFor(request => request.Quantity).GreaterThan(0).WithMessage("O valor nao pode ser menor igual a zero");
        }
    }
}
