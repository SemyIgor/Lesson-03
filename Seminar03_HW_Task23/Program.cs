// Seminar03_Task23. Input integer number and print this number and it's power 3

Console.Clear();
Console.Write("Введите целое число: ");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
   int number = int.Parse(numberStr);

   string[,] numberLine = new string[(number / 15) + 1, 15];
   string[,] powerThreeLine = new string[number / 15 + 1, 15];

   int n = number / 15;
   int i = 0;
   string oneString = String.Empty;
   string onePower = String.Empty;
   while (i < n)
   {
      oneString = "|";
      onePower = "|";
      for (int j = 0; j < 15; j++)
      {
         numberLine[i, j] = (i * 15 + j + 1).ToString();
         powerThreeLine[i, j] = Math.Pow(Convert.ToInt32(numberLine[i, j]), 3).ToString();
         oneString = oneString + numberLine[i, j] + "\t|";
         onePower = onePower + powerThreeLine[i, j] + "\t|";
      }

      Console.WriteLine(new string('-', 8 * 15));
      Console.WriteLine(oneString);
      Console.WriteLine(new string('-', 8 * 15));
      Console.WriteLine(onePower);
      Console.WriteLine(new string('-', 8 * 15));
      i++;
   }

   oneString = "|";
   onePower = "|";
   for (int j = 0; j < (number % 15); j++)
   {
      numberLine[i, j] = (i * 15 + j + 1).ToString();
      powerThreeLine[i, j] = Math.Pow(Convert.ToInt32(numberLine[i, j]), 3).ToString();
      oneString = oneString + numberLine[i, j] + "\t|";
      onePower = onePower + powerThreeLine[i, j] + "\t|";
   }
   Console.WriteLine(new string('-', 8 * (number % 15)));
   Console.WriteLine(oneString);
   Console.WriteLine(new string('-', 8 * (number % 15)));
   Console.WriteLine(onePower);
   Console.WriteLine(new string('-', 8 * (number % 15)));
   Console.WriteLine();
}
