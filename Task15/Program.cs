namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This University Admission Decision");

            // ask user to enter the program type
            Console.Write("Enter the program type ('S' for Science, 'A' for Arts): ");
            string program_type = Console.ReadLine();

            // ask user to enter the applicant's GPA (out of 4.0)
            Console.Write("Enter the applicant's GPA (out of 4.0): ");
            double GPA = double.Parse(Console.ReadLine());

            // ask user enter their entrance exam score (out of 100)
            Console.Write("Enter their entrance exam score (out of 100): ");
            double score = double.Parse(Console.ReadLine());

            // ask user if they have an extracurricular achievement.
            Console.Write("Do you have an extracurricular achievement, answer(yes/no): ");
            string has_extracurricular = Console.ReadLine();

            switch (program_type)
            {
                case "S":
                    if (GPA >= 3.0 && score >= 75)
                    {
                        Console.WriteLine("The applicant is Admitted");
                    }
                    else if (has_extracurricular == "yes")
                    {
                        Console.WriteLine("The applicant is Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("The applicant is Not Admitted");
                    }
                    break;

                case "A":
                    if (GPA >= 2.5 && score >= 60)
                    {
                        Console.WriteLine("The applicant is Admitted");
                    }
                    else if (has_extracurricular == "yes")
                    {
                        Console.WriteLine("The applicant is Conditionally Admitted");
                    }
                    else
                    {
                        Console.WriteLine("The applicant is Not Admitted");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid program type");
                    break;
            }
        }
    }
}
