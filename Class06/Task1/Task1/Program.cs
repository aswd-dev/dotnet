class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        if (double.TryParse(Console.ReadLine(), out double number))
        {
            NumberStats(number);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }

    static void NumberStats(double number)
    {
        Console.WriteLine($"Stats for number: {number}");

        // positive or negative

        if (number > 0)
            Console.WriteLine("Positive");
        else if (number < 0)
            Console.WriteLine("Negative");
        else
            Console.WriteLine("Zero");

        // integer or decimal

        if (number % 1 == 0)
            Console.WriteLine("Integer");
        else
            Console.WriteLine("Decimal");

        // odd or even

        if (number % 1 == 0)
        {
            if (((int)number) % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }
}
