using System;
using System.Collections.Generic;

class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Messages { get; set; }
}

class Program
{
    static List<User> users = new List<User>
    {
        new User { Id = 1, Username = "Alice", Password = "pass123", Messages = new string[] { "Hello Alice!", "Meeting at 3 PM" } },
        new User { Id = 2, Username = "Bob", Password = "secure456", Messages = new string[] { "Hey Bob, check your email." } },
        new User { Id = 3, Username = "Charlie", Password = "mypassword", Messages = new string[] { "Your package has arrived.", "Call John back." } }
    };

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Log in");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Login();
                    break;
                case "2":
                    Register();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }

    static void Login()
    {
        Console.WriteLine("\nWelcome! Please log in.");
        Console.Write("Username: ");
        string inputUsername = Console.ReadLine();
        Console.Write("Password: ");
        string inputPassword = Console.ReadLine();

        User loggedInUser = users.Find(user => user.Username == inputUsername && user.Password == inputPassword);

        if (loggedInUser != null)
        {
            Console.WriteLine($"\nWelcome {loggedInUser.Username}. Here are your messages: Muhamed Loves You <3");
            foreach (string message in loggedInUser.Messages)
            {
                Console.WriteLine(message);
            }
        }
        else
        {
            Console.WriteLine("\nError: Invalid username or password.");
        }
    }

    static void Register()
    {
        Console.WriteLine("\nRegister a new user");
        Console.Write("Enter ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();
        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        if (users.Exists(user => user.Username == username))
        {
            Console.WriteLine($"\nError: A user with the username '{username}' already exists.");
            return;
        }

        users.Add(new User { Id = id, Username = username, Password = password, Messages = new string[] { } });

        Console.WriteLine("\nRegistration complete! Users:");
        foreach (var user in users)
        {
            Console.WriteLine($"{user.Id} {user.Username}");
        }
    }
}
