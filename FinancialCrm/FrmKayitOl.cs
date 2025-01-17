using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinancialCrm
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string username = txtKayitOlUsername.Text.Trim();
            string password = txtKayitOlPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var existingUser = db.Users.FirstOrDefault(u => u.Username == username);
                if (existingUser != null)
                {
                    MessageBox.Show("Bu kullanıcı adı zaten alınmış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else if (username == "Kullanıcı adı" && password == "Şifre")
                {
                    MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Users newUser = new Users
                {
                    Username = username,
                    Password = password,
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show(($"Kayıt başarılı! {username}"), "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKayitOl_Load(object sender, EventArgs e)
        {
            txtKayitOlUsername.Font = new Font(txtKayitOlUsername.Font, FontStyle.Regular);
            txtKayitOlUsername.ForeColor = Color.Gray;
            txtKayitOlUsername.Text = "Kullanıcı adı";

            txtKayitOlUsername.Enter += (s, ev) =>
            {
                if (txtKayitOlUsername.Text == "Kullanıcı adı")
                {
                    txtKayitOlUsername.Text = "";
                    txtKayitOlUsername.Font = new Font(txtKayitOlUsername.Font, FontStyle.Regular);
                    txtKayitOlUsername.ForeColor = Color.Black;
                }
            };

            txtKayitOlUsername.Leave += (s, ev) =>
            {
                if (string.IsNullOrWhiteSpace(txtKayitOlUsername.Text))
                {
                    txtKayitOlUsername.Text = "Kullanıcı adı";
                    txtKayitOlUsername.Font = new Font(txtKayitOlUsername.Font, FontStyle.Regular);
                    txtKayitOlUsername.ForeColor = Color.Gray;
                }
            };

            txtKayitOlUsername.KeyDown += txtUsername_KeyDownRegister;
            txtKayitOlPassword.KeyDown += txtPassword_KeyDownRegister;
        }
        private void txtUsername_KeyDownRegister(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKayitOl.PerformClick();
            }
        }

        private void txtPassword_KeyDownRegister(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnKayitOl.PerformClick();
            }
        }

        private void btnFrmLogin_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
