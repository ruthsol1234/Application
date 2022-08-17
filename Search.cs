using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_on_GUI
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = product.findOne(textBox1.Text);
            if (products == null) {

                MessageBox.Show("Enter Something");
            }
            else
            {
             // label7.Text = products.objectname;
                label7.Text = products.price;
                label8.Text = products.count;
                label9.Text = products.Number;
                label10.Text = products.inventorynumber;
              label11.Text = products.date;


            }
        }
    }
}
