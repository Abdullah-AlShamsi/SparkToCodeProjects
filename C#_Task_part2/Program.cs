namespace C__Task_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 1
            //Console.WriteLine("This Countdown Timer");

            //// ask user to enter a starting number
            //Console.Write("Enter a starting number: ");
            //int number = int.Parse(Console.ReadLine());

            //for(int i = number; i>0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            // task 2
            Console.WriteLine("Sum of Numbers 1 to N");

            // ask user to enter a positive whole number N
            Console.Write("a positive whole number N: ");
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                sum += i;
            }
            Console.WriteLine("The final sum = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
