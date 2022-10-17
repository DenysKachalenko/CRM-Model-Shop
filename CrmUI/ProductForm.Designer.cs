namespace CrmUI
{
    partial class ProductForm
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.BOK = new System.Windows.Forms.Button();
            this.LPrice = new System.Windows.Forms.Label();
            this.LCount = new System.Windows.Forms.Label();
            this.NUDPrice = new System.Windows.Forms.NumericUpDown();
            this.NUDCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCount)).BeginInit();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBName.Location = new System.Drawing.Point(53, 6);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(237, 20);
            this.TBName.TabIndex = 0;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(12, 9);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(41, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name: ";
            // 
            // BOK
            // 
            this.BOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BOK.Location = new System.Drawing.Point(215, 259);
            this.BOK.Name = "BOK";
            this.BOK.Size = new System.Drawing.Size(75, 23);
            this.BOK.TabIndex = 2;
            this.BOK.Text = "OK";
            this.BOK.UseVisualStyleBackColor = true;
            this.BOK.Click += new System.EventHandler(this.BOK_Click);
            // 
            // LPrice
            // 
            this.LPrice.AutoSize = true;
            this.LPrice.Location = new System.Drawing.Point(12, 35);
            this.LPrice.Name = "LPrice";
            this.LPrice.Size = new System.Drawing.Size(34, 13);
            this.LPrice.TabIndex = 4;
            this.LPrice.Text = "Price:";
            // 
            // LCount
            // 
            this.LCount.AutoSize = true;
            this.LCount.Location = new System.Drawing.Point(12, 61);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(38, 13);
            this.LCount.TabIndex = 6;
            this.LCount.Text = "Count:";
            // 
            // NUDPrice
            // 
            this.NUDPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDPrice.DecimalPlaces = 2;
            this.NUDPrice.Location = new System.Drawing.Point(53, 32);
            this.NUDPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NUDPrice.Name = "NUDPrice";
            this.NUDPrice.Size = new System.Drawing.Size(237, 20);
            this.NUDPrice.TabIndex = 7;
            // 
            // NUDCount
            // 
            this.NUDCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDCount.Location = new System.Drawing.Point(53, 58);
            this.NUDCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NUDCount.Name = "NUDCount";
            this.NUDCount.Size = new System.Drawing.Size(237, 20);
            this.NUDCount.TabIndex = 8;
            // 
            // ProductForm
            // 
            this.AcceptButton = this.BOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 294);
            this.Controls.Add(this.NUDCount);
            this.Controls.Add(this.NUDPrice);
            this.Controls.Add(this.LCount);
            this.Controls.Add(this.LPrice);
            this.Controls.Add(this.BOK);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TBName);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Button BOK;
        private System.Windows.Forms.Label LPrice;
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.NumericUpDown NUDPrice;
        private System.Windows.Forms.NumericUpDown NUDCount;
    }
}