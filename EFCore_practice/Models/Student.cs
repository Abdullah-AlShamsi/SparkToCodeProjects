using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore_practice.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string name { get; set; }
        public double age { get; set; }
        public double grade { get; set; }


        [ForeignKey("D")]
        public int departmentID { get; set; }
        public Department D { get; set; }

    }
}
