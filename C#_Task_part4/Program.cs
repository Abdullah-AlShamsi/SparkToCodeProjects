namespace C__Task_part4
{
    internal class Program
    {
        //task 1
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        //task 2
        public static int Square(int num)
        {
            return num*num ;
        }

        //task 3
        public static double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        //task 4
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        //task 5
        public static bool IsEven(int num)
        {
            if ((num%2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //task 6
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return 2*(length+ width);
        }
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 1
            //// ask user to enter their name
            //Console.WriteLine("Personalized Welcome Function");
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //PrintWelcome(name);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 2
            //Console.WriteLine("Square Number Function");

            //// ask user to enter num
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Square of your number is: " + Square(num));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 3
            //Console.WriteLine("Celsius to Fahrenheit Function");

            //// ask user to enter temperature in celsius
            //Console.Write("Enter the temperature in celsius: ");
            //double temperature = double.Parse(Console.ReadLine());

            //Console.WriteLine("The temperature in Fahrenheit: " + CelsiusToFahrenheit(temperature));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //task 4
            //Console.WriteLine("Fixed Menu Display Function");
            //DisplayMenu();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 5
            //Console.WriteLine("Even or Odd Function");

            //// ask user to enter num
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsEven(num))
            //{
            //    Console.WriteLine("Your number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is odd");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 6
            Console.WriteLine("Rectangle Area & Perimeter Functions");

            // Ask the user for length and width
            Console.Write("Enter length of rectangle: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter width of rectangle: ");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle Area: " + CalculateArea(length,width));

            Console.WriteLine("Rectangle Perimeter: " + CalculatePerimeter(length, width));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
