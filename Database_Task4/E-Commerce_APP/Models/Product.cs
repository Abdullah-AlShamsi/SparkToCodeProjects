using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Product
    {
        [Key]
        public int product_ID { get; set; }

        public string name { get; set; }
        public double price { get; set; }


        //product has Category
        [ForeignKey("category")]
        public int category_id { get; set; }
        public Category category { get; set; }



        //OrderProduct rlationship
        [InverseProperty("product")]
        public List<OrderProduct> orderProducts { get; set; }
    }
}
