// Lesson-03_Seminar04_Task30. Outputting random generated 8-digit array of 0 and 1 -s
// For more visualization I made it generate 8-digit array 10 times

Console.Clear();
System.Random numberSintezator = new Random();

void VariantNaive()
{
   for (int j = 0; j < 10; j++)
   {
      Console.Write("[");
      for (int i = 0; i < 7; i++)
      {
         Console.Write(numberSintezator.Next(0, 2) + ", ");
      }
      Console.Write(numberSintezator.Next(0, 2) + "]\n");
   }
}

void VariantFormat()
{
   for (int j = 0; j < 10; j++) // Outputing ten 8-digit numbers
   {
      long number = 0;
      for (int i = 0; i < 8; i++)
      {
         number = number + numberSintezator.Next(0, 2) * (long)Math.Pow(10, 7 - i); // Forming 8-digit number
      }
      Console.WriteLine(number.ToString("[0\\, 0\\, 0\\, 0\\, 0\\, 0\\, 0\\, 0]")); // Formatting line
   }
}

Console.WriteLine("VariantNaive");
VariantNaive();
Console.WriteLine();

Console.WriteLine("VariantFormat");
VariantFormat();
Console.WriteLine();
