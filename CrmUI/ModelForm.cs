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
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void BStart_Click(object sender, EventArgs e)
        {
            var cashDesks = new List<CashDeskView>();

            for (int i = 0; i < model.CashDesks.Count; ++i)
            {
                var Desk = new CashDeskView(model.CashDesks[i], i, 10, i * 26 + 26);
                cashDesks.Add(Desk);
                Controls.Add(Desk.CashDeskNameLabel);
                Controls.Add(Desk.LeaveCustomerLabel);
                Controls.Add(Desk.NumericUpDown);
                Controls.Add(Desk.ProgressBar);
            }

            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            NUDCustomerSpeed.Value = model.CustomerSpeed;
            NUDCashDeskSpeed.Value = model.CashDeskSpeed;
        }

        private void NUDCustomerSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = Convert.ToInt32(NUDCustomerSpeed.Value);
        }

        private void NUDCashDeskSpeed_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = Convert.ToInt32(NUDCashDeskSpeed.Value);
        }
    }
}
