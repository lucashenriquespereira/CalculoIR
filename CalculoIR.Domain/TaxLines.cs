using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculandoIR.Domain
{
    public class TaxLines : TaxTable
    {
        public class TaxLine1
        {
            AnnualSalary = 0;
            TaxAliquot = 0;
            TaxDeduction = 0;
        }
        public class TaxLine2
        {
            AnnualSalary = 22.847,77;
            TaxAliquot = 0.075;
            TaxDeduction = 1.713,58;
        }
        public class TaxLine3
        {
            AnnualSalary = 33.919,81;
            TaxAliquot = 0.150;
            TaxDeduction = 4.257,57;
        }
        public class TaxLine4
        {
            AnnualSalary = 45.012,61;
            TaxAliquot = 0.225;
            TaxDeduction = 7.633,51;
        }
        public class TaxLine5
        {
            AnnualSalary = 55.976,17;
            TaxAliquot = 0.275;
            TaxDeduction = 10.432,32;
        }
    }
}
