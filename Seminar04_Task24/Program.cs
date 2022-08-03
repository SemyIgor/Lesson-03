// Lesson-03. Seminar04_Task24. Find sum of all natural numbers from 1 to N
Console.Clear();
int t; // ticks of the clock gentrator

string inputString()
{
   Console.Write("Введите любое натуральное число: ");
   string? stringNumber = Console.ReadLine();
   return stringNumber;
}

// Iteration cycling to add up indexes from 1 to A
void VariantSimple(double num)
{
   double sum = 0;
   for (int i = 1; i <= num; i++)
   {
      sum += i;
   }
   Console.WriteLine("VariantSimple");
   Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
   // Console.WriteLine("");
}

// Gauss method (A*(A+1)) /2
void VariantGauss(double num)
{
   double sum = (num * (num + 1)) / 2;
   Console.WriteLine("VariantGauss");
   Console.WriteLine($"Сумма чисел от 1 до {num} равна {sum}");
   // Console.WriteLine("");
}

string inpString = inputString();
if (inpString != null)
{
   double number = double.Parse(inpString);

   t = Environment.TickCount; // getting tick count
   VariantSimple(number);
   Console.WriteLine("Simple time = {0} ms", Environment.TickCount - t);
   Console.WriteLine();

   t = Environment.TickCount; // getting tick count
   VariantGauss(number);
   Console.WriteLine("Gauss time = {0} ms", Environment.TickCount - t);
   Console.WriteLine();
}
