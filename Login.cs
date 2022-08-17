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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if(username=="admin"& password == "password")
            {
                MessageBox.Show("Valid login");
                Main form1= new Main(username);
                Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("Incorrect! Try Again");
            }
        }
    }
}
