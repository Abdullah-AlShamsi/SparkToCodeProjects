using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace C__Task_part3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 1
            //Console.WriteLine("Absolute Difference");

            //// ask user to enter num1
            //Console.Write("Enter first number: ");
            //int num1 = int.Parse(Console.ReadLine());

            //// ask user to enter num2
            //Console.Write("Enter second number: ");
            //int num2 = int.Parse(Console.ReadLine());

            //int sub_value = num1 - num2;

            //int abs_value = Math.Abs(sub_value);

            //Console.WriteLine("The absolute difference result of your numbers is " + abs_value);
            ////////////////////////////////////////////////////////////////////////////////////////////////



            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 2
            //Console.WriteLine("Power & Root Explorer");

            //// ask user to enter num1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //double pow_value = Math.Pow(number,2);

            //double sqrt_value = Math.Sqrt(number);

            //Console.WriteLine("The square result of your numbers is " + pow_value);
            //Console.WriteLine("The square root result of your numbers is " + sqrt_value);
            ////////////////////////////////////////////////////////////////////////////////////////////////
            ///

            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 3
            //Console.WriteLine("Name Formatter");

            //// ask user to enter their full name
            //Console.Write("Enter your full name: ");
            //string fullName = Console.ReadLine();

            //string uppercase_Name = fullName.ToUpper();
            //string lowercase_Name = fullName.ToLower();
            //int count = fullName.Length;

            //Console.WriteLine("Your full name in uppercase: " + uppercase_Name);
            //Console.WriteLine("Your full name in lowercase: " + lowercase_Name);
            //Console.WriteLine("There are " + count + " characters in your full name.");
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 4
            //Console.WriteLine("Subscription End Date");

            //// ask user to enter the number of days of a free trial
            //Console.Write("Enter the number of days of a free trial: ");
            //int number = int.Parse(Console.ReadLine());


            //DateTime startDay = DateTime.Today;

            //DateTime endDay = startDay.AddDays(number - 1);//number - 1 becuse we alredy count the first day startday

            //Console.WriteLine("The trial will ends in " + endDay.ToString("yyyy-MM-dd"));
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 5
            //Console.WriteLine("Grade Rounding System");

            //// ask user to enter their raw exam score as a decimal number
            //Console.Write("Enter raw exam score as a decimal number (e.g. 74.6): ");
            //double score = double.Parse(Console.ReadLine());

            //double round_score = Math.Round(score,0);

            //Console.WriteLine("Your rounded score is: " + round_score);
            //if (round_score>=60)
            //{
            //    Console.WriteLine("Congratulations, you passed the test!");
            //}
            //else
            //{
            //    Console.WriteLine("Unfortunately, you failed the test.");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////
            //// task 6
            //Console.WriteLine("Password Strength Checker");

            //// ask user to enter a password
            //Console.Write("Enter a password: ");
            //string password = Console.ReadLine();


            //if (password.Length < 8 || password.ToLower().Contains("password"))
            //{
            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Weak password, it must be at least 8 characters long");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Weak password, it must not contain the word password");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Strong password");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////// task 7
            //Console.WriteLine("Clean Name Comparator");

            //// ask user to enter the same name twice (once in each input)
            //Console.Write("Enter a name: ");
            //string name1 = Console.ReadLine();

            //Console.Write("Enter the name again: ");
            //string name2 = Console.ReadLine();

            //name1 = name1.Trim();
            //name2 = name2.Trim();

            //name1 = name1.ToLower();
            //name2 = name2.ToLower();


            //if (name1 == name2)
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("NO Match");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////// task 8
            //Console.WriteLine("Membership Expiry Checker");

            //// ask user to enter their membership start date as text and the number of valid membership days
            //Console.Write("Enter your membership start date as text (e.g.'2026-01-10'): ");
            //DateTime start_day = DateTime.Parse(Console.ReadLine());

            //// ask user to enter the number of valid membership days
            //Console.Write("Enter the number of valid membership days: ");
            //int number = int.Parse(Console.ReadLine());

            //DateTime expiry_day = start_day.AddDays(number);

            //if (DateTime.Today > expiry_day)
            //{
            //    Console.WriteLine("Expired, the expiry date " + expiry_day.ToString("yyyy-MM-dd"));
            //}
            //else
            //{
            //    Console.WriteLine("Active, the expiry date " + expiry_day.ToString("yyyy-MM-dd"));
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////// task 9
            //Console.WriteLine("Round Up / Round Down Explorer");

            //// ask user to enter a decimal number
            //Console.Write("Enter a decimal number: ");
            //double num = double.Parse(Console.ReadLine());

            //double whole_num = Math.Round(num, 0);

            //double roundUp_num = Math.Ceiling(num);
            //double roundDown_num = Math.Floor(num);


            //Console.WriteLine("The nearest whole number: " + whole_num);

            //Console.WriteLine("The rounded up number: " + roundUp_num);
            //Console.WriteLine("The rounded down number: " + roundDown_num);
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////// task 10
            //Console.WriteLine("Word Position Finder");

            //// ask user to enter a full sentence and then a single word to search for
            //Console.Write("Enter a full sentence: ");
            //string sentence = Console.ReadLine();

            //Console.Write("Enter a single word to search for: ");
            //string word = Console.ReadLine();

            //sentence = sentence.ToLower();
            //word = word.ToLower();
            //if (sentence.Contains(word))
            //{
            //    int first_indx = sentence.IndexOf(word);
            //    int last_indx = sentence.LastIndexOf(word);

            //    Console.WriteLine("The first-occurrence position: " + first_indx);
            //    Console.WriteLine("The last-occurrence position: " + last_indx);
            //}
            //else
            //{
            //    Console.WriteLine("Word not found");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////
            ////// task 11
            //Console.WriteLine("One-Time Password (OTP) Generator");
            //Random random = new Random();

            //int rund_otp = random.Next(1000, 10000);
            

            //Console.WriteLine("Do not share this number with anyone, otp: " + rund_otp);
            //bool isValid = false;

            //for (int i = 0; i < 3; i++)
            //{
            //    // ask the user to type the code back to verify it.
            //    Console.Write("Enter the OTP: ");
            //    try
            //    {
            //        int inOTP = int.Parse(Console.ReadLine());
            //        if (inOTP == rund_otp)
            //        {
            //            isValid = true;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect.");
            //        }
            //    }
            //    catch (FormatException ex)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid number.");
            //    }
            //}
            //if (isValid)
            //{
            //    Console.WriteLine("Verified");
            //}
            //else
            //{
            //    Console.WriteLine("Verification Failed"); 
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////

            }
    }
}
