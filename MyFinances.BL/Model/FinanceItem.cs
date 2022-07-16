using System;

namespace MyFinances.BL.Model
{
    public abstract class FinanceItem
    {
        public DateTime Date { get; private set; }

        public decimal Sum { get; set; }

        public string Info { get; set; }

        protected FinanceItem()
        {
            Date = DateTime.Now;
            Sum = 0;
            Info = $"Other {Date.Day}.{Date.Month}";
        }

        protected FinanceItem(decimal sum, string info)
        {
            if (string.IsNullOrWhiteSpace(info))
            {
                throw new ArgumentNullException(nameof(info));
            }

            Date = DateTime.Now;
            Sum = sum;
            Info = info;
        }
    }
}
