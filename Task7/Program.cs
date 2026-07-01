namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program Check Movie Ticket Pricing");

            // ask user to enter age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            string category;
            double price;
            if (age <= 12)
            {
                category = "Children";
                price = 2.000;
            }
            else if (age >= 60)
            {
                category = "Seniors";
                price = 3.000;
            }
            else
            {
                category = "Adults";
                price = 5.000;
            }
            Console.WriteLine("Category: " + category + ", price: " + price + " OMR");
        }
    }
}
