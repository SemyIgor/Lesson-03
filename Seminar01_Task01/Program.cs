// Check if the first number is a square of the second one
Console.WriteLine("Input number one: ");
string? firstString = Console.ReadLine();

Console.WriteLine("Input number two: ");
string? secondString = Console.ReadLine();

if((firstString != null) && (secondString != null))
{
   int firstNumber = int.Parse(firstString);
   int secondNumber = int.Parse(secondString);

   // if(firstNumber == (int)Math.Pow(secondNumber, 2))

   if(secondNumber == Math.Sqrt(firstNumber))
   {
      Console.WriteLine(firstNumber + " is a square of " + secondNumber);
   }
   else
   {
      Console.WriteLine(firstNumber + " is not a square of " + secondNumber);
   }
}
