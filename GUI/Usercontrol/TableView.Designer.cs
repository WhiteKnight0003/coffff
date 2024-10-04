namespace CoffeeApp.GUI.Usercontrol
{
    partial class TableView
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
            this.btnTableView = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnTableView
            // 
            this.btnTableView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableView.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTableView.ForeColor = System.Drawing.Color.White;
            this.btnTableView.Location = new System.Drawing.Point(0, 0);
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(100, 100);
            this.btnTableView.TabIndex = 0;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnTableView);
            this.Name = "TableView";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal Guna.UI2.WinForms.Guna2Button btnTableView;
    }
}
