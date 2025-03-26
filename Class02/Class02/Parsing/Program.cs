
string fullName = Console.ReadLine();

Console.WriteLine(fullName);

Console.WriteLine("===== data Conversion =====");

// Parse 

#region Parse

int userNumber = int.Parse(Console.ReadLine());
double userDecimalNumber = double.Parse(Console.ReadLine());
bool input = bool.Parse(Console.ReadLine());

Console.WriteLine(userNumber);
Console.WriteLine(userDecimalNumber);
Console.WriteLine(input);



#endregion


#region Convert.To ...()

int userInput = Convert.ToInt32(Console.ReadLine());
double userDecimal = Convert.ToDouble(Console.ReadLine());
bool userBoolInput = Convert.ToBoolean(Console.ReadLine());


Console.WriteLine(userInput);
Console.WriteLine(userDecimal);
Console.WriteLine(userBoolInput);




#endregion


#region TryParse ()

bool userInput1 = int.TryParse(Console.ReadLine(), out int parsedNumber);
bool userInput2 = double.TryParse(Console.ReadLine(), out double parseddoubleNum);
bool userInput3 = bool.TryParse(Console.ReadLine(), out bool parsedboolValue);

Console.WriteLine(userInput1);
Console.WriteLine(userInput2);
Console.WriteLine(userInput3);

#endregion