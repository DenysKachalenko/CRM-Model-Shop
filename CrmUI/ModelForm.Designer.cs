namespace CrmUI
{
    partial class ModelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BStart = new System.Windows.Forms.Button();
            this.BStop = new System.Windows.Forms.Button();
            this.NUDCustomerSpeed = new System.Windows.Forms.NumericUpDown();
            this.NUDCashDeskSpeed = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCustomerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCashDeskSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // BStart
            // 
            this.BStart.Location = new System.Drawing.Point(713, 415);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(75, 23);
            this.BStart.TabIndex = 0;
            this.BStart.Text = "Start";
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // BStop
            // 
            this.BStop.Location = new System.Drawing.Point(632, 415);
            this.BStop.Name = "BStop";
            this.BStop.Size = new System.Drawing.Size(75, 23);
            this.BStop.TabIndex = 1;
            this.BStop.Text = "Stop";
            this.BStop.UseVisualStyleBackColor = true;
            // 
            // NUDCustomerSpeed
            // 
            this.NUDCustomerSpeed.Location = new System.Drawing.Point(632, 349);
            this.NUDCustomerSpeed.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUDCustomerSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDCustomerSpeed.Name = "NUDCustomerSpeed";
            this.NUDCustomerSpeed.Size = new System.Drawing.Size(156, 20);
            this.NUDCustomerSpeed.TabIndex = 2;
            this.NUDCustomerSpeed.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.NUDCustomerSpeed.ValueChanged += new System.EventHandler(this.NUDCustomerSpeed_ValueChanged);
            // 
            // NUDCashDeskSpeed
            // 
            this.NUDCashDeskSpeed.Location = new System.Drawing.Point(632, 375);
            this.NUDCashDeskSpeed.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.NUDCashDeskSpeed.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NUDCashDeskSpeed.Name = "NUDCashDeskSpeed";
            this.NUDCashDeskSpeed.Size = new System.Drawing.Size(156, 20);
            this.NUDCashDeskSpeed.TabIndex = 3;
            this.NUDCashDeskSpeed.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NUDCashDeskSpeed.ValueChanged += new System.EventHandler(this.NUDCashDeskSpeed_ValueChanged);
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NUDCashDeskSpeed);
            this.Controls.Add(this.NUDCustomerSpeed);
            this.Controls.Add(this.BStop);
            this.Controls.Add(this.BStart);
            this.Name = "ModelForm";
            this.Text = "ModelForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModelForm_FormClosing);
            this.Load += new System.EventHandler(this.ModelForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDCustomerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCashDeskSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.Button BStop;
        private System.Windows.Forms.NumericUpDown NUDCustomerSpeed;
        private System.Windows.Forms.NumericUpDown NUDCashDeskSpeed;
    }
}