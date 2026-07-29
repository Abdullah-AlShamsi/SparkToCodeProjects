using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class Order
    {
        [Key]
        public int order_ID { get; set; }

        public DateTime date { get; set; }



        //place order
        [ForeignKey("user")]
        public int user_id { get; set; }
        public User user { get; set; }


        //have review
        public Review review { get; set; }


        //OrderProduct rlationship
        [InverseProperty("order")]
        public List<OrderProduct> orderProducts { get; set; }

    }
}
