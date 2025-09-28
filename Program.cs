Console.WriteLine("Type the first number, press Enter to confirm");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type the second number, press Enter to confirm");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int result = firstNumber + secondNumber;
Console.WriteLine("The addition of {0} and {1} is {2}", firstNumber, secondNumber, result);
Console.ReadKey();