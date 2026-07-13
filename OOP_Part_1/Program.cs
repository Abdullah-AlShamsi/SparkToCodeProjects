namespace OOP_Part_1
{
    class BankAccount
    {
        public int AccountNumber {get; set;}
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Deposit amount must be a positive number.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Withdraw amount must be a positive number.");
            }
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Account Holder Name: " + HolderName);
            Console.WriteLine("Account balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Operation successful, account balance now:" + Balance);
        }

    }

    class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email;
        int age;


        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Operation successful");
        }
    }

    class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public void Sell(int quantity)
        {
            if (quantity <= StockQuantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();

            return Price*StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name:" + ProductName);
            Console.WriteLine("Product Price:" + Price);
            Console.WriteLine("Product stock quantity:" + StockQuantity);
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction Logged");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
