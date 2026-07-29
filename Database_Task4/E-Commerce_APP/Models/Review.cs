using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Review
    {
        [Key]
        public int review_ID { get; set; }

        public double rating { get; set; }
        public string comment { get; set; }
    }
}
