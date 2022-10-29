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
        Cart Cart;
        Customer Customer;
        CashDesk CashDesk;

        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
            Cart = new Cart(Customer);
            CashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db)
            {
                IsModel = false
            };
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

        private void modelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form = new ModelForm();
            Form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                LBProducts.Invoke((Action)delegate
                {
                    LBProducts.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });
            });
        }

        private void LBProducts_DoubleClick(object sender, EventArgs e)
        {
            if (LBProducts.SelectedItem is Product product)
            {
                Cart.Add(product);
                LBCart.Items.Add(product);
                UpdateLists();
            }
        }

        private void UpdateLists() 
        {
            LBCart.Items.Clear();
            LBCart.Items.AddRange(Cart.GetAll().ToArray());
            LSum.Text = "Sum: " + Cart.Price;
        }

        private void LLUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new Login();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if (tempCustomer != null)
                {
                    Customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    Customer = form.Customer;
                }
                Cart.Customer = Customer;

                LLUser.Text = $"Hello, {Customer.Name}!";
            }
        }

        private void BPay_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                CashDesk.Enqueue(Cart);
                var price = CashDesk.Dequeue();
                LBCart.Items.Clear();
                Cart = new Cart(Customer);

                MessageBox.Show("Successfull pay! Sum: " + price, "Pay completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Please, login", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
