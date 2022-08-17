using System;
using System.Text.RegularExpressions;
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
    public partial class Main : Form
    {
        public string username { get; set; }
        public Main(string user)
        {
            InitializeComponent();
            label7.Text = user;
        }

        /*public Main()
        {
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_buttonclick1_Click(object sender, EventArgs e)
        {
           
     
           product md= new product();
            {
                md.Number = txt_number.Text;
                md.date=txt_date.Text;
                md.inventorynumber = txt_inventorynumber.Text;
                md.objectname = txt_objectname.Text;
                md.price=txt_price.Text;
                md.count=txt_count.Text;
                checkedListBox1.CheckedItems.Contains(md);
                String message = " ";
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    message += item.ToString();
                }
              //  MessageBox.Show(message);
                
            }
            md.save();
            if (string.IsNullOrEmpty(txt_number.Text))
            {
                errorProvider1.SetError(txt_number, "Number is required");
            }
           /* else
            { errorProvider1.Clear(); }
           */

          if (txt_objectname.Text .Length <3)
            {
                errorProvider1.SetError(txt_objectname, "Miniumum ");
            }
            Regex regex = new Regex(@"^[a-z] { 2}$");
            if (regex.IsMatch(txt_objectname.Text))
            {

            }
            else
            {
               // MessageBox.Show("Hmmm");
            }

            gridview_register.DataSource = null;
            gridview_register.DataSource = product.GetAll();
            MessageBox.Show("Item Added");
            
         
            
           
            
            /* string number=txt_number.Text;
             string date= txt_date.Text;
             string inventory_number=txt_inventorynumber.Text;
             string object_name=txt_objectname.Text;
             string count=txt_count.Text;
             string price=txt_price.Text;
             MessageBox.Show("Item Added");*/
        }

        private void txt_buttonclick2_Click(object sender, EventArgs e)
        {
this.Close();
        }

        private void gridview_register_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
