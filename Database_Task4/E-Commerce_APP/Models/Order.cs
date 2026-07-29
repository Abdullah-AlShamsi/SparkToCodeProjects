using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Order
    {
        [Key]
        public int order_ID { get; set; }

        public DateTime date { get; set; }

    }
}
