// Lesson-03_Seminar09_Task69. Get two numbers and raise the number A to the power of B
// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии

void RaiseAToPowerB()
{
   Console.Clear();

   try
   {
      int baseNumber;
      int exponentNumber;

      // Enter number and it's power
      string enterTwoNumbersStr = InputString("Укажите число и его степень через запятую ");
      TakeNumbers(enterTwoNumbersStr, ",", out baseNumber, out exponentNumber); // Extract from the string two numbers

      Console.WriteLine("Основание степени = {0}; Показатель степени = {1}", baseNumber, exponentNumber); // Prints base and exponent
      int result = RecursPowerNum(baseNumber, exponentNumber);
      Console.WriteLine("Результат = {0}", result);
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

// Takes two numbers from the string 
void TakeNumbers(string strLine, string separator, out int baseNumber, out int exponentNumber)
{
   baseNumber = int.Parse(strLine.Substring(0, strLine.IndexOf(separator))); // Takes the first number 
   exponentNumber = int.Parse(strLine.Substring(strLine.IndexOf(separator) + 1)); // Takes the second number
}

int RecursPowerNum(int baseA, int expB) // Kirill's solution
{
   // The end of plunging if the power is 1
   if (expB == 1) return baseA;
   return baseA * RecursPowerNum(baseA, --expB); // Recursive multiplying baseA expB times
}

RaiseAToPowerB();
