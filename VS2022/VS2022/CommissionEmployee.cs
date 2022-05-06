using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS2022
{
    public class CommissionEmployee : Employee
    {
        public float CommissioPercentaje { get; set; }
        public decimal Sales { get; set; }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal) CommissioPercentaje;
        }
        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"\n\tCommissioPercentaje.: {$"{CommissioPercentaje:P2}",18}" +
                $"\n\tSales...............: {$"{Sales:C2}",18}" +
                $"\n\tValue to pay........: {$"{GetValueToPay():C2}",18}";
        }
    }
}
