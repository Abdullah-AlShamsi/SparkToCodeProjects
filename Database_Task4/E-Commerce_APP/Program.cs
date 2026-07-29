using E_Commerce_APP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Linq;


namespace E_Commerce_APP
{
    internal class Program
    {
        // Shared DbContext - created ONCE, here, so every function below reuses
        // the exact same instance instead of each function opening its own.
        static ProjectContext context = new ProjectContext();
        // Shared login state - 0 means "nobody is logged in".
        // Set by Login(), read by any function that requires a logged-in user,
        // reset back to 0 by Logout().
        static int loggedInUserId = 0;

        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== E-Commerce Console App =====");
                Console.WriteLine(" 1. Register New User");
                Console.WriteLine(" 2. Login");
                Console.WriteLine(" 3. Add New Category");
                Console.WriteLine(" 4. Add New Product");
                Console.WriteLine(" 5. View All Products");
                Console.WriteLine(" 6. Place an Order");
                Console.WriteLine(" 7. View My Orders");
                Console.WriteLine(" 8. View Order Details");
                Console.WriteLine(" 9. Add a Review for an Order");
                Console.WriteLine("10. View All Reviews for a Product");
                Console.WriteLine("11. Logout");
                Console.WriteLine(" 0. Exit");
                Console.Write("Enter your choice: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }
                switch (choice)
                {
                    case 1: RegisterUser(); break;
                    case 2: Login(); break;
                    case 3: AddCategory(); break;
                    case 4: AddProduct(); break;
                    case 5: ViewAllProducts(); break;
                    case 6: PlaceOrder(); break;
                    case 7: ViewMyOrders(); break;
                    case 8: ViewOrderDetails(); break;
                    case 9: AddReview(); break;
                    case 10: ViewReviewsForProduct(); break;
                    case 11: Logout(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
        // ===================== FUNCTIONS =====================
        // Every function below talks to the console itself AND uses the
        // shared "context" field declared above - never create a new
        // AppDbContext() inside any of these functions.
        static void RegisterUser()
        {
            // TODO: implement (see Part 3 requirements)
            User user = new User();
            Console.Write("Enter user name: ");
            user.name = Console.ReadLine();
            Console.Write("Enter user email: ");
            user.email = Console.ReadLine();
            Console.Write("Enter user password: ");
            user.password = Console.ReadLine();

            context.users.Add(user);
            context.SaveChanges();
        }
        static void Login()
        {
            // TODO: implement - on success, set loggedInUserId = <found user's Id>
            Console.Write("Enter user email: ");
            string user_email = Console.ReadLine();
            Console.Write("Enter user password: ");
            string user_password = Console.ReadLine();

            User user = context.users.FirstOrDefault(u => u.email == user_email && u.password == user_password);
            if (user == null)
            {
                Console.WriteLine("Email or Password incorrect");
            }
            else
            {
                loggedInUserId = user.user_ID;
                Console.WriteLine("Welcome, " + user.name);
            }
        }
        static void AddCategory()
        {
            // TODO: implement
            Category category = new Category();
            Console.Write("Enter category name: ");
            category.name = Console.ReadLine();
           
            context.categories.Add(category);
            context.SaveChanges();
        }
        static void AddProduct()
        {
            // TODO: implement
            Product product = new Product();
            Console.Write("Enter Product name: ");
            product.name = Console.ReadLine();
            try
            {
                Console.Write("Enter Product price: ");
                double price = double.Parse(Console.ReadLine());
                if (price <= 0)
                {
                    Console.WriteLine("Price must be positive");
                    return;
                }
                product.price = price;

                Console.Write("Enter category ID: ");
                product.category_id = int.Parse(Console.ReadLine());

                if (!context.categories.Any(c => c.category_ID == product.category_id))
                {
                    Console.WriteLine("Category not found.");
                    return;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            context.products.Add(product);
            context.SaveChanges();

        }
        static void ViewAllProducts()
        {
            // TODO: implement
            Console.Write("If you want a specific category enter its name else enter 'N': ");
            string categoryName = Console.ReadLine();

            var query = context.products.Include(p => p.category).OrderBy(p => p.category_id).AsQueryable();
            if (categoryName != "N")
            {
                query = query.Where(p => p.category.name == categoryName);
            }
            var products = query.Select(p => $"Product name: {p.name} | Product price: {p.price} | product category {p.category.name}")
                    .ToList(); ;

            if(products.Count() == 0)
            {
                Console.WriteLine("No products found.");
                return;
            }

            foreach (string line in products)
            {
                Console.WriteLine(line);
            }
        }
        static void PlaceOrder()
        {
            // TODO: implement - check loggedInUserId != 0 first
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to place an order.");
                return;
            }

            Order order = new Order();
            order.user_id = loggedInUserId;
            order.date = DateTime.Now;
            context.orders.Add(order);
            context.SaveChanges();

            bool addedAny = false;
            bool addProduct = true;
            while (addProduct)
            {
                try
                {

                    Console.Write("Enter product ID (or 0 to finish): ");
                    int p_id = int.Parse(Console.ReadLine());

                    if (p_id == 0)
                    {
                        addProduct = false;
                        continue;
                    }
                    Console.Write("Enter quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity <= 0)
                    {
                        Console.WriteLine("Quantity must be positive.");
                        continue;
                    }

                    if (!context.products.Any(p => p.product_ID == p_id))
                    {
                        Console.WriteLine("Product not avilabile");
                    }
                    else
                    {

                        addedAny = true;
                        OrderProduct orderProduct = new OrderProduct();
                        orderProduct.product_id = p_id;
                        orderProduct.order_id = order.order_ID;
                        orderProduct.Quantity = quantity;
                        context.orderProducts.Add(orderProduct);

                        context.SaveChanges();

                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }
            }
            if (!addedAny)
            {
                context.orders.Remove(order);
                context.SaveChanges();
                Console.WriteLine("Order cancelled. no products were added.");
                return;
            }
        }
        static void ViewMyOrders()
        {
            // TODO: implement - check loggedInUserId != 0 first
            if (loggedInUserId == 0)
            {
                Console.WriteLine("You must be logged in to see orders.");
                return;
            }

        }
            foreach (string line in orders)
            {
                Console.WriteLine(line);
            }
        }
        static void ViewOrderDetails()
        {
            // TODO: implement
        }
                    else
                    {
                        Console.WriteLine("No review yet.");
                    }

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input.");

            }


        }
        static void AddReview()
        {
            // TODO: implement - check loggedInUserId != 0 first
        }
        static void ViewReviewsForProduct()
        {
            // TODO: implement
        }
        static void Logout()
        {
            // TODO: implement - reset loggedInUserId back to 0
        }
    }
}
