using CalculandoIR.Services;
using CalculandoIR.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculoIR.Services
{
    public static class Configure
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<ITaxCalculator, TaxCalculator>();
            return services;
        }
    }
}
