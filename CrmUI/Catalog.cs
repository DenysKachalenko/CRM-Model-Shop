using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class Catalog<T> : Form 
        where T : class 
    {
        CrmContext db;
        DbSet<T> set;

        public Catalog(DbSet<T> set, CrmContext db)
        {
            InitializeComponent();

            this.db = db;
            this.set = set;
            set.Load();
            DGVCatalog.DataSource = set.Local.ToBindingList();
        }

        private void Catalog_Load(object sender, EventArgs e)
        {
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (typeof(T) == typeof(Product))
            {
                var Form = new ProductForm();
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.Products.Add(Form.Product);
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var Form = new SellerForm();
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.Sellers.Add(Form.Seller);
                    db.SaveChanges();
                }
            }
            else if (typeof(T) == typeof(Customer))
            {
                var Form = new CustomerForm();
                if (Form.ShowDialog() == DialogResult.OK)
                {
                    db.Customers.Add(Form.Customer);
                    db.SaveChanges();
                }
            }
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            var Id = DGVCatalog.SelectedRows[0].Cells[0].Value;

            if (typeof(T) == typeof(Product))
            {
                var Product = set.Find(Id) as Product;
                if (Product != null)
                {
                    ProductForm Form = new ProductForm(Product);
                    if (Form.ShowDialog() == DialogResult.OK)
                    {
                        Product = Form.Product;
                        db.SaveChanges();
                        DGVCatalog.Update();
                    }
                }
            }
            else if (typeof(T) == typeof(Seller))
            {
                var Seller = set.Find(Id) as Seller;
                if (Seller != null)
                {
                    SellerForm Form = new SellerForm(Seller);
                    if (Form.ShowDialog() == DialogResult.OK)
                    {
                        Seller = Form.Seller;
                        db.SaveChanges();
                        DGVCatalog.Update();
                    }
                }
            }
            else if(typeof(T) == typeof(Customer))
            {
                var Customer = set.Find(Id) as Customer;
                if (Customer != null)
                {
                    CustomerForm Form = new CustomerForm(Customer);
                    if (Form.ShowDialog() == DialogResult.OK)
                    {
                        Customer = Form.Customer;
                        db.SaveChanges();
                        DGVCatalog.Update();
                    }
                }
            }
        }

        private void BDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
