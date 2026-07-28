using EFCore_practice.Models;
using System.Security.Cryptography;

namespace EFCore_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();
            ////add data on table student
            //Student s1 = new Student();
            //s1.name = "Abdullah";
            //s1.grade = 100;
            //s1.age = 22;
            //context.students.Add(s1);
            //context.SaveChanges();


            //keep user enter student 
            Student s2 = new Student();
            Console.WriteLine("Enter student name: ");
            s2.name = Console.ReadLine();

            Console.WriteLine("Enter student grade: ");
            s2.grade = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter student age: ");
            s2.age = int.Parse(Console.ReadLine());

            context.students.Add(s2);
            context.SaveChanges();
        }
    }
}
