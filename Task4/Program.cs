namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program Check Voting Eligibility");

            // ask user to enter age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // ask user if has valid national ID
            Console.Write("Do you have a valid national ID, answer(yes/no): ");
            string valid_national_ID = Console.ReadLine();

            bool isValid = false;

            if (valid_national_ID=="yes")
            {
                isValid = true;
            }

            bool isEligible = false;
            if (age >= 18 && isValid)
            {
                isEligible = true;
                Console.WriteLine("person is eligible to vote.");
            }
            else
            {
                Console.WriteLine("person is not eligible to vote.");
            }


            
        }
    }
}
