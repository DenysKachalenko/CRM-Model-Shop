namespace CrmUI
{
    partial class Catalog<T>
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
            this.DGVCatalog = new System.Windows.Forms.DataGridView();
            this.BAdd = new System.Windows.Forms.Button();
            this.BChange = new System.Windows.Forms.Button();
            this.BDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVCatalog
            // 
            this.DGVCatalog.AllowUserToAddRows = false;
            this.DGVCatalog.AllowUserToDeleteRows = false;
            this.DGVCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCatalog.Location = new System.Drawing.Point(12, 12);
            this.DGVCatalog.MultiSelect = false;
            this.DGVCatalog.Name = "DGVCatalog";
            this.DGVCatalog.ReadOnly = true;
            this.DGVCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVCatalog.Size = new System.Drawing.Size(776, 397);
            this.DGVCatalog.TabIndex = 0;
            // 
            // BAdd
            // 
            this.BAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BAdd.Location = new System.Drawing.Point(270, 415);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // BChange
            // 
            this.BChange.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BChange.Location = new System.Drawing.Point(351, 415);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(75, 23);
            this.BChange.TabIndex = 2;
            this.BChange.Text = "Change";
            this.BChange.UseVisualStyleBackColor = true;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // BDelete
            // 
            this.BDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BDelete.Location = new System.Drawing.Point(432, 415);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(75, 23);
            this.BDelete.TabIndex = 3;
            this.BDelete.Text = "Delete";
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BDelete);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.DGVCatalog);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCatalog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVCatalog;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.Button BDelete;
    }
}