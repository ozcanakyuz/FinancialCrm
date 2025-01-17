using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => (decimal?)x.BankBalance) ?? 0;
            lblTotalBalance.Text = $"{totalBalance:0,0.00}₺";

            var lastBankProcessAmount = db.BankProcess.OrderByDescending(x => x.BankProcessId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "₺";

            // CHART_1 KODLARI
            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance
            }).ToList();

            chart1.Series.Clear();
            var series1 = chart1.Series.Add("BankSeries");
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column; // Sütun grafiği
            series1.IsValueShownAsLabel = true;

            foreach (var item in bankData)
            {
                series1.Points.AddXY(item.BankTitle, item.BankBalance);
            }

            // CHART_2 KODLARI
            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();
            var series2 = chart2.Series.Add("BillSeries");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie; // Pasta grafiği
            series2.IsValueShownAsLabel = true;

            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void btnBankForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            var bills = new List<string> { "Elektrik Faturası", "Su Faturası", "Doğalgaz Faturası", "İnternet" };

            int index = (count % 5) - 1;
            if (index >= 0)
            {
                string selectedBill = bills[index];
                var billAmount = db.Bills.Where(x => x.BillTitle == selectedBill).Select(y => y.BillAmount).FirstOrDefault();

                lblBillTitle.Text = selectedBill;
                lblBillAmount.Text = billAmount.ToString() + "₺";
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
            this.Hide();
        }
        private void btnFrmCategories_Click_1(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnFrmSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }
    }
}
