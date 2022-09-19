// Seminar02_Task16. Enter two numbers and check if one of them is a square of another

Console.Clear();
Console.Write("Enter first number: ");
string? firstStr = Console.ReadLine();
Console.Write("Enter second number: ");
string? secondStr = Console.ReadLine();

if((firstStr != null) && (secondStr != null))
{
   int firstNum = int.Parse(firstStr);
   int secondNum = int.Parse(secondStr);
   if(firstNum == secondNum * secondNum)
   {
      Console.WriteLine($"The first number {firstNum} is a square of the second number {secondNum}");
   }
   else if(secondNum == firstNum * firstNum)
   {
      Console.WriteLine($"The second number {secondNum} is a square of the first number {firstNum}");
   }
   else
   {
      Console.WriteLine("Entered numbers are not squares of one another");
   }
}

