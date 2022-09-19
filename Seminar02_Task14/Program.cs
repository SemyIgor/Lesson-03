// Seminar02_Task14. Find the common multiple for two numbers

Console.Clear();
int firstNum = 7, secondNum = 23;

Console.Write("Enter any whole number: ");
string? anyString = Console.ReadLine();
if(anyString != null)
{
int anyNumber = int.Parse(anyString);

string VariantI(int first, int second) // Variant I (Ternary operator)
{
   string outputMsg = ((anyNumber%first == 0)&&(anyNumber%second == 0)) ?
   $"Number {anyNumber} is a common multiple for the numbers {first} and {second}" :
   $"Number {anyNumber} is not a common multiple for the numbers {first} and {second}";
   return outputMsg;
}

string VariantII(int first, int second) // Variant II (Using switch...case)
{
   string outputMsg;
   switch((anyNumber%first == 0)&&(anyNumber%second == 0))
   {
      case true: 
      outputMsg = $"Число {anyNumber} является общим кратным для чисел {first} и {second}";
      break;
      case false:
      outputMsg = $"Число {anyNumber} не является общим кратным для чисел {first} и {second}";
      break;
   }
   return outputMsg;
}

Console.WriteLine("Variant I"); 
Console.WriteLine(VariantI(firstNum, secondNum)); // Variant I

Console.WriteLine("Variant II"); 
Console.WriteLine(VariantII(firstNum, secondNum)); // Variant II
}


