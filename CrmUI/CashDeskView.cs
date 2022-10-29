using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUI
{
    public class CashDeskView
    {
        CashDesk CashDesk;

        public Label CashDeskNameLabel { get; set; }
        public Label LeaveCustomerLabel { get; set; }
        public NumericUpDown NumericUpDown { get; set; }
        public ProgressBar ProgressBar { get; set; }

        public CashDeskView(CashDesk cashDesk, int number, int x, int y)
        {     
            this.CashDesk = cashDesk;

            CashDeskNameLabel = new Label();
            LeaveCustomerLabel = new Label();
            NumericUpDown = new NumericUpDown();
            ProgressBar = new ProgressBar();

            CashDeskNameLabel.AutoSize = true;
            CashDeskNameLabel.Location = new System.Drawing.Point(x, y);
            CashDeskNameLabel.Name = "LCashDesk" + number;
            CashDeskNameLabel.Size = new System.Drawing.Size(35, 13);
            CashDeskNameLabel.TabIndex = number;
            CashDeskNameLabel.Text = "Cash Desk " + number;

            LeaveCustomerLabel.AutoSize = true;
            LeaveCustomerLabel.Location = new System.Drawing.Point(x + 400, y);
            LeaveCustomerLabel.Name = "LLeaveCustomer" + number;
            LeaveCustomerLabel.Size = new System.Drawing.Size(35, 13);
            LeaveCustomerLabel.TabIndex = number;
            LeaveCustomerLabel.Text = "";

            NumericUpDown.Location = new System.Drawing.Point(x + 100, y);
            NumericUpDown.Name = "NUDCashDesk" + number;
            NumericUpDown.Size = new System.Drawing.Size(120, 20);
            NumericUpDown.TabIndex = number;
            NumericUpDown.Maximum = 1000000000;

            ProgressBar.Location = new System.Drawing.Point(x + 250, y);
            ProgressBar.Maximum = CashDesk.MaxQueueLenght;
            ProgressBar.Name = "ProgressBar" + number;
            ProgressBar.Size = new System.Drawing.Size(100, 23);
            ProgressBar.TabIndex = number;
            ProgressBar.Value = 0;

            CashDesk.CheckClosed += CashDesk_CheckClosed;
        }

        private void CashDesk_CheckClosed(object sender, Check e)
        {
            NumericUpDown.Invoke((Action)delegate 
            { 
                NumericUpDown.Value += e.Price; 
                ProgressBar.Value = CashDesk.Count;
                LeaveCustomerLabel.Text = CashDesk.ExitCustomer.ToString();
            });
        }
    }
}
