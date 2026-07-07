namespace C__Task_part4
{
    internal class Program
    {
        //task 1
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        //task 2
        public static int Square(int num)
        {
            return num*num ;
        }

        //task 3
        public static double CelsiusToFahrenheit(double temperature)
        {
            return (temperature * 9 / 5) + 32;
        }

        //task 4
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1) Start");
            Console.WriteLine("2) Help");
            Console.WriteLine("3) Exit");
        }

        //task 5
        public static bool IsEven(int num)
        {
            if ((num%2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //task 6
        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        public static double CalculatePerimeter(double length, double width)
        {
            return 2*(length+ width);
        }

        //task 7
        public static string GetGradeLetter(int score)
        {
            if (score >= 90)
            {
                return "A";
            }
            else if (score >= 80)
            {
                return "B";
            }
            else if (score >= 70)
            {
                return "C";
            }
            else if (score >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }

        }


        //task 8 
        public static void Countdown(int start)
        {
            for (int i=start; i>0; i--)
            {
                Console.WriteLine(i);
            }
        }


        //task 9
        public static int Multiply(int a, int b)
        { 
            return a * b; 
        }
        public static double Multiply(double a, double b)
        { 
            return a * b;
        }
        public static int Multiply(int a, int b, int c)
        {
            return a * b * c; 
        }

        //task 10
        public static double CalculateArea(double length)
        {
            return length * length;
        }
        // keep it as comment because i did it in task 6
        //public static double CalculateArea(double length, double width) 
        //{
        //    return length * width;
        //}



        //task 11
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }
        public static double DivideNumbers(double a, double b)
        {
            try

            {
                if (b == 0)
                {
                    throw new DivideByZeroException();
                }
                return a / b; 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can not divide by zero");
                return 0;

            }
        }
        public static void DisplayResult(string o_name, double result)
        {
            Console.WriteLine("The operation name: " + o_name);
            Console.WriteLine("The result: " + result);
        }





        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /// task 1
            //// ask user to enter their name
            //Console.WriteLine("Personalized Welcome Function");
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //PrintWelcome(name);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 2
            //Console.WriteLine("Square Number Function");

            //// ask user to enter num
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //Console.WriteLine("Square of your number is: " + Square(num));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 3
            //Console.WriteLine("Celsius to Fahrenheit Function");

            //// ask user to enter temperature in celsius
            //Console.Write("Enter the temperature in celsius: ");
            //double temperature = double.Parse(Console.ReadLine());

            //Console.WriteLine("The temperature in Fahrenheit: " + CelsiusToFahrenheit(temperature));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //task 4
            //Console.WriteLine("Fixed Menu Display Function");
            //DisplayMenu();
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 5
            //Console.WriteLine("Even or Odd Function");

            //// ask user to enter num
            //Console.Write("Enter number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsEven(num))
            //{
            //    Console.WriteLine("Your number is even");
            //}
            //else
            //{
            //    Console.WriteLine("Your number is odd");
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 6
            //Console.WriteLine("Rectangle Area & Perimeter Functions");

            //// Ask the user for length and width
            //Console.Write("Enter length of rectangle: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Enter width of rectangle: ");
            //double width = double.Parse(Console.ReadLine());

            //Console.WriteLine("Rectangle Area: " + CalculateArea(length,width));

            //Console.WriteLine("Rectangle Perimeter: " + CalculatePerimeter(length, width));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 7
            //Console.WriteLine("Grade Letter Function");

            //// Ask the user for score
            //Console.Write("Enter your score: ");
            //int score = int.Parse(Console.ReadLine());

            //Console.WriteLine("Your Grade In Letter: " + GetGradeLetter(score));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 8
            //Console.WriteLine("Countdown Function");

            //// Ask the user for starting number
            //Console.Write("Enter starting number: ");
            //int start = int.Parse(Console.ReadLine());

            //Countdown(start);
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 9
            //Console.WriteLine("Overloaded Multiply Function");

            //Console.WriteLine("Multiply 1: 3X2 = " + Multiply(3,2));
            //Console.WriteLine("Multiply 2: 3.5X6.1 = " + Multiply(3.5, 6.1));
            //Console.WriteLine("Multiply 3: 4X6X9 = " + Multiply(4, 6, 9));
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 10
            //Console.WriteLine("Overloaded Area Calculator");

            //Console.Write("which shape you have (square or rectangle): ");
            //string shape = Console.ReadLine();

            //if(shape == "square")
            //{
            //    //Ask the user for length and width
            //    Console.Write("Enter length of one side of square: ");
            //    double length = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Square Area: " + CalculateArea(length));
            //}
            //else
            //{
            //    //Ask the user for length and width

            //    Console.Write("Enter length of rectangle: ");
            //    double length = double.Parse(Console.ReadLine());

            //    Console.Write("Enter width of rectangle: ");
            //    double width = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Rectangle Area: " + CalculateArea(length, width));
            //}
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///task 11
            Console.WriteLine("Function-Based Calculator");

            Console.WriteLine("1) Add");
            Console.WriteLine("2) Subtract");
            Console.WriteLine("3) Multiply");
            Console.WriteLine("4) Divide");
            Console.WriteLine("5) Exit");

            // ask user to choose an operation
            Console.Write("choose an operation (1-5): ");
            int o_num = int.Parse(Console.ReadLine());

            while (o_num != 5)
            {
                // ask user to enter num1
                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                // ask user to enter num2
                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());
                double result;
                switch (o_num)
                {
                    case 1:
                        result = Add(num1, num2);
                        DisplayResult("Add", result);
                        break;

                    case 2:
                        result = Subtract(num1, num2);
                        DisplayResult("Subtract", result);
                        break;

                    case 3:
                        result = MultiplyNumbers(num1, num2);
                        DisplayResult("Multiply", result);
                        break;

                    case 4:
                        result = DivideNumbers(num1, num2);
                        DisplayResult("Divide", result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");

                // ask user to choose an operation
                Console.Write("choose an operation (1-5): ");
                o_num = int.Parse(Console.ReadLine());

            }
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
    }
}
