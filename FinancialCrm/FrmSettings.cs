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
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }


        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void LoadUserData()
        {
            var user = db.Users
                .Where(x => x.UserId == FrmLogin.LoggedInUserId)
                .Select(u => new
                {
                u.Username,
                u.Password,
                }).ToList();

            dataGridView1.DataSource = user;
        }
        private void FrmSettings_Load(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Çıkış Yap", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(oldPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confirmPassword))
            {
                lblMessage.Text = "Lütfen tüm alanları doldurun.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            var user = db.Users.FirstOrDefault(x => x.UserId == FrmLogin.LoggedInUserId);
            if (user == null || user.Password != oldPassword)
            {
                lblMessage.Text = "Eski şifreniz yanlış.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (newPassword != confirmPassword)
            {
                lblMessage.Text = "Yeni şifre ve tekrar şifre uyuşmuyor.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            user.Password = newPassword;
            db.SaveChanges();

            lblMessage.Text = "Şifre başarıyla güncellendi";
            lblMessage.ForeColor = Color.Green;

            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtConfirmPassword.Clear();

            LoadUserData();
        }

        private void btnFrmBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnFrmBilling_Click(object sender, EventArgs e)
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

        private void btnFrmCategories_Click(object sender, EventArgs e)
        {
            FrmCategories frmCategories = new FrmCategories();
            frmCategories.Show();
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
