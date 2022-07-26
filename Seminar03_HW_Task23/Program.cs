// Seminar03_Task23. Input integer number and print this number and it's power 3

Console.Clear();
Console.Write("Введите целое число: ");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
   int number = int.Parse(numberStr);

   int numbersInLine = 14; // Columns in the table
   string[,] numberLine = new string[(number / numbersInLine) + 1, numbersInLine];
   string[,] powerThreeLine = new string[number / numbersInLine + 1, numbersInLine];

   int n = number / numbersInLine;
   int i = 0;
   string oneString = String.Empty;
   string onePower = String.Empty;
   while (i < n)
   {
      oneString = "| Число" + "\t|";
      onePower = "| Куб" + "\t|";
      for (int j = 0; j < numbersInLine; j++)
      {
         numberLine[i, j] = (i * numbersInLine + j + 1).ToString();
         powerThreeLine[i, j] = Math.Pow(Convert.ToInt32(numberLine[i, j]), 3).ToString();
         oneString = oneString + numberLine[i, j] + "\t|";
         onePower = onePower + powerThreeLine[i, j] + "\t|";
      }

      Console.WriteLine(new string('-', 8 * (numbersInLine + 1)) + "-");
      Console.WriteLine(oneString);
      Console.WriteLine(new string('-', 8 * (numbersInLine + 1)) + "-");
      Console.WriteLine(onePower);
      Console.WriteLine(new string('-', 8 * (numbersInLine + 1)) + "-");
      i++;
   }

   oneString = "| Число" + "\t|";
   onePower = "| Куб" + "\t|";
   for (int j = 0; j < (number % numbersInLine); j++)
   {
      numberLine[i, j] = (i * numbersInLine + j + 1).ToString();
      powerThreeLine[i, j] = Math.Pow(Convert.ToInt32(numberLine[i, j]), 3).ToString();
      oneString = oneString + numberLine[i, j] + "\t|";
      onePower = onePower + powerThreeLine[i, j] + "\t|";
   }
   Console.WriteLine(new string('-', 8 * ((number % numbersInLine) + 1)) + "-");
   Console.WriteLine(oneString);
   Console.WriteLine(new string('-', 8 * ((number % numbersInLine) + 1)) + "-");
   Console.WriteLine(onePower);
   Console.WriteLine(new string('-', 8 * ((number % numbersInLine) + 1)) + "-");
   Console.WriteLine();
}
