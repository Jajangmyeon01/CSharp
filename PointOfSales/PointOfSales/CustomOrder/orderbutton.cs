using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSales.CustomOrder
{
    public partial class orderbutton : UserControl
    {
        public string itemId { get; set; }
        public string itemCategory
        {
            get { return category.Text; }
            set { category.Text = value; }
        }
        public string itemproductName
        {
            get { return productName.Text; }
            set { productName.Text = value; }
        }
        public string itemPrice
        {
            get { return price.Text; }
            set { price.Text = value; }
        }



        public orderbutton()
        {
            InitializeComponent();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }
}
