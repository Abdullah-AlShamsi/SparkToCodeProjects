namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program Is Temperature Converter");

            // ask user to enter a temperature in Celsius
            Console.Write("Enter the temperature in Celsius: ");
            double temperature_in_C = double.Parse(Console.ReadLine());

            double temperature_in_F = (temperature_in_C * 9 / 5) + 32;

            string weather;

            if (temperature_in_C < 10)
            {
                weather = "Cold";
            }
            else if (temperature_in_C > 30)
            {
                weather = "Hot";
            }
            else
            {
                weather = "Mild";
            }

            Console.WriteLine("The temperature in Fahrenheit is " + temperature_in_F);
            Console.WriteLine("The weather is " + weather);
        }
    }
}
