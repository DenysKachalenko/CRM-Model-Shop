using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.Model;

namespace CrmUI
{
    public partial class Main : Form
    {
        CrmContext db;

        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogProduct = new Catalog<Product>(db.Products, db);
            CatalogProduct.Show();
        }

        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogSeller = new Catalog<Seller>(db.Sellers, db);
            CatalogSeller.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogCustomer = new Catalog<Customer>(db.Customers, db);
            CatalogCustomer.Show();
        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var CatalogCheck = new Catalog<Check>(db.Checks, db);
            CatalogCheck.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ProductForm();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(Form.Product);
                db.SaveChanges();
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var Form = new SellerForm();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(Form.Seller);
                db.SaveChanges();
            }
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var Form = new CustomerForm();
            if (Form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(Form.Customer);
                db.SaveChanges();
            }
        }
    }
}
