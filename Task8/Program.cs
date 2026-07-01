namespace Task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program Check Restaurant Bill with Membership Discount");

            // ask user to enter total bill amount
            Console.Write("Enter your total bill amount: ");
            double bill = double.Parse(Console.ReadLine());

            // ask user if has valid national ID
            Console.Write("Do you have a a loyalty member, answer(yes/no): ");
            string loyalty = Console.ReadLine();

            bool has_discount = false;

            if (loyalty == "yes" && bill > 20)
            {
                has_discount = true;
            }

            double discount = 0;
            Console.WriteLine("Original bil: " + bill + " OMR");
            if (has_discount == true)
            {
                discount = bill * 0.15;
                Console.WriteLine("Discount: " + discount + " OMR");
            }
            double final_bill = bill - discount;
            Console.WriteLine("Final bil: " + final_bill + " OMR");

        }
    }
}
