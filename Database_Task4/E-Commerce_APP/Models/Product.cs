using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Product
    {
        [Key]
        public int product_ID { get; set; }

        public string name { get; set; }
        public double price { get; set; }
    }
}
