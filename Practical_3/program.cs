using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExpenseTracker
{
    class Expense
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Amount { get; set; }

        public Expense(string name, string category, decimal amount)
        {
            Name = name;
            Category = category;
            Amount = amount;
        }
    }

    class Program
    {
        static List<Expense> expenses = new List<Expense>();

        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                try
                {
                    DisplayMenu();
                    Console.Write("Enter Choice: ");
                    string choiceInput = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(choiceInput))
                    {
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.\n");
                        continue;
                    }

                    if (!int.TryParse(choiceInput.Trim(), out int choice))
                    {
                        Console.WriteLine("Invalid choice. Please enter a valid number.\n");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            AddExpense();
                            break;
                        case 2:
                            ViewExpenses();
                            break;
                        case 3:
                            ShowTotalExpense();
                            break;
                        case 4:
                            Console.WriteLine("Exiting Expense Tracker. Goodbye!");
                            running = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.\n");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An unexpected error occurred: {ex.Message}\n");
                }
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("===== Expense Tracker =====");
            Console.WriteLine("1. Add Expense");
            Console.WriteLine("2. View Expenses");
            Console.WriteLine("3. Total Expense");
            Console.WriteLine("4. Exit");
        }

        static void AddExpense()
        {
            try
            {
                Console.Write("Enter Name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Name cannot be empty. Expense not added.\n");
                    return;
                }

                Console.Write("Enter Category: ");
                string category = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("Category cannot be empty. Expense not added.\n");
                    return;
                }

                Console.Write("Enter Amount: ");
                string amountInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(amountInput))
                {
                    Console.WriteLine("Amount cannot be empty. Expense not added.\n");
                    return;
                }

                // Remove $ or commas if user types them
                amountInput = amountInput.Replace("$", "").Replace(",", "").Trim();

                if (!decimal.TryParse(amountInput, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal amount))
                {
                    Console.WriteLine("Invalid amount. Please enter a valid number. Expense not added.\n");
                    return;
                }

                if (amount < 0)
                {
                    Console.WriteLine("Amount cannot be negative. Expense not added.\n");
                    return;
                }

                expenses.Add(new Expense(name.Trim(), category.Trim(), amount));
                Console.WriteLine("Expense Added Successfully!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while adding expense: {ex.Message}\n");
            }
        }

        static void ViewExpenses()
        {
            try
            {
                if (expenses.Count == 0)
                {
                    Console.WriteLine("No expenses recorded yet.\n");
                    return;
                }

                foreach (var expense in expenses)
                {
                    Console.WriteLine($"Name: {expense.Name}");
                    Console.WriteLine($"Category: {expense.Category}");
                    Console.WriteLine($"Amount: ${expense.Amount}");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while viewing expenses: {ex.Message}\n");
            }
        }

        static void ShowTotalExpense()
        {
            try
            {
                decimal total = 0;
                foreach (var expense in expenses)
                {
                    total += expense.Amount;
                }

                Console.WriteLine($"Total Expense = ${total}\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while calculating total: {ex.Message}\n");
            }
        }
    }
}
