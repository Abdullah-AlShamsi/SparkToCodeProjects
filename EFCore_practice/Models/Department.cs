using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore_practice.Models
{
    public class Department
    {
        public int departmentID { get; set; }
        public int departmentNumber { get; set; }
        public string departmentName { get; set; }

        public List<Student> students { get; set; }
    }
}
