using Microsoft.Extensions.DependencyInjection;
using ProductStock.Domain.Repositories;

namespace ProductStock.Infrastructure
{
    public static class DependencyInjectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            AddUseCases(services);
        }
        private static void AddUseCases(IServiceCollection services)
        {
            services.AddSingleton<IStockRepository, StockRepository>();
        }
    }
}
