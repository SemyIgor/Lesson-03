// Lesson-03_Seminar09_Task64. 
// Print all positive integers in the range of M to N in descending order
// Вывести все натуральные числа в диапазоне от M до N в убывающем порядке. 

void PrintIntegersOfRange() // Gets two positive integer numbers and prints them from max to min
{
   Console.Clear();

   int minValue; // Declares variable to assign the valume through out parameter
   int maxValue; // Declares variable to assign the valume through out parameter

   try
   {
      string arrayItemRangeStr = InputString("Укажите минимальное и максимальное значение через тире (min-max): "); // Enter min and max using min - max form
      TakeNumbers(arrayItemRangeStr, "-", out minValue, out maxValue); // Extract from the string "min-max" two numbers and defines the min and the max of them

      Console.WriteLine("min = {0}; max = {1}", minValue, maxValue); // Prints min and max numbers
      RecursPrintMN(minValue - 1, maxValue);
   }
   catch
   {
      Console.WriteLine("Ошибка ввода данных");
   }
}

string InputString(string message) // Invitation to and input of a string
{
   Console.Write(message);
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

// Takes two numbers from the string and defines the min and the max of them
void TakeNumbers(string strLine, string mathOp, out int numFirst, out int numSecond)
{
   numFirst = int.Parse(strLine.Substring(0, strLine.IndexOf(mathOp))); // Takes the first number of the input string
   numSecond = int.Parse(strLine.Substring(strLine.IndexOf(mathOp) + 1)); // Takes the second number of the nput string

   // Changes num values of each other to set the min number as numFirst and max number as numSecond
   int temp;
   if (numFirst > numSecond)
   {
      temp = numSecond;
      numSecond = numFirst;
      numFirst = temp;
   }
}

// Prints positive integers from M to N in descending order, using recursion
int RecursPrintMN(int M, int N)
{
   int winWidth = Console.WindowWidth; // Gets the width of the console
   int tabSize = 4; // Tabulation field size
   int signsInRow = winWidth / tabSize; // Counts the number of the items could be fit in one row

   // Forms the output of numbers when printing to align every item in the row and when ends 
   // each row.If the last item in the row is printing we add "\n" to start printing the 
   // next item from the begining of the next row but not cutting it
   string formatItem = ((((N - M) + 1) % (signsInRow)) == 1) ? "{0, 3}|\n" : "{0, 3}|";

   // The end of plunging if all the numbers in the range min-max were iterated
   if (M == N) return M;
   else Console.Write(formatItem, RecursPrintMN(M + 1, N)); // Recursion happens
   return M; // Returns the number value
}

PrintIntegersOfRange(); // Main method starts here
