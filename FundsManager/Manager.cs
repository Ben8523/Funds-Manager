using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundsManager
{
    public class Manager
    {
        public List<Transaction> Transactions { get; private set; }
        public decimal Balance { get; private set; }

        public Manager()
        {
            Transactions = new List<Transaction>();
            Balance = 0;
        }

        public void AddTransaction(Transaction t)
        {
            Transactions.Add(t);
            Balance = t.IsIncome ? Balance + t.Amount : Balance - t.Amount;
        }

        public void RemoveTransaction()
        {
            Transaction t = Transactions.Last();

            Balance = t.IsIncome ? Balance - t.Amount : Balance + t.Amount;
            Transactions.RemoveAt(Transactions.Count - 1);
        }

        public void IncreaseBalance(decimal amount)
        {
            Balance += amount;
        }

        public void DecreaseBalance(decimal amount)
        {
            Balance -= amount;
        }

        public decimal WeeklyExpenses()
        {
            decimal expenses = 0;

            foreach (var transaction in Transactions)
                if (transaction.Date.Date >= DateTime.Today.AddDays(-6))
                    if (!transaction.IsIncome)
                        expenses += transaction.Amount;
            return expenses;
        }

        public float RecurringPrecent()
        {
            decimal expenses = 0;
            decimal recurringExpenses = 0;

            foreach (var transaction in Transactions)
            {
                if (!transaction.IsIncome)
                {
                    if (transaction.IsRecurring)
                        recurringExpenses += transaction.Amount;

                    expenses += transaction.Amount;
                }
            }
            return expenses != 0? (float)(recurringExpenses * (100 / expenses)) : 0;
        }
    }
}
