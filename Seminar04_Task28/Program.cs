// Lesson-03_Seminar04_Task28. Entering natural number N and outputting multiplied numbers from 1 to N

Console.Clear();
DateTime timeSharp; // System time

string inputString() // Enter string of digits
{
   Console.Write("Введите любое натуральное число: ");
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

void VariantCycle(long inpNumber)
{
   long factorial = 1;
   checked
   {
      for (int i = 1; i <= inpNumber; i++)
      {
         factorial *= i;
      }
   }
   Console.WriteLine("Произведение чисел от 1 до {0:N0} равно {1:N0}", inpNumber, factorial);
}

long VariantRecurs(long inpNumber)
{
   if (inpNumber <= 1) return inpNumber;
   return inpNumber * VariantRecurs(inpNumber - 1);
}

long VariantRecursDouble(long inpNumber)
{
   if (inpNumber <= 1) return inpNumber;
   return inpNumber * (inpNumber - 1) * VariantRecurs(inpNumber - 2);
}

try
{
   long inputNumber = long.Parse(inputString());

   Console.WriteLine("Variant Cycle");
   timeSharp = DateTime.Now;
   VariantCycle(inputNumber);
   Console.WriteLine("Cycle time = {0} ms", DateTime.Now - timeSharp);

   Console.WriteLine();

   Console.WriteLine("Variant Recurs");
   timeSharp = DateTime.Now;
   Console.WriteLine("Произведение чисел от 1 до {0:N0} равно {1:N0}", inputNumber, VariantRecurs(inputNumber));
   Console.WriteLine("Recurs time = {0} ms", DateTime.Now - timeSharp);

   Console.WriteLine();

   Console.WriteLine("Variant RecursDouble");
   timeSharp = DateTime.Now;
   Console.WriteLine("Произведение чисел от 1 до {0:N0} равно {1:N0}", inputNumber, VariantRecursDouble(inputNumber));
   Console.WriteLine("Cycle time = {0} ms", DateTime.Now - timeSharp);

   Console.WriteLine();
}
catch
{
   Console.WriteLine("Exception occured ! I can't multiply this numbers.");
}
finally
{
   Console.WriteLine();
}


