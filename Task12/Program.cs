namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Shipping Cost Calculator");

            // ask user to enter a region code
            Console.Write("Enter a region code ('A' for local, 'B' for national, 'C' for international): ");
            string region = Console.ReadLine();

            // ask user to enter package weight
            Console.Write("Enter package weight in kg: ");
            double weight = double.Parse(Console.ReadLine());

            double cost;
            double extra_charge = 0;
            double total;
            switch (region)
            {
                case "A":
                    cost = 1.000;
                    if (weight > 5)
                    {
                        extra_charge = 2.000;
                    }
                    if (weight > 10)
                    {
                        extra_charge = 5.000;
                    }
                    total = cost + extra_charge;
                    Console.WriteLine("The base cost: " + cost + " OMR");
                    Console.WriteLine("The extra charge: " + extra_charge + " OMR");
                    Console.WriteLine("The total shipping cost: " + total + " OMR");
                    break;

                case "B":
                    cost = 3.000;
                    if (weight > 5)
                    {
                        extra_charge = 2.000;
                    }
                    if (weight > 10)
                    {
                        extra_charge = 5.000;
                    }
                    total = cost + extra_charge;
                    Console.WriteLine("The base cost: " + cost + " OMR");
                    Console.WriteLine("The extra charge: " + extra_charge + " OMR");
                    Console.WriteLine("The total shipping cost: " + total + " OMR");
                    break;


                case "C":
                    cost = 7.000;
                    if (weight > 5)
                    {
                        extra_charge = 2.000;
                    }
                    if (weight > 10)
                    {
                        extra_charge = 5.000;
                    }
                    total = cost + extra_charge;
                    Console.WriteLine("The base cost: " + cost + " OMR");
                    Console.WriteLine("The extra charge: " + extra_charge + " OMR");
                    Console.WriteLine("The total shipping cost: " + total + " OMR");
                    break;

                default:
                    Console.WriteLine("Invalid region");
                    break;
            }

        }
    }
}
