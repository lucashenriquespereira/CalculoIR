using Microsoft.Extensions.DependencyInjection;
using CalculoIR.Screens.Interfaces;
using CalculoIR.Services;

namespace CalculadoraIR.Presentation
{
    public class Program
    {
        public static void Main()
        {
            IServiceCollection services = new ServiceCollection();
            services.ConfigurePresentation()
                    .ConfigureServices();
            var serviceProvider = services.BuildServiceProvider();
            var calculationScreen = serviceProvider.GetService<ICalculationScreen>();
            calculationScreen.MathStarts();
        }
    }
}