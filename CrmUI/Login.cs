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
    public partial class Login : Form
    {
        public Customer Customer { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            Customer = new Customer()
            {
                Name = TBLogin.Text
            };
            DialogResult = DialogResult.OK;
        }
    }
}
