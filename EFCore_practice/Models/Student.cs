using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_practice.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double grade { get; set; }
    }
}
