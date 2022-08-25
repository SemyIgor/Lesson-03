// Lesson-03_Seminar09_Task69. Get two numbers and raise the number A to the power of B
// Напишите программу, которая на вход принимает два числа А и В,
// и возводит число А в целую степень В с помощью рекурсии

void RaiseAToPowerB()
{
   Console.Clear();

   try
   {
      int baseNumber; // Base of the number
      int exponentNumber; // Exponent of the number

      // Enter number and it's power
      string enterTwoNumbersStr = InputString("Укажите число и его степень через запятую ");
      TakeNumbers(enterTwoNumbersStr, ",", out baseNumber, out exponentNumber); // Extract from the string two numbers

      Console.WriteLine("Основание степени = {0}; Показатель степени = {1}", baseNumber, exponentNumber); // Prints base and exponent

      // Saves entered numbers for the second variant
      int saveBase = baseNumber;
      int saveExp = exponentNumber;

      int resultK = RecursPowerNum(baseNumber, exponentNumber);
      Console.WriteLine("Результат метода Кирилла = {0}", resultK);

      int resultA = RecurseExt(saveBase, saveExp);
      Console.WriteLine("Результат метода Андрея = {0}", resultA);
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

int RecurseExt(int baseA, int expB) // Andrey's solution
{
   if (expB == 2) return baseA * baseA; // In case the number of last multiplication is even
   if (expB == 1) return baseA; // In case the number of last multiplication is odd
   if (expB % 2 == 0) // In case the number of multiplications is even
   {
      return RecurseExt(baseA, (expB / 2)) * RecurseExt(baseA, (expB / 2));
   }
   else // In case the number of multiplications is odd
   {
      return RecurseExt(baseA, (expB / 2)) * RecurseExt(baseA, (expB / 2) + 1);
   }
}

RaiseAToPowerB();
