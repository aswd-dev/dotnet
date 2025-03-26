using System;
using System.Collections.Generic;

class Customer
{
    public string CardNumber { get; set; }
    public int Pin { get; set; }
    public string FullName { get; set; }
    public decimal Balance { get; set; }
}

class Program
{
    static List<Customer> customers = new List<Customer>
    {
        new Customer { CardNumber = "123456789", Pin = 1234, FullName = "John Doe", Balance = 1000.50m },
        new Customer { CardNumber = "987654321", Pin = 5678, FullName = "Jane Smith", Balance = 2500.75m },
        new Customer { CardNumber = "555555555", Pin = 4321, FullName = "Alice Johnson", Balance = 500.25m }
    };

    static void Main()
    {
        Console.WriteLine("Welcome to the ATM!");
        Console.Write("Enter your card number: ");
        string cardNumber = Console.ReadLine();

        Customer customer = customers.Find(c => c.CardNumber == cardNumber);
        if (customer == null)
        {
            Console.WriteLine("Invalid card number.");
            return;
        }

        Console.Write("Enter your PIN: ");
        if (!int.TryParse(Console.ReadLine(), out int pin) || customer.Pin != pin)
        {
            Console.WriteLine("Invalid PIN.");
            return;
        }

        Console.WriteLine($"\nWelcome, {customer.FullName}!");

        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Withdraw Cash");
            Console.WriteLine("3. Deposit Cash");
            Console.WriteLine("4. Exit");
            Console.Write("Choice: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Your current balance is: ${customer.Balance}");
                    break;
                case "2":
                    WithdrawCash(customer);
                    break;
                case "3":
                    DepositCash(customer);
                    break;
                case "4":
                    Console.WriteLine("Thank you for using our ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void WithdrawCash(Customer customer)
    {
        Console.Write("Enter amount to withdraw: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (amount > customer.Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            customer.Balance -= amount;
            Console.WriteLine($"Withdrawal successful! You withdrew ${amount}. Your new balance is: ${customer.Balance}");
        }
    }

    static void DepositCash(Customer customer)
    {
        Console.Write("Enter amount to deposit: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        customer.Balance += amount;
        Console.WriteLine($"Deposit successful! Your new balance is: ${customer.Balance}");
    }
}
