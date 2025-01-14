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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var user = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

                if (user != null)
                {
                    MessageBox.Show("Giriş başarılı! Hoş geldiniz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FrmDashboard frmDashboard = new FrmDashboard();
                    frmDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            FrmKayitOl frmKayitOl = new FrmKayitOl();
            frmKayitOl.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Text = "Kullanıcı adı";

            txtUsername.Enter += (s, ev) =>
            {
                if (txtUsername.Text == "Kullanıcı adı")
                {
                    txtUsername.Text = "";
                    txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
                    txtUsername.ForeColor = Color.Black; 
                }
            };

            txtUsername.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    txtUsername.Text = "Kullanıcı adı";
                    txtUsername.Font = new Font(txtUsername.Font, FontStyle.Regular);
                    txtUsername.ForeColor = Color.Gray;
                }
            };

            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;
        }
        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
