using System;
using CalculandoIR.Services.Interfaces;
using CalculandoIR.Domain;
using CalculoIR.Screens.Interfaces;

namespace CalculandoIR.Screens
{
    public class CalculationScreen : ICalculationScreen
    {
        private readonly ITaxCalculator _taxCalculator;
        public CalculationScreen(ITaxCalculator taxCalculator)
        {
            _taxCalculator = taxCalculator;
        }

        public void MathStarts()
        {
            double value;
            bool valid = false;
            Console.WriteLine("Digite o valor do seu salário recebido ao longo do ano:");
            do
            {
                if (!double.TryParse(Console.ReadLine(), out value) || value < 0)
                    Console.WriteLine("Favor digitar um valor válido");
                else
                    valid = true;
            } while (valid != true);

            Console.WriteLine($"O valor que precisa ser pago é : {_taxCalculator.TaxCalculation(value)}");
           
        }
    }
}
