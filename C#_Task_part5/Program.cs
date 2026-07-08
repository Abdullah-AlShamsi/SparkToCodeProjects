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
            //Console.WriteLine("Browsing History Stack");

            //Stack<string> history = new Stack<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    /// ask user to enter 3 website URLs
            //    Console.Write("Enter website " + (i + 1) + " URL: ");
            //    history.Push(Console.ReadLine());
            //}


            // Console.WriteLine("You pressed back, Website URL: " + history.Pop());
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 4
            //Console.WriteLine("Customer Service Queue");

            //Queue<string> names = new Queue<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    /// ask user to enter 3 customer name
            //    Console.Write("Enter customer " + (i + 1) + " name: ");
            //    names.Enqueue(Console.ReadLine());
            //}


            //Console.WriteLine(names.Dequeue() + " was served");
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 5
            //Console.WriteLine("Array Grade Range");

            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    /// ask user to enter each grade
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //int sum = 0;
            //foreach (int grade in grades)
            //{
            //    sum += grade;
            //}
            //int ave = sum / grades.Length;

            //Console.WriteLine("The Lowest Grade: " + grades[0]);

            //Console.WriteLine("The Highest Grade: " + grades[grades.Length - 1]);

            //Console.WriteLine("The Average Grade: " + ave);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 6
            //Console.WriteLine("Filtered Shopping List");

            //List<string> shopping_list = new List<string>();
            //bool ISdone = false; 

            //while (!ISdone)
            //{
            //    /// ask user to enter each item Type "Done" to finish
            //    Console.Write("Enter item or type 'Done' to finish: ");
            //    string item = Console.ReadLine().ToLower();
            //    if(item == "done"){
            //        ISdone = true;
            //    }
            //    else
            //    {
            //        shopping_list.Add(item);
            //    }
            //}

            //Console.Write("Enter item to remove from list: ");
            //string remove_item = Console.ReadLine().ToLower();

            //Console.WriteLine("List before remove: ");
            //int j = 1;
            //foreach (string item in shopping_list)
            //{
            //    Console.WriteLine("Task " + j + ": " + item);
            //    j++;
            //}

            //shopping_list.Remove(remove_item);

            //Console.WriteLine("List after remove: ");
            //int k = 1;
            //foreach (string item in shopping_list)
            //{
            //    Console.WriteLine("Task " + k + ": " + item);
            //    k++;
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
