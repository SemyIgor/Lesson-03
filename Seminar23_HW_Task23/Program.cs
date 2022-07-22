// Seminar03_Task23. Input integer number and print this number and it's power 3

Console.Clear();
Console.Write("Введите целое число: ");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
   int number = int.Parse(numberStr);
   Console.WriteLine(number);
   string numberLine = String.Empty;
   string powerThreeLine = String.Empty;
   for (int count = 1; count <= number - 1; count++)
   {
      numberLine = numberLine + count.ToString() + "\t|";
      powerThreeLine = powerThreeLine + (Math.Pow(count, 3)).ToString() + "\t|";
   }
   numberLine = numberLine + number.ToString();
   powerThreeLine = powerThreeLine + (Math.Pow(number, 3)).ToString();

   Console.WriteLine(new string('-', 120));
   Console.WriteLine(numberLine);
   Console.WriteLine(new string('-', 120));
   Console.WriteLine(powerThreeLine);
   Console.WriteLine(new string('-', 120));
}

