using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFinances.BL.Model
{
    public class Income : FinanceItem
    {
        public IncomeCategory Category { get; set; }

        public Income() : base()
        {
            Category = IncomeCategory.Other;
        }

        public Income(decimal sum, string info) : base(sum, info)
        {
            Category = IncomeCategory.Other;
        }

        public Income(IncomeCategory category, decimal sum, string info) : base(sum, info)
        {
            Category = category;
        }
    }
}
