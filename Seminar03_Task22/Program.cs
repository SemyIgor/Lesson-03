// Seminar03_Task22. Input integer number and print this number and it's square

Console.Clear();
Console.Write("Введите целое число: ");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
   int number = int.Parse(numberStr);
   Console.WriteLine(number);
   string numberLine = String.Empty;
   string squareLine = String.Empty;
   for (int count = 1; count <= number - 1; count++)
   {
      numberLine = numberLine + count.ToString() + "\t|";
      squareLine = squareLine + (count * count).ToString() + "\t|";
   }
   numberLine = numberLine + number.ToString();
   squareLine = squareLine + (number * number).ToString();
   Console.WriteLine(new string('-', 120));
   Console.WriteLine(numberLine);
   Console.WriteLine(new string('-', 120));
   Console.WriteLine(squareLine);
   Console.WriteLine(new string('-', 120));
}
