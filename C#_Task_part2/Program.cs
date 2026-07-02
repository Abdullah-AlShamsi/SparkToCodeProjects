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
            //Console.WriteLine("Number Guessing Game");

            //int secret_num = 42;
            //int num_guess;
            //int count = 0;
            //do
            //{
            //    count++;
            //    // ask user to Guess the correct number
            //    Console.Write("Guess the correct number: ");
            //    num_guess = int.Parse(Console.ReadLine());

            //    if (num_guess == secret_num)
            //    {
            //        Console.WriteLine("Correct Guess");
            //        Console.WriteLine("number of attempts: " + count);
            //    }
            //    else if (num_guess> secret_num)
            //    {
            //        Console.WriteLine("Wrong guess, Too high");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Wrong guess, Too low");
            //    }

            //} while (num_guess != secret_num);
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 6
            //Console.WriteLine("Safe Division Calculator");
            //try
            //{
            //    // ask user to enter num1
            //    Console.Write("Enter first number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    // ask user to enter num2
            //    Console.Write("Enter second number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;

            //    Console.WriteLine(num1 + " / " + num2 + " = " + result);

            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid number.");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 7
            //Console.WriteLine("Repeating Menu with Exit Option");

            //int num = -1;
            //while (num != 3)
            //{
            //    Console.WriteLine("");
            //    Console.WriteLine("The menu");
            //    Console.WriteLine("1) Say Hello");
            //    Console.WriteLine("2) Show Current Time-of-day Greeting");
            //    Console.WriteLine("3) Exit");
            //    Console.WriteLine("");
            //    // ask user to select number from the menu
            //    Console.Write("select number from the menu: ");
            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //        continue;
            //    }
            //    switch (num)
            //    {
            //        case 1:
            //            Console.WriteLine("Hello");
            //            break;

            //        case 2:
            //            Console.WriteLine("10:00 AM, Morning");
            //            break;

            //        case 3:
            //            break;

            //        default:
            //            Console.WriteLine("Invalid Number");
            //            break;
            //    }

            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 8
            //Console.WriteLine("Sum of Even Numbers Only");

            //// ask user to enter a positive whole number N
            //Console.Write("Enter a positive whole number N: ");
            //int num = int.Parse(Console.ReadLine());

            //int sum = 0;
            //for (int i=1; i<=num; i++)
            //{
            //    int mod = i % 2;

            //    if (mod == 0)
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("Final sum = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 9
            //Console.WriteLine("Validated Positive Number Input");
            //bool isValid = false;
            //int num = -1;
            //do
            //{
            //    // ask user to enter a positive whole number N
            //    Console.Write("Enter a positive whole number N: ");
            //    try
            //    {
            //        num = int.Parse(Console.ReadLine());
            //        if (num > 0)
            //        {
            //            isValid = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid input. Please enter a valid number.");
            //        }
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //} while (!isValid);

            //int sum = 0;
            //for (int i=1; i <= num; i++)
            //{
            //    sum += i;
            //}
            //Console.WriteLine("Final sum = " + sum);
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 10
            Console.WriteLine("Simple ATM Simulation");
            int pin = 2453;
            double balance = 100.000;
            bool isValid = false;

            for (int i=0; i<3; i++)
            {
                // ask user to enter the PIN
                Console.Write("Enter the PIN: ");
                try
                {
                    int inPIN = int.Parse(Console.ReadLine());
                    if (inPIN == pin)
                    {
                        isValid = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect.");
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            if (!isValid)
            {
                Console.WriteLine("Card Blocked");
            }
            else
            {
                int choice = -1;
                while (choice != 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("The menu");
                    Console.WriteLine("1) Deposit");
                    Console.WriteLine("2) Withdraw");
                    Console.WriteLine("3) Check Balance");
                    Console.WriteLine("4) Exit");
                    Console.WriteLine("");
                    // ask user to select number from the menu
                    Console.Write("select number from the menu: ");
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the amount to Deposit: ");
                            try
                            {
                                double amount = double.Parse(Console.ReadLine());
                                if (amount < 0)
                                {
                                    Console.WriteLine("Amount cannot be negative.");
                                }
                                else
                                {
                                    balance += amount;
                                    Console.WriteLine("Deposit successful. Your balance is " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter the amount to Withdraw: ");
                            try
                            {
                                double amount = double.Parse(Console.ReadLine());
                                if (amount < 0)
                                {
                                    Console.WriteLine("Amount cannot be negative.");
                                }
                                else if (amount > balance)
                                {
                                    Console.WriteLine("You don't have this amount. your balance is " + balance + " OMR");
                                }
                                else
                                {
                                    balance -= amount;
                                    Console.WriteLine("Withdrawal successful. Your balance is " + balance + " OMR");
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a valid number.");
                            }
                            break;

                        case 3:
                            Console.WriteLine("Your balance is " + balance + " OMR");
                            break;

                        case 4:
                            Console.WriteLine("Thank you for using the ATM.");
                            break;

                        default:
                            Console.WriteLine("Invalid Number");
                            break;



                    }


                }
                }


        }


    }
}

