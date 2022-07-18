// Seminar02_Task12. Check if the entered number is the multiple of another entered number
Console.Clear();
Console.Write("Enter the first number: ");
string? firstStr = Console.ReadLine();
Console.Write("Enter the second number: ");
string? secondStr = Console.ReadLine();

void areTheMultiples(int first, int second) // Variant I
{
   Console.WriteLine("Variant I");
   int devision = first % second;
   if(devision == 0) // Check if the first number is the multiple of the second one
   {
      Console.WriteLine($"Number {first} is the multiple of {second}");
   }
   // else if(second % first == 0) // Check if the second number is the multiple of the first one
   // {
   //    Console.WriteLine($"Number {second} is the multiple of {first}");
   // }
   else
   {
      Console.WriteLine($"Number {first} is not the multiple of {second}");
      Console.WriteLine($"The remainder of the division is {devision}");
   }
}

void firstVsSecond(int first, int second) // Variant II
{
   Console.WriteLine("Variant II");
   int devision = first % second;
   string outMessage = devision == 0 ? $"Число {first} кратно {second}" : $"Число {first} не кратно {second}, остаток {devision}";
   Console.WriteLine(outMessage);
}

if(firstStr != null && secondStr != null)
{
   int firstNum = int.Parse(firstStr);
   int secondNum = int.Parse(secondStr);

   areTheMultiples(firstNum, secondNum); // Variant I

   firstVsSecond(firstNum, secondNum); // Variant II
}
