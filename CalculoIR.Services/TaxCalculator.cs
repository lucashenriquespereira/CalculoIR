using CalculandoIR.Domain;
using CalculandoIR.Services.Interfaces;

namespace CalculandoIR.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public double TaxCalculation(double value)
        {
            var taxTable = TaxLines.TaxList.LastOrDefault(t => t.AnnualSalary <= value);
            var finalValue = (value * taxTable.TaxAliquot) - taxTable.TaxDeduction;

            return finalValue;
        }
    }
}