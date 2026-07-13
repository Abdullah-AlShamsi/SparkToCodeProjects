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
                Console.WriteLine("Withdraw amount must be a positive number and must not exceed the account's balance.");
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
            Console.WriteLine("Operation successful, account balance now: " + Balance);
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
                Console.WriteLine("Not enough stock available.");
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
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Product Price: " + Price);
            Console.WriteLine("Product stock quantity: " + StockQuantity);
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
            BankAccount bankAccount1 = new BankAccount{ AccountNumber = 1163, HolderName = "karim" , Balance = 120 };
            BankAccount bankAccount2 = new BankAccount { AccountNumber = 15203, HolderName = "Ali", Balance = 63 };


            Student student1 = new Student { Name = "Ali", Address = "Muscat", Grade = 65 };
            Student student2 = new Student{ Name = "Ahmed" , Address = "Muscat" , Grade = 70 };

            Product product1 = new Product { ProductName = "Wireless Mouse" , Price = 5.500 , StockQuantity = 50 };
            Product product2 = new Product{ ProductName = "Mechanical Keyboard" , Price = 15.750 , StockQuantity = 20 };

            BankAccount ChooseBankAccount()
            {
                // ask user to Choose Bank Account
                while(true)
                {

                    Console.Write("Pick one of the two Bank Accounts, enter 1 or 2: ");
                    string chooses = Console.ReadLine();

                    if (chooses == "1")
                    {
                        return bankAccount1;
                    }
                    else if (chooses == "2") 
                    {
                        return bankAccount2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    }
                    
                }
            }

            Student ChooseStudent()
            {
                // ask user to Choose Student
                while (true)
                {

                    Console.Write("Pick one of the two students, enter 1 or 2: ");
                    string chooses = Console.ReadLine();

                    if (chooses == "1")
                    {
                        return student1;
                    }
                    else if (chooses == "2")
                    {
                        return student2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    }

                }
            }

            Product ChooseProduct()
            {
                // ask user to Choose Product
                while (true)
                {

                    Console.Write("Pick one of the two product, enter 1 or 2: ");
                    string chooses = Console.ReadLine();

                    if (chooses == "1")
                    {
                        return product1;
                    }
                    else if (chooses == "2")
                    {
                        return product2;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    }

                }
            }

            void ViewAccountDetails()
            {
                BankAccount chooses = ChooseBankAccount();
                chooses.CheckBalance();
            }

            void UpdateStudentAddress()
            {
                Student chooses = ChooseStudent();
                Console.Write("Enter new address: ");
                string address = Console.ReadLine();
                chooses.Address = address;

                Console.WriteLine("The Update Student Address Successful, The new address: " + chooses.Address);
            }

            void MakeDeposit()
            {
                BankAccount chooses = ChooseBankAccount();

                //ask user to enter deposit amount
                Console.Write("Enter deposit amount: ");
                try
                {
                    double amount = double.Parse(Console.ReadLine());
                    chooses.Deposit(amount);
                    chooses.CheckBalance();
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            void MakeWithdrawal()
            {
                BankAccount chooses = ChooseBankAccount();

                //ask user to enter withdraw amount
                Console.Write("Enter withdraw amount: ");
                try
                {
                    double amount = double.Parse(Console.ReadLine());
                    chooses.Withdraw(amount);
                    chooses.CheckBalance();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            void ViewProductDetails()
            {
                Product chooses = ChooseProduct();
                double total = chooses.GetInventoryValue();
                Console.WriteLine("Total Inventory Value: " + total);
            }
            void RegisterStudent()
            {
                Student chooses = ChooseStudent();

                //ask user to Enter email
                Console.Write("Enter email: ");
                string email = Console.ReadLine();
                chooses.Register(email);
                Console.WriteLine("Student registered successfully.");
            }
            void CompareAccountBalances()
            {
                double balance1 = bankAccount1.Balance;
                double balance2 = bankAccount2.Balance;

                if (balance1 > balance2)
                {
                    bankAccount1.CheckBalance();
                    Console.WriteLine("This account holds more money");
                }
                else if (balance1 < balance2)
                {
                    bankAccount2.CheckBalance();
                    Console.WriteLine("This account holds more money");
                }
                else
                {
                    Console.WriteLine("Both accounts hold same amount of money");
                }
            }

            void RestockProduct()
            {
                Product chooses = ChooseProduct();

                //ask user to enter a quantity to add
                Console.Write("Enter a quantity to add: ");
                try
                {
                    int quantity = int.Parse(Console.ReadLine());
                    chooses.Restock(quantity);

                    int stockQuantity = chooses.StockQuantity;

                    if (stockQuantity < 10)
                    {
                        Console.WriteLine("Stock level: Low");
                    }
                    else if (stockQuantity >= 50)
                    {
                        Console.WriteLine("Stock level: Well Stocked");
                    }
                    else
                    {
                        Console.WriteLine("Stock level: Moderate");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            void TransferBetweenAccounts()
            {
                // let user choose a source account
                Console.Write("Choose Source account, ");
                BankAccount sourceAccount = ChooseBankAccount();

                // let user choose a destination account
                Console.Write("Choose Destination account, ");
                BankAccount destinationAccount = ChooseBankAccount();

                //ask user to enter transfer amount
                Console.Write("Enter transfer amount: ");
                try
                {
                    double amount = double.Parse(Console.ReadLine());
                    
                    if (amount <= sourceAccount.Balance && amount>0)
                    {
                        Console.Write("Source account, ");
                        sourceAccount.Withdraw(amount);

                        Console.Write("Destination account, ");
                        destinationAccount.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("Transfer amount must be positive and must not exceed the source account's balance.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            void UpdateStudentGrade()
            {
                Student chooses = ChooseStudent();

                // ask user to enter a new grade
                Console.Write("Enter a new grade: ");

                try
                {
                    int grade = int.Parse(Console.ReadLine());

                    if (grade >= 0 && grade <= 100)
                    {
                        chooses.Grade = grade;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("The update rejected. Grade must be integer (0-100).");
                }
            }


                while (true)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    //            case 11: StudentReportCard(); break;
                    //            case 12: AccountHealthStatus(); break;
                    //            case 13: BulkSaleWithRevenue(); break;
                    //            case 14: ScholarshipEligibilityCheck(); break;
                    //            case 15: FullBalanceTopUpFlow(); break;
                    //            case 16: QuickAccountOpening(); break;
                    //            case 17: TotalStudentsCounter(); break;
                    //            case 18: OverdrawnAccountCheck(); break;
                    //            case 19: SetStudentSecurityPin(); break;
                    case 20:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }

                Console.WriteLine("Press any key to clear");
                Console.ReadKey();
                Console.Clear();

            }


        }
    }
}
