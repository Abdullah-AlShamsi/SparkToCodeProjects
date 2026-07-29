using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace E_Commerce_APP.Models
{
    public class User
    {
        [Key]
        public int user_ID { get; set; }

        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }


        //place order
        [InverseProperty("user")]
        public List<Order> orders { get; set; }
    }
}
