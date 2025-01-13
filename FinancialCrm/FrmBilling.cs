using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Yeni Ödeme Eklendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removeBill = db.Bills.Find(id);

            if (removeBill != null)
            {
                db.Bills.Remove(removeBill);
                db.SaveChanges();
                MessageBox.Show("Ödeme Başarıyla Silindi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                var values = db.Bills.ToList();
                dataGridView1.DataSource = values;
            } else
            {
                MessageBox.Show("Böyle Bir Ödeme Mevcut Değildir!", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            var updateBill = db.Bills.Find(id);

            updateBill.BillTitle = title;
            updateBill.BillAmount = amount;
            updateBill.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme Güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

        }

        private void btnBanksFrom_Click(object sender, EventArgs e)
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
    }
}
