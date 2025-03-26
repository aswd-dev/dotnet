

// Exercise 1

#region

Console.WriteLine("Enter the First number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Second number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the Operation (+, -, *, /): ");
char operation = Convert.ToChar(Console.ReadLine());

double result = 0;
bool validOperation = true;

switch (operation)
{
    case '+':
        result = num1 + num2;
        break;
    case '-':
        result = num1 - num2;
        break;
    case '*':
        result = num1 * num2;
        break;
    case '/':
        if (num2 != 0)
            result = num1 / num2;
        else
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            validOperation = false;
        }
        break;
    default:
        Console.WriteLine("Error: Invalid operation.");
        validOperation = false;
        break;
}

if (validOperation)
    Console.WriteLine($"The result is: {result}");

Console.ReadLine();
#endregion


// Exercise 2
