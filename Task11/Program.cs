namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This Loan Eligibility System");

            // ask user to enter age
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            // ask user to monthly income
            Console.Write("Enter your monthly income: ");
            double monthly_income = double.Parse(Console.ReadLine());

            // ask user if has an existing loan
            Console.Write("Do you have an existing loan, answer(yes/no): ");
            string existing_loan = Console.ReadLine();

            bool isEligible = false;
            if (age >= 21 && age <= 60 && monthly_income >= 400 && existing_loan=="no") 
            {
                isEligible = true;
                Console.WriteLine("eligible to loan.");
            }
            else
            {
                Console.WriteLine("not eligible to loan.");
                if (!(age >= 21 && age <= 60))
                {
                    Console.WriteLine("age out of range");
                }
                if (!(monthly_income >= 400))
                {
                    Console.WriteLine("income too low");
                }
                if(!(existing_loan=="no"))
                {
                    Console.WriteLine("has an existing loan");
                }

            }
        }
    }
}
