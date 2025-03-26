
        Console.WriteLine("Please enter a whole number:");
        bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);

        Console.WriteLine("Please enter a decimal number:");
        bool userDecimal1 = double.TryParse(Console.ReadLine(), out double parsedDoubleNum);

        Console.WriteLine("Please enter a boolean value (true/false):");
        bool userBoolInput1 = bool.TryParse(Console.ReadLine(), out bool parsedBoolValue);

        // Display parse results (true/false)
        Console.WriteLine($"Integer parsed successfully: {userInput1}");
        Console.WriteLine($"Decimal parsed successfully: {userDecimal1}");
        Console.WriteLine($"Boolean parsed successfully: {userBoolInput1}");

#region if/else

if (userInput1)
{
    Console.WriteLine($"The user entered: {parsedNumber}");
}

else
{
    Console.WriteLine("Invalid integer input! Please try again.");
}
if (userDecimal1)
{
    Console.WriteLine($"The user entered decimal: {parsedDoubleNum}");
}
else
{
    Console.WriteLine("Invalid decimal input! Please try again.");
}
if (userBoolInput1)
{
    Console.WriteLine(parsedBoolValue ? "Yeey! You got a true result!" : "Woop! You got false as a result!");
}
else
{
    Console.WriteLine("Invalid boolean input! Please try again.");
}

#endregion
 


#region Switch statement
//string day = "Wednesday";
Console.WriteLine("Please enter a day of the week, and I will tell you if you have lecture!");
string dayOfTheWeek = Console.ReadLine().ToLower();

switch (dayOfTheWeek)
{
    case "monday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "tuesday":
        Console.WriteLine("Today I have lecture!");
        break;
    case "wednesday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "thursday":
        Console.WriteLine("Today I have lecture!");
        break;
    case "friday":
        Console.WriteLine("I don't have any lectures today!");
        break;
    case "saturday":
    case "sunday":
        Console.WriteLine("Yeey! Weekend!");
        break;
    default:
        Console.WriteLine("No such day of the week!");
        break;
}



#endregion


Console.ReadLine();