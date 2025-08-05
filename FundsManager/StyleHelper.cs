using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FundsManager
{
    public static class StyleHelper
    {
        #region input
        public static void StyleTextBox(TextBox txt)
        {
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.BackColor = Color.WhiteSmoke;
            txt.Font = new Font("Segoe UI", 10F);
            txt.ForeColor = Color.Black;
        }
        public static void StyleRadioButton(RadioButton radio)
        {
            radio.Font = new Font("Segoe UI", 10F);
            radio.ForeColor = Color.DarkSlateGray;
        }
        public static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            checkBox.ForeColor = Color.DimGray;
            checkBox.FlatStyle = FlatStyle.Flat;
            checkBox.FlatAppearance.BorderSize = 0;
            checkBox.Padding = new Padding(5, 2, 0, 2);
        }
        public static void StyleComboBox(ComboBox cmb)
        {
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.BackColor = Color.White;
            cmb.Font = new Font("Segoe UI", 10F);
        }
        #endregion

        #region Buttons
        public static void StyleAddButton(Button btn)
        {
            btn.BackColor = Color.MediumSeaGreen;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
        }
        public static void StyleRemoveButton(Button btn)
        {
            btn.BackColor = Color.Red;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.FlatAppearance.BorderSize = 0;
        }
        #endregion

        #region Lables
        public static void StyleLabel(Label label)
        {
            label.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            label.ForeColor = Color.DimGray;
        }
        public static void StyleStat(Label balanceLabel)
        {
            balanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        }
        public static void StyleMainTitle(Label label)
        {
            label.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label.ForeColor = Color.FromArgb(40, 40, 40);
        }
        #endregion

        #region Grid
        public static void StyleGridStructure(DataGridView dgv)
        {
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgv.RowHeadersVisible = false;

            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.DefaultCellStyle.Padding = new Padding(5, 2, 5, 2);
            dgv.Columns["IsIncome"].Visible = false;
            dgv.Columns["Amount"].Width = 90;
            dgv.Columns["Description"].Width = 200;
            dgv.Columns["IsRecurring"].Width = 70;
            dgv.Columns["PaymentMethod"].Width = 115;
            dgv.Columns["Date"].Width = 110;
            dgv.ColumnHeadersHeight = 40;
        }
        public static void StyleGridContent(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            dgv.RowTemplate.Height = 30;
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.White;
        }
        public static void StyleSearchControls(TextBox searchBox, Button searchButton)
        {
            searchBox.Font = new Font("Segoe UI", 13.5F, FontStyle.Regular);
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.BackColor = Color.White;
            searchBox.ForeColor = Color.Black;
            searchBox.Height = 35;

            searchButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular);
            searchButton.BackColor = Color.LightGray;
            searchButton.ForeColor = Color.Black;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.FlatAppearance.BorderColor = Color.DarkGray;
            searchButton.Height = 35;
            searchButton.Cursor = Cursors.Hand;
        }
        #endregion

        #region Chart
        public static void StyleChart(Chart chart)
        {
            var area = chart.ChartAreas[0];
            Font labelFont = new Font("Segoe UI", 9F);
            Font titleFont = new Font("Segoe UI", 10F, FontStyle.Bold);

            chart.ChartAreas[0].AxisX.LabelStyle.Font = labelFont;
            chart.ChartAreas[0].AxisY.LabelStyle.Font = labelFont;
            chart.ChartAreas[0].AxisX.TitleFont = titleFont;
            chart.ChartAreas[0].AxisY.TitleFont = titleFont;
            chart.Titles[0].Font = titleFont;

            if (chart.Legends.Count > 1)
            {
                chart.Legends[0].Font = labelFont;
                chart.Legends[1].Font = labelFont;
            }
        }
        #endregion
    }
}
