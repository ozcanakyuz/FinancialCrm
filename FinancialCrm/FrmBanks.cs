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

            //BANKA HESAP NUMARALARI
            var ziraatAccountNumber = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankAccountNumber).FirstOrDefault();
            var isAccountNumber = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankAccountNumber).FirstOrDefault();
            var yapiAccountNumber = db.Banks.Where(x => x.BankTitle == "Yapı Kredi").Select(y => y.BankAccountNumber).FirstOrDefault();

            lblZiraatBankAccountNumber.Text = ziraatAccountNumber.ToString();
            lblIsBankAccountNumber.Text = isAccountNumber.ToString();
            lblYapiBankAccountNumber.Text = yapiAccountNumber.ToString();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }


        private void btnCikisYap_Click_1(object sender, EventArgs e)
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

        private void btnFrmCategories_Click(object sender, EventArgs e)
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

        private void btnFrmBankProcess_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

    }
}
