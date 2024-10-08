namespace CoffeeApp.GUI.Usercontrol
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseProduct = new Guna.UI2.WinForms.Guna2Button();
            this.pbImageProduct = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbNameProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDescriptProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCashProduct = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseProduct
            // 
            this.btnChooseProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseProduct.ForeColor = System.Drawing.Color.White;
            this.btnChooseProduct.Location = new System.Drawing.Point(150, 234);
            this.btnChooseProduct.Name = "btnChooseProduct";
            this.btnChooseProduct.Size = new System.Drawing.Size(116, 40);
            this.btnChooseProduct.TabIndex = 0;
            this.btnChooseProduct.Text = "Chọn món";
            // 
            // pbImageProduct
            // 
            this.pbImageProduct.ImageRotate = 0F;
            this.pbImageProduct.Location = new System.Drawing.Point(0, 0);
            this.pbImageProduct.Name = "pbImageProduct";
            this.pbImageProduct.Size = new System.Drawing.Size(266, 151);
            this.pbImageProduct.TabIndex = 1;
            this.pbImageProduct.TabStop = false;
            // 
            // lbNameProduct
            // 
            this.lbNameProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbNameProduct.Location = new System.Drawing.Point(3, 157);
            this.lbNameProduct.Name = "lbNameProduct";
            this.lbNameProduct.Size = new System.Drawing.Size(108, 18);
            this.lbNameProduct.TabIndex = 2;
            this.lbNameProduct.Text = "guna2HtmlLabel1";
            // 
            // lbDescriptProduct
            // 
            this.lbDescriptProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbDescriptProduct.Location = new System.Drawing.Point(3, 199);
            this.lbDescriptProduct.Name = "lbDescriptProduct";
            this.lbDescriptProduct.Size = new System.Drawing.Size(108, 18);
            this.lbDescriptProduct.TabIndex = 2;
            this.lbDescriptProduct.Text = "guna2HtmlLabel1";
            // 
            // lbCashProduct
            // 
            this.lbCashProduct.BackColor = System.Drawing.Color.Transparent;
            this.lbCashProduct.Location = new System.Drawing.Point(3, 256);
            this.lbCashProduct.Name = "lbCashProduct";
            this.lbCashProduct.Size = new System.Drawing.Size(108, 18);
            this.lbCashProduct.TabIndex = 2;
            this.lbCashProduct.Text = "guna2HtmlLabel1";
            // 
            // ProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCashProduct);
            this.Controls.Add(this.lbDescriptProduct);
            this.Controls.Add(this.lbNameProduct);
            this.Controls.Add(this.pbImageProduct);
            this.Controls.Add(this.btnChooseProduct);
            this.Name = "ProductView";
            this.Size = new System.Drawing.Size(269, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnChooseProduct;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageProduct;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbNameProduct;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbDescriptProduct;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbCashProduct;
    }
}
