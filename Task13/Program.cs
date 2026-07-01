namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program for Triangle Type Classifier");

            // ask user to enter the lengths of three sides of a triangle
            Console.WriteLine("Enter the lengths of three sides of a triangle: ");

            Console.Write("Enter the length of first side: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of second side: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of third side: ");
            double side3 = double.Parse(Console.ReadLine());
            
            double sum12 = side1 + side2;
            double sum13 = side1 + side3;
            double sum23 = side2 + side3;
            if (sum12 > side3 && sum13 > side2 && sum23 > side1)
            {
                if (side1 == side2 && side1 == side3)
                {
                    Console.WriteLine("The triangle is valid (Equilateral)");
                }
                else if (side1 == side2 || side1 == side3 || side2 == side3)
                {
                    Console.WriteLine("The triangle is valid (Isosceles)");
                }
                else
                {
                    Console.WriteLine("The triangle is valid (Scalene)");
                }
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }
        }
    }
}
