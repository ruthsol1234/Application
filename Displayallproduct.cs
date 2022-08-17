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
    public partial class Displayallproduct : Form
    {
        public Displayallproduct()
        {
            InitializeComponent();
        }

        private void Displayallproduct_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = null;
            dataGridView1.DataSource = product.GetAll();
            // dataGridView1 ;
        }
    }
}
