using CalculandoIR.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Services
{
    public class TaxCalculator : ITaxCalculator
    {
        public TaxCalculator()
        {
        }
        public double TaxCalculation(double value, double taxAliquot, double taxDeduction)
        {
            var finalValue = (value * taxAliquot) - taxDeduction;

            return finalValue;
        }
    }
}