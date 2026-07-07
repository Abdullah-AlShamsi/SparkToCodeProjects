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

            //// ask user to enter num1
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
        }
    }
}
