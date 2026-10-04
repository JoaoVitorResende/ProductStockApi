using Microsoft.Extensions.DependencyInjection;
using ProductStock.Application.UseCase.Register;

namespace ProductStock.Application.UseCase
{
    public static class DependencyInjectionExtension
    {
        public static void AddApplication(this IServiceCollection services)
        {
            AddUseCases(services);
        }

        private static void AddUseCases(IServiceCollection services)
        {
            services.AddScoped<IRegisterProduct, RegisterProduct>();
        }
    }
}
