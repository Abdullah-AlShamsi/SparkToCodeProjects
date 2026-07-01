namespace Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program For Day Name Finder");

            // ask user to a number from 1 to 7 representing a day
            Console.Write("Enter a number from 1 to 7 representing a day of the week: ");
            int dayNum = int.Parse(Console.ReadLine());
            switch (dayNum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }
        }
    }
}
