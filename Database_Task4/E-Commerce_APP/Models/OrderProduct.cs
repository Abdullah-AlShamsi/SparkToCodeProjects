using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_APP.Models
{
    [PrimaryKey(nameof(order_id), nameof(product_id))]
    public class OrderProduct
    {
        public int Quantity { get; set; }

        [ForeignKey("order")]
        public int order_id { get; set; }
        public Order order { get; set; }


        [ForeignKey("product")]
        public int product_id { get; set; }
        public Product product { get; set; }

    }
}
