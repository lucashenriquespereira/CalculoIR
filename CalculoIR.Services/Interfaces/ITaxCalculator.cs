using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Services.Interfaces
{
    public interface ITaxCalculator
    {
        double TaxCalculation(double value, double taxAliquot, double taxDeduction);
    }
}
