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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void studentToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {


        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


         Login display = new Login();
            display.MdiParent = this;
            display.Show();
        }

        private void dispalyStudentToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dispalyStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Displayallproduct display = new Displayallproduct();
            display.MdiParent = this;
            display.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void departmentNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Displayallproduct display = new Displayallproduct();
            display.MdiParent = this;
            display.Show();
        }

        private void displayDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Search display = new Search();
            display.MdiParent = this;
            display.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void searchItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Search display = new Search();
            display.MdiParent = this;
            display.Show();
        }

        private void addNewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Login display = new Login();
            display.MdiParent = this;
            display.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


            Main display = new Main("Ahlam");
            display.MdiParent = this;
            display.Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }


           Formforusercontrol display = new Formforusercontrol();
            display.MdiParent = this;
            display.Show();
        }

        private void homePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activescreen = ActiveMdiChild;
            if (ActiveMdiChild != null)
            {
                activescreen.Close();
            }
          

           Formforusercontrol display = new Formforusercontrol();
            display.MdiParent = this;
            display.Show();
        }
    }
}

            

            

