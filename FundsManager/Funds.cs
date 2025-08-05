using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace FundsManager
{
    public partial class Funds : Form
    {
        public Funds()
        {
            InitializeComponent();
        }
        private Manager manager = new Manager();
        private void Funds_Load(object sender, EventArgs e)
        {
            Paymentmethod.DataSource = Enum.GetValues(typeof(PaymentMethod));
            
            SetAnchors();
            UpdateUI();
            LoadChart();
        }

        #region events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Amount.Text, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount of money");
                return;
            }

            Transaction transaction = new Transaction
                (amount, Description.Text, radioIncome.Checked, Recurring.Checked, (PaymentMethod)Paymentmethod.SelectedItem);

            manager.AddTransaction(transaction);
            UpdateUI();
            LoadChart();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (manager.Transactions.Count == 0)
            {
                MessageBox.Show("No transactions to remove");
                return;
            }

            manager.RemoveTransaction();
            UpdateUI();
            LoadChart();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.ToLower();

            if (string.IsNullOrEmpty(query))
            {
                UpdateUI();
                return;
            }

            var filtered = manager.Transactions
                .Where(t => t.Description.ToLower().StartsWith(query))
                .OrderByDescending(t => t.Date)
                .ToList();

            GridTransactions.DataSource = null;
            GridTransactions.DataSource = filtered;
            StyleUI();
        }
        #endregion

        #region other
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioIncome_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioExpense_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void StyleTable(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }
        #endregion

        #region UI
        private void UpdateUI()
        {
            GridTransactions.DataSource = null;
            GridTransactions.DataSource = GetTransactionsSortedByDate();

            GridTransactions.ClearSelection();
            this.ActiveControl = null;

            UpdateStats();
            StyleUI();
        }
        private void UpdateStats()
        {
            BalanceValue.Text = manager.Balance.ToString();
            ExpensesWeekValue.Text = manager.WeeklyExpenses().ToString();
            RecurringValue.Text = manager.RecurringPrecent() + "%";
        }
        private List<Transaction> GetTransactionsSortedByDate()
        {
            return (manager.Transactions.OrderByDescending(t => t.Date)).ToList();
        }
        private void StyleUI()
        {
            StyleHelper.StyleLabel(lblAmount);
            StyleHelper.StyleLabel(lblDescription);
            StyleHelper.StyleLabel(lblPayment);
            StyleHelper.StyleStat(lblBalance);
            StyleHelper.StyleStat(BalanceValue);
            StyleHelper.StyleStat(RecurringStat);
            StyleHelper.StyleStat(RecurringValue);
            StyleHelper.StyleStat(ExpensesWeek);
            StyleHelper.StyleStat(ExpensesWeekValue);
            StyleHelper.StyleMainTitle(lblHeader);

            StyleHelper.StyleGridStructure(GridTransactions);
            StyleHelper.StyleGridContent(GridTransactions);
            StyleHelper.StyleTextBox(Description);
            StyleHelper.StyleTextBox(Amount);
            StyleHelper.StyleComboBox(Paymentmethod);
            StyleHelper.StyleSearchControls(txtSearch, btnSearch);

            StyleHelper.StyleRadioButton(radioIncome);
            StyleHelper.StyleRadioButton(radioExpense);
            StyleHelper.StyleAddButton(btnAdd);
            StyleHelper.StyleRemoveButton(btnRemove);
            StyleHelper.StyleCheckBox(Recurring);

            foreach (DataGridViewRow row in GridTransactions.Rows)
            {
                row.Height = GridTransactions.RowTemplate.Height;
            }
        }

        #region Anchors
        private void SetAnchors()
        {
            GridTransactions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chartSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Recurring.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            radioIncome.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            radioExpense.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHeader.Anchor = AnchorStyles.Top;

            BalanceValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBalance.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RecurringValue.Anchor = AnchorStyles.Bottom;
            RecurringStat.Anchor = AnchorStyles.Bottom;
            ExpensesWeekValue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ExpensesWeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }
        #endregion
        private void GridTransactions_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (GridTransactions.Columns[e.ColumnIndex].Name == "Amount")
            {
                var row = GridTransactions.Rows[e.RowIndex];

                if (row?.DataBoundItem is Transaction transaction && e.Value is decimal amount)
                {
                    if (transaction.IsIncome)
                    {
                        e.Value = $"+{amount}";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.Value = $"-{amount}";
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }

                    e.CellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                }
            }
        }
        private void GridTransactions_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = GridTransactions.Rows[e.RowIndex];
            if (row.DataBoundItem is Transaction transaction)
            {
                row.DefaultCellStyle.BackColor = transaction.IsIncome ? Color.Honeydew : Color.MistyRose;
            }
        }
        #endregion

        #region Statistics
        private void LoadChart()
        {
            chartSummary.Series.Clear();
            chartSummary.ChartAreas.Clear();
            chartSummary.Titles.Clear();

            DateTime today = DateTime.Today;
            DateTime startDate = today.AddDays(-6);

            Dictionary<DateTime, decimal> incomePerDay = new Dictionary<DateTime, decimal>();
            Dictionary<DateTime, decimal> expensePerDay = new Dictionary<DateTime, decimal>();

            ChartArea chartArea = new ChartArea("MainArea");
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.Title = "Date";
            chartArea.AxisY.Title = "Amount";
            chartSummary.ChartAreas.Add(chartArea);

            Series incomeSeries = new Series("Income")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.MediumSeaGreen
            };

            Series expenseSeries = new Series("Expenses")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.IndianRed
            };

            for (int i = 0; i < 7; i++)
            {
                DateTime date = startDate.AddDays(i).Date;
                incomePerDay[date] = 0;
                expensePerDay[date] = 0;
            }

            foreach (var transaction in manager.Transactions)
            {
                DateTime date = transaction.Date.Date;
                if (date >= startDate && date <= today)
                {
                    if (transaction.IsIncome)
                        incomePerDay[date] += transaction.Amount;
                    else
                        expensePerDay[date] += transaction.Amount;
                }
            }

            foreach (var date in incomePerDay.Keys.OrderBy(d => d))
            {
                string label = date.ToString("ddd dd/MM");
                incomeSeries.Points.AddXY(label, incomePerDay[date]);
                expenseSeries.Points.AddXY(label, expensePerDay[date]);
            }

            chartSummary.Series.Add(incomeSeries);
            chartSummary.Series.Add(expenseSeries);

            chartSummary.Titles.Add("Last 7 Days Overview");
            chartSummary.BackColor = this.BackColor;
            chartSummary.ChartAreas[0].BackColor = this.BackColor;
            chartSummary.Legends[0].BackColor = this.BackColor;
            StyleHelper.StyleChart(chartSummary);
        }

        #endregion

        
    }
}
