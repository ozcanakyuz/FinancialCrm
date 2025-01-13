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
        }
        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
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

    }
}
