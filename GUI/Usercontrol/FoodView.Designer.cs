namespace CoffeeApp.GUI.Usercontrol
{
    partial class FoodView
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
            this.btnChooseFood = new Guna.UI2.WinForms.Guna2Button();
            this.pbImageFood = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbNameFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbDescriptFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbCashFood = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFood)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChooseFood
            // 
            this.btnChooseFood.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFood.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChooseFood.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChooseFood.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChooseFood.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseFood.ForeColor = System.Drawing.Color.White;
            this.btnChooseFood.Location = new System.Drawing.Point(150, 234);
            this.btnChooseFood.Name = "btnChooseFood";
            this.btnChooseFood.Size = new System.Drawing.Size(116, 40);
            this.btnChooseFood.TabIndex = 0;
            this.btnChooseFood.Text = "Chọn món";
            // 
            // pbImageFood
            // 
            this.pbImageFood.ImageRotate = 0F;
            this.pbImageFood.Location = new System.Drawing.Point(0, 0);
            this.pbImageFood.Name = "pbImageFood";
            this.pbImageFood.Size = new System.Drawing.Size(266, 151);
            this.pbImageFood.TabIndex = 1;
            this.pbImageFood.TabStop = false;
            // 
            // lbNameFood
            // 
            this.lbNameFood.BackColor = System.Drawing.Color.Transparent;
            this.lbNameFood.Location = new System.Drawing.Point(3, 157);
            this.lbNameFood.Name = "lbNameFood";
            this.lbNameFood.Size = new System.Drawing.Size(108, 18);
            this.lbNameFood.TabIndex = 2;
            this.lbNameFood.Text = "guna2HtmlLabel1";
            // 
            // lbDescriptFood
            // 
            this.lbDescriptFood.BackColor = System.Drawing.Color.Transparent;
            this.lbDescriptFood.Location = new System.Drawing.Point(3, 199);
            this.lbDescriptFood.Name = "lbDescriptFood";
            this.lbDescriptFood.Size = new System.Drawing.Size(108, 18);
            this.lbDescriptFood.TabIndex = 2;
            this.lbDescriptFood.Text = "guna2HtmlLabel1";
            // 
            // lbCashFood
            // 
            this.lbCashFood.BackColor = System.Drawing.Color.Transparent;
            this.lbCashFood.Location = new System.Drawing.Point(3, 256);
            this.lbCashFood.Name = "lbCashFood";
            this.lbCashFood.Size = new System.Drawing.Size(108, 18);
            this.lbCashFood.TabIndex = 2;
            this.lbCashFood.Text = "guna2HtmlLabel1";
            // 
            // FoodView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCashFood);
            this.Controls.Add(this.lbDescriptFood);
            this.Controls.Add(this.lbNameFood);
            this.Controls.Add(this.pbImageFood);
            this.Controls.Add(this.btnChooseFood);
            this.Name = "FoodView";
            this.Size = new System.Drawing.Size(269, 280);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnChooseFood;
        private Guna.UI2.WinForms.Guna2PictureBox pbImageFood;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbNameFood;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbDescriptFood;
        protected internal Guna.UI2.WinForms.Guna2HtmlLabel lbCashFood;
    }
}
