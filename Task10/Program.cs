namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculate the area and perimeter of rectangle");

            // ask user to enter length
            Console.Write("Enter the length of rectangle: ");
            double length = double.Parse(Console.ReadLine());

            // ask user to enter width
            Console.Write("Enter the width of rectangle: ");
            double width = double.Parse(Console.ReadLine());
        }
    }
}
