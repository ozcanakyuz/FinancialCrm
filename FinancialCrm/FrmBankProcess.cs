using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Filtreleme");
            comboBox1.Items.Add("Tümünü Göster");
            comboBox1.Items.Add("Maksimum Ücretli");
            comboBox1.Items.Add("Minimum Ücretli");
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem.ToString();
            FilterBanks(selectedFilter);
        }

        private void FilterBanks(string filterType)
        {
            if (filterType == "Tümünü Göster")
            {
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

                var bankProccess6 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(6).Skip(5).FirstOrDefault();
                lblBankProccess6.Text = bankProccess6.Description + " " + bankProccess6.Amount + "₺ " + " Tarih: " + bankProccess6.ProcessDate;

                var bankProccess7 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(7).Skip(6).FirstOrDefault();
                lblBankProccess7.Text = bankProccess7.Description + " " + bankProccess7.Amount + "₺ " + " Tarih: " + bankProccess7.ProcessDate;

                var bankProccess8 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(8).Skip(7).FirstOrDefault();
                lblBankProccess8.Text = bankProccess8.Description + " " + bankProccess8.Amount + "₺ " + " Tarih: " + bankProccess8.ProcessDate;

                var bankProccess9 = db.BankProcess.OrderByDescending(X => X.BankProcessId).Take(9).Skip(8).FirstOrDefault();
                lblBankProccess9.Text = bankProccess9.Description + " " + bankProccess9.Amount + "₺ " + " Tarih: " + bankProccess9.ProcessDate;

            }
            else if (filterType == "Maksimum Ücretli")
            {
                var maxBankProcess = db.BankProcess
                    .OrderByDescending(x => x.Amount)
                    .FirstOrDefault();

                if (maxBankProcess != null)
                {
                    lblBankProccess1.Text = $"Açıklama: {maxBankProcess.Description}\n";
                    lblBankProccess2.Text = $"Tutar: {maxBankProcess.Amount} ₺\n";
                    lblBankProccess3.Text = $"İşlem Türü: {maxBankProcess.ProcessType}\n";
                    lblBankProccess4.Text = $"Tarih: {maxBankProcess.ProcessDate:yyyy-MM-dd}\n";
                    lblBankProccess5.Text = $"Banka: {maxBankProcess.Banks.BankTitle}";

                    lblBankProccess6.Hide();
                    lblBankProccess7.Hide();
                    lblBankProccess8.Hide();
                    lblBankProccess9.Hide();
                }
                else
                {
                    MessageBox.Show("Herhangi bir işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (filterType == "Minimum Ücretli")
            {
                var minBankProcess = db.BankProcess
                    .OrderBy(x => x.Amount)
                    .FirstOrDefault();

                if (minBankProcess != null)
                {
                    lblBankProccess1.Text = $"Açıklama: {minBankProcess.Description}\n";
                    lblBankProccess2.Text = $"Tutar: {minBankProcess.Amount} ₺\n";
                    lblBankProccess3.Text = $"İşlem Türü: {minBankProcess.ProcessType}\n";
                    lblBankProccess4.Text = $"Tarih: {minBankProcess.ProcessDate:yyyy-MM-dd}\n";
                    lblBankProccess5.Text = $"Banka: {minBankProcess.Banks.BankTitle}";

                    lblBankProccess6.Hide();
                    lblBankProccess7.Hide();
                    lblBankProccess8.Hide();
                    lblBankProccess9.Hide();
                }
                else
                {
                    MessageBox.Show("Herhangi bir işlem bulunamadı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnFrmBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnFrmSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnFrmBilling_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnFrmCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
            this.Hide();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
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
