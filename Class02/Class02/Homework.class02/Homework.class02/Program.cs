
#region
   
        Console.WriteLine("====== Exercise 5 ======");        

        int branchesPerTree = 12;
        int applesPerBranch = 8;
        int applesPerBasket = 5;

        
        int totalBaskets = branchesPerTree * applesPerBranch / applesPerBasket;

       
        Console.WriteLine($"Total baskets needed: {totalBaskets}");

#endregion


#region

Console.WriteLine("====== Exercise 6 ======");


int num1 = 20;
int num2 = 25;

int largerNumber;
if (num1 > num2)
{
    largerNumber = num1;
}
else
{
    largerNumber = num2;
}

Console.WriteLine($"The larger number from the two is {largerNumber}");

if (largerNumber % 2 == 0)
{
    Console.WriteLine("And the number is even");
}
else
{
    Console.WriteLine("And the number is odd");
}

#endregion


#region

Console.WriteLine("====== Exercise 7 ======");

Console.WriteLine("Enter a number from 1 to 3:");
string input = Console.ReadLine();

switch (input)
{
    case "1":
        Console.WriteLine("You got a new car!");
        break;
    case "2":
        Console.WriteLine("You got a new plane!");
        break;
    case "3":
        Console.WriteLine("You got a new bike!");
        break;
    default:
        Console.WriteLine("Error: Please enter a number between 1 and 3.");
        break;
}

#endregion

Console.ReadLine();
