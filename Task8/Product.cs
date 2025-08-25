using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Image {  get; set; }
        public Categories Category { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Price} руб.";
        }

    }
}
