using FinancialCrm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBanks : Form
    {
        public FrmBanks()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBanks_Load(object sender, EventArgs e)
        {
            // BANKA BAKIYELERI
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).FirstOrDefault();
            var yapiKrediBalance = db.Banks.Where(x => x.BankTitle == "Yapı Kredi").Select(y => y.BankBalance).FirstOrDefault();

            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";
            lblYapiKrediBalance.Text = yapiKrediBalance.ToString() + " ₺";
            
            // BANKA HAREKETLERI
            var bankProccess1 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(1).FirstOrDefault();
            lblBankProccess1.Text = bankProccess1.Description + " " + bankProccess1.Amount + "₺ " + " Tarih: " + bankProccess1.ProcessDate;
            
            var bankProccess2 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProccess2.Text = bankProccess2.Description + " " + bankProccess2.Amount + "₺ " + " Tarih: " + bankProccess2.ProcessDate;
            
            var bankProccess3 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProccess3.Text = bankProccess3.Description + " " + bankProccess3.Amount + "₺ " + " Tarih: " + bankProccess3.ProcessDate;
            
            var bankProccess4 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProccess4.Text = bankProccess4.Description + " " + bankProccess4.Amount + "₺ " + " Tarih: " + bankProccess4.ProcessDate;
            
            var bankProccess5 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProccess5.Text = bankProccess5.Description + " " + bankProccess5.Amount + "₺ " + " Tarih: " + bankProccess5.ProcessDate;
        }

        private void btnBillingForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }


        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

    }
}
