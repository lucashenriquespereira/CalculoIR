    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace CalculandoIR.Domain
    {
        public class TaxTable
        {
            public double AnnualSalary { get; set; }
            public double TaxAliquot { get; set; }
            public double TaxDeduction { get; set; }
            public TaxTable()
            {
            }
        }

    }

    //    **Domain: camada responsável por conter:
    //        Classes que são apenas para conter dados (POCOs/DTOs)
    //        Enums
    //        Extensões
    //        Qualquer outro tipo de informação que seja comum a todas as camadas
