// Lesson-03_Seminar09_Task63. Print positive integers in the range of 1 to N
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.

void PrintIntegerOfRange() // Main method
{
   Console.Clear();
   string numberStr = inputString();

   if (numberStr != null)
   {
      int number = int.Parse(numberStr);
      int winWidth = Console.WindowWidth; // Gets the width of the console

      Console.WriteLine("Рекурсия");
      Console.Write(new string(',', winWidth)); // Prints upper decoration string of the block
      PrintNumbersRecurs(number + 1); // Prints nambers
      Console.WriteLine(new string('`', winWidth)); // Prints bottom decoration string of the block
   }
}

string inputString() // Gets string
{
   Console.Write("Введите любое натуральное число: ");
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

int PrintNumbersRecurs(int number) // Prints positive integers from 1 to "number", using recursion
{
   int winWidth = Console.WindowWidth; // Gets the width of the console
   int tabSize = 4; // Tabulation field size
   int signsInRow = winWidth / tabSize; // Counts the number of the items could be fit in one row

   // Forms the output of numbers when printing to align every item in the row and when ends 
   // each row.If the last item in the row is printing we add "\n" to start printing the 
   // next item from the begining of the next row but not cutting it
   string formatItem = (((number) % (signsInRow)) == 1) ? "{0, 3}|\n" : "{0, 3}|";

   if (number == 1) return 1; // The end of plunging
   else Console.Write(formatItem, PrintNumbersRecurs(number - 1)); // Recursion happens

   return number; // Never is being achieved
}

PrintIntegerOfRange();

