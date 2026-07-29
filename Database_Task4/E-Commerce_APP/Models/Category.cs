using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Category
    {
        [Key]
        public int category_ID { get; set; }

        public string name { get; set; }
        
        //product has Category
        [InverseProperty("category")]
        public List<Product> products { get; set; }
    }
}
