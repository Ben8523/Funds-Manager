using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundsManager
{
    public class Transaction
    {
        public decimal Amount { get; private set; }
        public string Description { get; private set; }
        public bool IsIncome { get; private set; }
        public bool IsRecurring { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public DateTime Date { get; private set; }

        public Transaction(decimal amount, string description, bool isIncome, bool isRecurring, PaymentMethod paymentMethod)
        {
            Amount = amount;
            Description = description;
            IsIncome = isIncome;
            IsRecurring = isRecurring;
            PaymentMethod = paymentMethod;
            Date = DateTime.Now;
        }

        public Transaction(decimal amount, string description, bool isIncome, bool isRecurring, PaymentMethod paymentMethod, DateTime date)
        {
            Amount = amount;
            Description = description;
            IsIncome = isIncome;
            IsRecurring = isRecurring;
            PaymentMethod = paymentMethod;
            Date = date;
        }
    }
}
