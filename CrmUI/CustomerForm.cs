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
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }

        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer Customer) : this()
        {
            this.Customer = Customer;
            TBName.Text = Customer.Name;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void BOK_Click(object sender, EventArgs e)
        {
            var c = Customer ?? new Customer();
            c.Name = TBName.Text;

            Close();
        }
    }
}
