namespace C__Task_part5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 1
            //Console.WriteLine("Fixed Grades Array");

            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    /// ask user to enter each grade
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //int j = 1;
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine("Grade " + j + ": " + grade);
            //    j++;
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 2
            //Console.WriteLine("Dynamic To-Do List");

            //List<string> to_do = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    /// ask user to enter each Task
            //    Console.Write("Enter Task " + (i + 1) + ": ");
            //    to_do.Add(Console.ReadLine()); 
            //}

            //int j = 1;
            //foreach (string task in to_do)
            //{
            //    Console.WriteLine("Task " + j + ": " + task);
            //    j++;
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 3
            Console.WriteLine("Browsing History Stack");

            Stack<string> history = new Stack<string>();

            for (int i = 0; i < 3; i++)
            {
                /// ask user to enter 3 website URLs
                Console.Write("Enter website " + (i + 1) + " URL: ");
                history.Push(Console.ReadLine());
            }

            
             Console.WriteLine("You pressed back, Website URL: " + history.Pop());
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
