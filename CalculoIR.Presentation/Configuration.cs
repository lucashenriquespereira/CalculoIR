using CalculandoIR.Screens;
using CalculoIR.Screens.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CalculadoraIR.Presentation
{
    public static class Configuration
    {
        public static IServiceCollection ConfigurePresentation(this IServiceCollection services)
        {
            services.AddScoped<ICalculationScreen, CalculationScreen>();
            return services;
        }
    }
}
