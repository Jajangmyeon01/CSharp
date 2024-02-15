namespace PointOfSales.CustomOrder
{
    partial class orderbutton
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
            this.item = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.price = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.Label();
            this.item.SuspendLayout();
            this.SuspendLayout();
            // 
            // item
            // 
            this.item.BorderRadius = 10;
            this.item.Controls.Add(this.price);
            this.item.Controls.Add(this.productName);
            this.item.Controls.Add(this.category);
            this.item.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.item.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.item.Location = new System.Drawing.Point(4, 4);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(132, 131);
            this.item.TabIndex = 0;
            this.item.Click += new System.EventHandler(this.label6_Click);
            this.item.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Tahoma", 9F);
            this.price.ForeColor = System.Drawing.Color.Red;
            this.price.Location = new System.Drawing.Point(3, 117);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(35, 14);
            this.price.TabIndex = 9;
            this.price.Text = "$199";
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.productName.ForeColor = System.Drawing.Color.White;
            this.productName.Location = new System.Drawing.Point(21, 54);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(97, 14);
            this.productName.TabIndex = 8;
            this.productName.Text = "PRODUCT NAME";
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Tahoma", 7F);
            this.category.ForeColor = System.Drawing.Color.White;
            this.category.Location = new System.Drawing.Point(-3, 0);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 12);
            this.category.TabIndex = 7;
            this.category.Text = "CATEGORY: BREAKFAST";
            // 
            // orderbutton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(60)))));
            this.Controls.Add(this.item);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "orderbutton";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Size = new System.Drawing.Size(140, 139);
            this.item.ResumeLayout(false);
            this.item.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel item;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label productName;
    }
}
