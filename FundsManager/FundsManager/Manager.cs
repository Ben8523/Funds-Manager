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
            Transactions = new List<Transaction>
{
// יום שני - 16 ביוני
new Transaction(350, "Sold Old Furniture", true, false, PaymentMethod.Cash, new DateTime(2025, 6, 16)),
new Transaction(90, "Supermarket", false, false, PaymentMethod.CreditCard, new DateTime(2025, 6, 16)),
new Transaction(25, "Parking", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 16)),

// יום שלישי - 17 ביוני
new Transaction(2100, "Website Design Project", true, false, PaymentMethod.BankTransfer, new DateTime(2025, 6, 17)),
new Transaction(18, "Lunch", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 17)),
new Transaction(60, "Streaming Service", false, true, PaymentMethod.CreditCard, new DateTime(2025, 6, 17)),

// יום רביעי - 18 ביוני
new Transaction(600, "Gift from Family", true, false, PaymentMethod.BankTransfer, new DateTime(2025, 6, 18)),
new Transaction(850, "Clothing Purchase", false, false, PaymentMethod.CreditCard, new DateTime(2025, 6, 18)),
new Transaction(45, "Cafe with Friends", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 18)),

// יום חמישי - 19 ביוני
new Transaction(90, "Tutoring Session", true, false, PaymentMethod.Cash, new DateTime(2025, 6, 19)),
new Transaction(40, "Gasoline", false, false, PaymentMethod.CreditCard, new DateTime(2025, 6, 19)),
new Transaction(12, "Shawarma", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 19)),

// יום שישי - 20 ביוני
new Transaction(1200, "Weekly Salary", true, true, PaymentMethod.BankTransfer, new DateTime(2025, 6, 20)),
new Transaction(150, "Weekend Groceries", false, false, PaymentMethod.CreditCard, new DateTime(2025, 6, 20)),
new Transaction(50, "Bakery and Wine", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 20)),

// שבת - 21 ביוני
new Transaction(0, "No Transactions", true, false, PaymentMethod.Cash, new DateTime(2025, 6, 21)), // שבת שקטה :)

// יום ראשון - 22 ביוני (היום)
new Transaction(1200, "Freelance Project", true, false, PaymentMethod.BankTransfer, new DateTime(2025, 6, 22)),
new Transaction(25, "Bus Ticket", false, false, PaymentMethod.CreditCard, new DateTime(2025, 6, 22)),
new Transaction(448, "Groceries - Quick Buy", false, false, PaymentMethod.Cash, new DateTime(2025, 6, 22)),
new Transaction(20, "Gift", true, false, PaymentMethod.Cash, new DateTime(2025, 6, 22)),
new Transaction(89, "Phone Bill", false, true, PaymentMethod.CreditCard, new DateTime(2025, 6, 22))


};



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

        public int RecurringPrecent()
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
            return (int)(recurringExpenses * (100 / expenses));
        }
    }
}
