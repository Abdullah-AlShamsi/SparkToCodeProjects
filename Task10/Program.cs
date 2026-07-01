namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program calculate the area and perimeter of rectangle");

            // ask user to enter num1
            Console.Write("Enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // ask user to enter operator
            Console.Write("Enter operator (+, -, *, /, or %): ");
            string operator_cher = Console.ReadLine();

            // ask user to enter num2
            Console.Write("Enter second number: ");
            double num2 = double.Parse(Console.ReadLine());
            double result;
            switch (operator_cher)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine(num1 + operator_cher + num2 + "=" + result );
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine(num1 + operator_cher + num2 + "=" + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine(num1 + operator_cher + num2 + "=" + result);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        break;
                    }
                    result = num1 / num2;
                    Console.WriteLine(num1 + operator_cher + num2 + "=" + result);
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        break;
                    }
                    result = num1 % num2;
                    Console.WriteLine(num1 + operator_cher + num2 + "=" + result);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

        }
    }
}
