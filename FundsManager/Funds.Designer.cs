using System.Windows.Forms;

namespace FundsManager
{
    public partial class Funds : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funds));
            this.lblAmount = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.Paymentmethod = new System.Windows.Forms.ComboBox();
            this.Recurring = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioExpense = new System.Windows.Forms.RadioButton();
            this.radioIncome = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.BalanceValue = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.GridTransactions = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.chartSummary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.RecurringStat = new System.Windows.Forms.Label();
            this.RecurringValue = new System.Windows.Forms.Label();
            this.ExpensesWeek = new System.Windows.Forms.Label();
            this.ExpensesWeekValue = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(67, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Amount
            // 
            this.Amount.Location = new System.Drawing.Point(145, 58);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(117, 20);
            this.Amount.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(50, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(145, 105);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(117, 20);
            this.Description.TabIndex = 5;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(23, 162);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(90, 13);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "Payment Method:";
            // 
            // Paymentmethod
            // 
            this.Paymentmethod.FormattingEnabled = true;
            this.Paymentmethod.Location = new System.Drawing.Point(145, 159);
            this.Paymentmethod.Name = "Paymentmethod";
            this.Paymentmethod.Size = new System.Drawing.Size(117, 21);
            this.Paymentmethod.TabIndex = 8;
            // 
            // Recurring
            // 
            this.Recurring.AutoSize = true;
            this.Recurring.Location = new System.Drawing.Point(41, 245);
            this.Recurring.Name = "Recurring";
            this.Recurring.Size = new System.Drawing.Size(72, 17);
            this.Recurring.TabIndex = 9;
            this.Recurring.Text = "Recurring";
            this.Recurring.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioExpense);
            this.groupBox1.Controls.Add(this.radioIncome);
            this.groupBox1.Location = new System.Drawing.Point(145, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(117, 49);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // radioExpense
            // 
            this.radioExpense.AutoSize = true;
            this.radioExpense.Location = new System.Drawing.Point(7, 23);
            this.radioExpense.Name = "radioExpense";
            this.radioExpense.Size = new System.Drawing.Size(66, 17);
            this.radioExpense.TabIndex = 1;
            this.radioExpense.TabStop = true;
            this.radioExpense.Text = "Expense";
            this.radioExpense.UseVisualStyleBackColor = true;
            this.radioExpense.CheckedChanged += new System.EventHandler(this.radioExpense_CheckedChanged);
            // 
            // radioIncome
            // 
            this.radioIncome.AutoSize = true;
            this.radioIncome.Location = new System.Drawing.Point(7, 3);
            this.radioIncome.Name = "radioIncome";
            this.radioIncome.Size = new System.Drawing.Size(60, 17);
            this.radioIncome.TabIndex = 0;
            this.radioIncome.TabStop = true;
            this.radioIncome.Text = "Income";
            this.radioIncome.UseVisualStyleBackColor = true;
            this.radioIncome.CheckedChanged += new System.EventHandler(this.radioIncome_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(41, 462);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(207, 36);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add Transaction";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(326, 306);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(86, 13);
            this.lblBalance.TabIndex = 12;
            this.lblBalance.Text = "Current Balance:";
            // 
            // BalanceValue
            // 
            this.BalanceValue.AutoSize = true;
            this.BalanceValue.Location = new System.Drawing.Point(491, 306);
            this.BalanceValue.Name = "BalanceValue";
            this.BalanceValue.Size = new System.Drawing.Size(13, 13);
            this.BalanceValue.TabIndex = 13;
            this.BalanceValue.Text = "0";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(593, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(81, 13);
            this.lblHeader.TabIndex = 14;
            this.lblHeader.Text = "Funds Manager";
            // 
            // GridTransactions
            // 
            this.GridTransactions.AllowUserToAddRows = false;
            this.GridTransactions.AllowUserToDeleteRows = false;
            this.GridTransactions.AllowUserToOrderColumns = true;
            this.GridTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTransactions.Location = new System.Drawing.Point(329, 88);
            this.GridTransactions.MultiSelect = false;
            this.GridTransactions.Name = "GridTransactions";
            this.GridTransactions.ReadOnly = true;
            this.GridTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.GridTransactions.Size = new System.Drawing.Size(963, 193);
            this.GridTransactions.TabIndex = 15;
            this.GridTransactions.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridTransactions_CellFormatting);
            this.GridTransactions.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.StyleTable);
            this.GridTransactions.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridTransactions_RowPrePaint);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(41, 513);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(207, 35);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove Transaction";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // chartSummary
            // 
            chartArea1.Name = "ChartArea1";
            this.chartSummary.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartSummary.Legends.Add(legend1);
            this.chartSummary.Location = new System.Drawing.Point(329, 354);
            this.chartSummary.Name = "chartSummary";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartSummary.Series.Add(series1);
            this.chartSummary.Size = new System.Drawing.Size(963, 248);
            this.chartSummary.TabIndex = 17;
            this.chartSummary.Text = "chart1";
            // 
            // RecurringStat
            // 
            this.RecurringStat.AutoSize = true;
            this.RecurringStat.Location = new System.Drawing.Point(641, 306);
            this.RecurringStat.Name = "RecurringStat";
            this.RecurringStat.Size = new System.Drawing.Size(124, 13);
            this.RecurringStat.TabIndex = 18;
            this.RecurringStat.Text = "% Of recurring expenses:";
            // 
            // RecurringValue
            // 
            this.RecurringValue.AutoSize = true;
            this.RecurringValue.Location = new System.Drawing.Point(871, 306);
            this.RecurringValue.Name = "RecurringValue";
            this.RecurringValue.Size = new System.Drawing.Size(21, 13);
            this.RecurringValue.TabIndex = 19;
            this.RecurringValue.Text = "0%";
            // 
            // ExpensesWeek
            // 
            this.ExpensesWeek.AutoSize = true;
            this.ExpensesWeek.Location = new System.Drawing.Point(1032, 306);
            this.ExpensesWeek.Name = "ExpensesWeek";
            this.ExpensesWeek.Size = new System.Drawing.Size(104, 13);
            this.ExpensesWeek.TabIndex = 20;
            this.ExpensesWeek.Text = "Expenses this week:";
            // 
            // ExpensesWeekValue
            // 
            this.ExpensesWeekValue.AutoSize = true;
            this.ExpensesWeekValue.Location = new System.Drawing.Point(1232, 306);
            this.ExpensesWeekValue.Name = "ExpensesWeekValue";
            this.ExpensesWeekValue.Size = new System.Drawing.Size(13, 13);
            this.ExpensesWeekValue.TabIndex = 21;
            this.ExpensesWeekValue.Text = "0";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(329, 50);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(807, 32);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.Text = "Search by description...";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1142, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 32);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Funds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 627);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ExpensesWeekValue);
            this.Controls.Add(this.ExpensesWeek);
            this.Controls.Add(this.RecurringValue);
            this.Controls.Add(this.RecurringStat);
            this.Controls.Add(this.chartSummary);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.GridTransactions);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.BalanceValue);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Recurring);
            this.Controls.Add(this.Paymentmethod);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.lblAmount);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Funds";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Funds_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox Paymentmethod;
        private System.Windows.Forms.CheckBox Recurring;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label BalanceValue;
        private System.Windows.Forms.Label lblHeader;
        private DataGridView GridTransactions;
        private Button btnRemove;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSummary;
        private Label RecurringStat;
        private Label RecurringValue;
        private Label ExpensesWeek;
        private Label ExpensesWeekValue;
        private TextBox txtSearch;
        private Button btnSearch;
    }
}

