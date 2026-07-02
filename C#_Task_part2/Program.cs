using System.Net.Sockets;

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
            //Console.WriteLine("Sum of Numbers 1 to N");

            //// ask user to enter a positive whole number N
            //Console.Write("Enter a positive whole number N: ");
            //int number = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i = 1; i <= number; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("The final sum = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 3
            //Console.WriteLine("Multiplication Table");

            //// ask user to enter a number
            //Console.Write("Enter number: ");
            //int number = int.Parse(Console.ReadLine());
            //int mul;
            //for (int i = 1; i <= 10; i++)
            //{
            //    mul = number * i;
            //    Console.WriteLine(number + " x " + i + " = " + mul);
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 4
            //Console.WriteLine("Password Retry System");

            //// ask user to enter the password
            //Console.Write("Enter the password: ");
            //string pass = Console.ReadLine();
            //while (pass != "Spark2026")
            //{
            //    Console.WriteLine("Incorrect password, try again");
            //    Console.Write("Enter the password: ");
            //    pass = Console.ReadLine();
            //}
            //Console.WriteLine("Access Granted");
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 5
            Console.WriteLine("Number Guessing Game");

            int secret_num = 42;
            int num_guess;
            int count = 0;
            do
            {
                count++;
                // ask user to Guess the correct number
                Console.Write("Guess the correct number: ");
                num_guess = int.Parse(Console.ReadLine());
                
                if (num_guess == secret_num)
                {
                    Console.WriteLine("Correct Guess");
                    Console.WriteLine("number of attempts: " + count);
                }
                else if (num_guess> secret_num)
                {
                    Console.WriteLine("Wrong guess, Too high");
                }
                else
                {
                    Console.WriteLine("Wrong guess, Too low");
                }

            } while (num_guess != 42);
            ////////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
