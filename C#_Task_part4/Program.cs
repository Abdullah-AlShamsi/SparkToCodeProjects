namespace C__Task_part4
{
    internal class Program
    {
        //task 1
        public static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }
        static void Main(string[] args)
        {

            // task 1
            // ask user to enter their name
            Console.WriteLine("Personalized Welcome Function");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintWelcome(name);
        }
    }
}
