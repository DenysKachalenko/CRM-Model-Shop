using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product Product) : this()
        {
            this.Product = Product ?? new Product();
            TBName.Text = Product.Name;
            NUDPrice.Value = Product.Price;
            NUDCount.Value = Product.Count;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void BOK_Click(object sender, EventArgs e)
        {
            Product = Product ?? new Product();
            Product.Name = TBName.Text;
            Product.Price = NUDPrice.Value;
            Product.Count = Convert.ToInt32(NUDCount.Value);

            Close();
        }
    }
}
