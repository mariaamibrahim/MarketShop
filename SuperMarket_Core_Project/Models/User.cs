using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperMarket_Core_Project.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public string Numbers { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }
}
