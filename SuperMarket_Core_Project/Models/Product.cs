using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket_Core_Project.Models
{
    public class Product
    {
           
        public int ProductID { get; set; }
        public string Productbrand { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
    }
}
