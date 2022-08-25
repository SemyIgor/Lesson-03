// Lesson-03_Seminar09Task66. Calculate sum of numbers form M to N
// Задать два числа M и N. Найти сумму элементов от M до N

void PrintIntegersOfRange() // Gets two positive integer numbers and sum all numbers in this range
{
   Console.Clear();

   int minValue; // Declares variable to assign the valume through out parameter
   int maxValue; // Declares variable to assign the valume through out parameter
   int sumValue = 0; // Initial value of the sum

   try
   {
      string arrayItemRangeStr = InputString("Укажите минимум и максимум значений M и N через тире (M-N): "); // Enter min and max using min - max form
      TakeNumbers(arrayItemRangeStr, "-", out minValue, out maxValue); // Extract from the string "min-max" two numbers and defines the min and the max of them

      Console.WriteLine("min = {0}; max = {1}", minValue, maxValue); // Prints min and max numbers
      int result = RecursSumMN(sumValue, minValue, maxValue);
      Console.WriteLine("Сумма = {0}", result);
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
   numFirst = int.Parse(strLine.Substring(0, strLine.IndexOf(mathOp))); // Takes the first number of the math problem
   numSecond = int.Parse(strLine.Substring(strLine.IndexOf(mathOp) + 1)); // Takes the second number of the math problem

   // Changes num values of each other to set the min number as numFirst and max number as numSecond
   int temp;
   if (numFirst > numSecond)
   {
      temp = numSecond;
      numSecond = numFirst;
      numFirst = temp;
   }
}

int RecursSumMN(int sum, int M, int N) // Prints positive integers from M to N, using recursion
{
   // Plunge ends if all numbers were summed
   if (M == N)
   {
      return M;
   }
   else /* Continue */
   {
      sum = N + RecursSumMN(sum, M, N - 1); // Recursion
   }
   return sum; // Returns the sum value
}

PrintIntegersOfRange(); // Main method starts here

