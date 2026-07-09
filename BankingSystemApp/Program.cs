using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Xml.Linq;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Close an Account");
                Console.WriteLine("7. Find the Richest Customer");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        CloseAccount();
                        break;
                    case 7:
                        FindtheRichestCustomer();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter customer's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a new account number: ");
            string num = Console.ReadLine();
            if (accountNumbers.Contains(num))
            {
                Console.WriteLine("This account number is already used.");
                return;
            }

            Console.Write("Enter an initial deposit amount to open the account: ");
            double starting_balance = double.Parse(Console.ReadLine());
            
            if (starting_balance < 0)
            {
                Console.WriteLine("Initial deposit amount must not be negative.");
                return;
            }

            customerNames.Add(name);
            accountNumbers.Add(num);
            balances.Add(starting_balance);
            Console.WriteLine("customer's account has been successfully registered.");
            Console.WriteLine("Customer's name: " + name);
            Console.WriteLine("Account number: " + num);
            Console.WriteLine("Account balance: " + starting_balance);


        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter customer's account number: ");
            string num = Console.ReadLine();

            int index = accountNumbers.IndexOf(num);

            if (index == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.Write("Enter the deposit amount: ");
            double deposit = double.Parse(Console.ReadLine());

            if (deposit < 0)
            {
                Console.WriteLine("Deposit amount must not be negative.");
                return;
            }
            balances[index] += deposit;
            Console.WriteLine("Account balance: " + balances[index]);
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter customer's account number: ");
            string num = Console.ReadLine();

            int index = accountNumbers.IndexOf(num);

            if (index == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.Write("Enter the withdrawal amount: ");
            double withdrawal = double.Parse(Console.ReadLine());

            if (withdrawal < 0)
            {
                Console.WriteLine("Withdrawal amount must not be negative.");
                return;
            }
            if(withdrawal> balances[index])
            {
                Console.WriteLine("Withdrawal amount exceed the balance.");
                return;
            }
            balances[index] -= withdrawal;
            Console.WriteLine("Account balance: " + balances[index]);
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter your account number: ");
            string num = Console.ReadLine();

            int index = accountNumbers.IndexOf(num);

            if (index == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.WriteLine("Customer's name: " + customerNames[index]);
            Console.WriteLine("Account number: " + accountNumbers[index]);
            Console.WriteLine("Account balance: " + balances[index]);

        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter sender's account number: ");
            string num_sender = Console.ReadLine();

            int index_sender = accountNumbers.IndexOf(num_sender);

            if (index_sender == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.Write("Enter sender's account number: ");
            string num_receiver = Console.ReadLine();

            int index_receiver = accountNumbers.IndexOf(num_receiver);

            if (index_receiver == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.Write("Enter the transfer amount: ");
            double transfer = double.Parse(Console.ReadLine());

            if (transfer < 0)
            {
                Console.WriteLine("Transfer amount must not be negative.");
                return;
            }
            if (transfer > balances[index_sender])
            {
                Console.WriteLine("Transfer amount exceed sender's balance.");
                return;
            }
            balances[index_sender] -= transfer;
            Console.WriteLine("Account balance: " + balances[index_sender]);

            balances[index_receiver] += transfer;
            Console.WriteLine("Account balance: " + balances[index_receiver]);

            Console.WriteLine("Sender's name: " + customerNames[index_sender]);
            Console.WriteLine("Sender's Account number: " + accountNumbers[index_sender]);
            Console.WriteLine("Sender's Account balance: " + balances[index_sender]);
            Console.WriteLine();
            Console.WriteLine("Receiver's name: " + customerNames[index_receiver]);
            Console.WriteLine("Receiver's Account number: " + accountNumbers[index_receiver]);
            Console.WriteLine("Receiver's Account balance: " + balances[index_receiver]);

        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        static void CloseAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.Write("Enter account number: ");
            string num = Console.ReadLine();

            int index = accountNumbers.IndexOf(num);

            if (index == -1)
            {
                Console.WriteLine("This account number is not found.");
                return;
            }

            Console.WriteLine("Customer's name: " + customerNames[index]);
            Console.WriteLine("Account number: " + accountNumbers[index]);
            Console.WriteLine("Account balance: " + balances[index]);

            customerNames.RemoveAt(index);
            accountNumbers.RemoveAt(index);
            balances.RemoveAt(index);
            Console.WriteLine("customer's account has been successfully closed.");
        }
    }
}