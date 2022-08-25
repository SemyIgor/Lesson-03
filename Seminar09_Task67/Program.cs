// Lesson-03_Seminar09_Task67. Calculate the sum of the digits of the given number
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр

void CountDigitSumRecurs()
{
   Console.Clear();

   try // Trying if the received string could be transformed into number
       // Обрабатываем исключение на предмет перевода строки в число (без конкренизации исключения)
   {
      // inputString();
      long numberStr = long.Parse(inputString()); // Gets number to count the sum of it's digits

      long digitSum = 0;
      VariantRecurrent(ref digitSum, numberStr); // Calling Recurrent method
      Console.WriteLine("Сумма цифр во введенном числе равна {0} ", digitSum);
      Console.WriteLine();
   }
   catch
   {
      Console.WriteLine("Exception occured ! Too long or too short number.");
   }
   finally
   {
      Console.WriteLine();
   }
}

string inputString() // Enter string of digits
{
   Console.Write("Введите любое натуральное число: ");
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

// Recurrent cutting the given number by one digit to add this  last digit to sum
// The sum is accumulating in the external variable diginSum using ref parameter modifier
long VariantRecurrent(ref long digitSum, long numStr)
{
   if (numStr < 1) return digitSum; // The end of plunging if no digits remain
   digitSum = digitSum + numStr % 10; // Sums next digit
   return VariantRecurrent(ref digitSum, numStr / 10); // 
}

CountDigitSumRecurs(); // Main method starts here
