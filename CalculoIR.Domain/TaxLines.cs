namespace CalculandoIR.Domain
{
    public static class TaxLines
    {
        public static readonly List<TaxTable> TaxList = new()
        {
            new TaxTable {AnnualSalary = 0, TaxAliquot = 0, TaxDeduction = 0},
            new TaxTable {AnnualSalary = 22847.77, TaxAliquot = 0.075, TaxDeduction = 1713.58},
            new TaxTable {AnnualSalary = 33919.81, TaxAliquot = 0.150, TaxDeduction = 4257.57},
            new TaxTable {AnnualSalary = 45012.61, TaxAliquot = 0.225, TaxDeduction = 7633.51 },
            new TaxTable {AnnualSalary = 55976.17, TaxAliquot = 0.275, TaxDeduction = 10432.32}
        };
    }
}
