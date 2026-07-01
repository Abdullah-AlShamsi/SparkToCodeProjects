namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Online Store Checkout");

            // ask user to enter a product code
            Console.Write("Enter a product code (1, 2, or 3): ");
            int product_code = int.Parse(Console.ReadLine());

            // ask user to enter quantity they want to buy
            Console.Write("Enter quantity you want to buy: ");
            int quantity = int.Parse(Console.ReadLine());

            // ask user if has have a discount coupon
            Console.Write("Do you have have a discount coupon, answer(yes/no): ");
            string discount_coupon = Console.ReadLine();

            double cost;
            double discount = 0;
            double subtotal;
            double total;
            double tax;
            double new_subtotal;
            switch (product_code)
            {
                case 1:
                    cost = 8.500;
                    subtotal = cost * quantity;
                    if (discount_coupon=="yes" && subtotal > 20)
                    {
                        discount = subtotal * 0.10;
                    }
                    new_subtotal = subtotal - discount;
                    tax = new_subtotal * 0.05;
                    total = new_subtotal + tax;
                    Console.WriteLine("The subtotal: " + subtotal + " OMR");
                    Console.WriteLine("The discount amount: " + discount + " OMR");
                    Console.WriteLine("The tax amount: " + tax + " OMR");
                    Console.WriteLine("The final total: " + total + " OMR");
                    break;

                case 2:
                    cost = 12.000;
                    subtotal = cost * quantity;
                    if (discount_coupon == "yes" && subtotal > 20)
                    {
                        discount = subtotal * 0.10;
                    }
                    new_subtotal = subtotal - discount;
                    tax = new_subtotal * 0.05;
                    total = new_subtotal + tax;
                    Console.WriteLine("The subtotal: " + subtotal + " OMR");
                    Console.WriteLine("The discount amount: " + discount + " OMR");
                    Console.WriteLine("The tax amount: " + tax + " OMR");
                    Console.WriteLine("The final total: " + total + " OMR");
                    break;


                case 3:
                    cost = 5.000;
                    subtotal = cost * quantity;
                    if (discount_coupon == "yes" && subtotal > 20)
                    {
                        discount = subtotal * 0.10;
                    }
                    new_subtotal = subtotal - discount;
                    tax = new_subtotal * 0.05;
                    total = new_subtotal + tax;
                    Console.WriteLine("The subtotal: " + subtotal + " OMR");
                    Console.WriteLine("The discount amount: " + discount + " OMR");
                    Console.WriteLine("The tax amount: " + tax + " OMR");
                    Console.WriteLine("The final total: " + total + " OMR");
                    break;

                default:
                    Console.WriteLine("Invalid product code");
                    break;
            }
        }
    }
}
