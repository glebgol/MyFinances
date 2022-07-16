using System;

namespace MyFinances.BL.Model
{
    public class Expence : FinanceItem
    {
        public ExpenceCategory Category { get; set; }

        public Expence() : base()
        {
            Category = ExpenceCategory.Other;
        }

        public Expence(decimal sum, string info) : base(sum, info)
        {
            Category = ExpenceCategory.Other;
        }

        public Expence(ExpenceCategory category, decimal sum, string info) : base(sum, info)
        {
            Category = category;
        }
    }
}
