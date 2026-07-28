using EFCore_practice.Models;
using System.Security.Cryptography;

namespace EFCore_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();
            //add data on table student
            Student s1 = new Student();
            s1.name = "Abdullah";
            s1.grade = 100;
            s1.age = 22;
            context.students.Add(s1);
            context.SaveChanges();
        }
    }
}
