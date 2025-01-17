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
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        private void LoadSpendings()
        {
            var values = db.Spendings
                .Select(x => new
                {
                    x.SpendingId,
                    x.SpendingTitle,
                    x.SpendingAmount,
                    x.SpendingDate,
                    Categories = x.Categories.CategoryName
                })
                .ToList();

            dataGridView1.DataSource = values;
        }

        private void LoadCategories()
        {
            var categories = db.Categories
                .Select(c => new
                {
                    c.CategoryId,
                    c.CategoryName
                })
                .ToList();

            comboBoxCategory.DisplayMember = "CategoryName";
            comboBoxCategory.ValueMember = "CategoryId";
            comboBoxCategory.DataSource = categories;
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            LoadSpendings();
            LoadCategories();
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

        private void btnFrmBankProcess_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.Show();
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

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            try
            {
                string spendingTitle = txtSpendingName.Text.Trim();
                decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
                DateTime spendingDate = dateSpending.Value;
                int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);

                var isSpendingExists = db.Spendings
                    .Where(x => x.SpendingTitle == spendingTitle && x.CategoryId == categoryId)
                    .FirstOrDefault();

                if (isSpendingExists != null)
                {
                    MessageBox.Show("Bu başlığa ve kategoriye ait bir harcama zaten mevcut. Lütfen farklı bir harcama giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Spendings spendings = new Spendings
                {
                    SpendingTitle = spendingTitle,
                    SpendingAmount = spendingAmount,
                    SpendingDate = spendingDate,
                    CategoryId = categoryId
                };

                db.Spendings.Add(spendings);
                db.SaveChanges();

                MessageBox.Show("Harcama başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSpendings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeSpending = db.Spendings.Find(id);

            if (removeSpending != null)
            {
                db.Spendings.Remove(removeSpending);
                db.SaveChanges();
                MessageBox.Show("Harcama Başarıyla Silindi.", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSpendings();
            }
            else
            {
                MessageBox.Show("Böyle Bir Harcama Mevcut Değildir!", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text.Trim());
            string spendingName = txtSpendingName.Text.Trim();
            decimal spendingAmount = decimal.Parse(txtSpendingAmount.Text);
            DateTime spendingDate = dateSpending.Value;
            int categoryId = Convert.ToInt32(comboBoxCategory.SelectedValue);

            var updateSpending = db.Spendings.Find(id);
            if (!string.IsNullOrEmpty(spendingName) && spendingAmount != 0 && spendingDate != DateTime.MinValue)
            {
                updateSpending.SpendingTitle = spendingName;
                updateSpending.SpendingAmount = spendingAmount;
                updateSpending.SpendingDate = spendingDate;
                updateSpending.CategoryId = categoryId;

                db.SaveChanges();
                MessageBox.Show("Harcama Başarıyla Güncellendi.", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSpendings();
            }
            else
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız!", "Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtSpendingId.Text = row.Cells["SpendingId"].Value.ToString();
                txtSpendingName.Text = row.Cells["SpendingTitle"].Value.ToString();
                txtSpendingAmount.Text = row.Cells["SpendingAmount"].Value.ToString();
                dateSpending.Value = Convert.ToDateTime(row.Cells["SpendingDate"].Value);
                comboBoxCategory.Text = row.Cells["Categories"].Value.ToString();
            }
        }

    }
}
