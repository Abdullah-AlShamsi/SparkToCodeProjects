namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom To Even or Odd Checker");
            
            //read the number
            Console.Write("Enter a whole number: ");
            int num = int.Parse(Console.ReadLine());

            int mod = num % 2;

            if (mod == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }

        }
    }
}
