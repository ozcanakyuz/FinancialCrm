using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class FrmCategories : Form
    {
        public FrmCategories()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void LoadCategories()
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
        }
        private void FrmCategories_Load(object sender, EventArgs e)
        {
            LoadCategories();
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

        private void btnFrmBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
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

        private void btnFrmSpendings_Click(object sender, EventArgs e)
        {
            FrmSpendings frmSpendings = new FrmSpendings();
            frmSpendings.Show();
            this.Hide();
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            string categoryName = txtCategoryName.Text;

            Categories categories = new Categories();
            categories.CategoryName = categoryName;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Yeni Kategori Eklendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeCategory = db.Categories.Find(id);

            if (removeCategory != null)
            {
                db.Categories.Remove(removeCategory);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Silindi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCategories();
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Mevcut Değildir!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text.Trim());
            string categoryName = txtCategoryName.Text.Trim();

            var updateCategory = db.Categories.Find(id);

            updateCategory.CategoryName = categoryName;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCategories();
        }
    }
}
