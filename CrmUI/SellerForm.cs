using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }

        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller Seller) : this()
        {
            this.Seller = Seller ?? new Seller();
            TBName.Text = Seller.Name;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void BOK_Click(object sender, EventArgs e)
        {
            Seller = Seller ?? new Seller();
            Seller.Name = TBName.Text;

            Close();
        }
    }
}
