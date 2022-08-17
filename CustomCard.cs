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
    public partial class CustomCard : UserControl
    {
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value;lbl_title.Text = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; lbl_Description.Text = value; }
        }
        private string _price;

        public string Price
        {
            get { return _price; }
            set { _price= value; lbl_price.Text = value; }
        }
        public CustomCard()
        {
            InitializeComponent();
        }
    }
}
