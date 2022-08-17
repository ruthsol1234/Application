using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_on_GUI
{
    internal class product

    {
        private static List<product> products = new List<product>();
    
        public string Number { get; set; }
        public string date { get; set; }
        public string inventorynumber { get; set; }
        public string objectname { get; set; }
        public string count { get; set; }
        public string price { get; set; }
        public bool available { get; set; }
        public static product findOne(string name)
        {
            return products.Find(p => p.objectname== name);
        }
        public void save()
        {
            products.Add(this);
            //Console.WriteLine("SAVE");
        }
        public static List<product> GetAll()
        {
            return products;
        }
        
    }
}
