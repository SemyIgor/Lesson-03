// Lesson-03_Seminar04_HW_Task27. Sum of the digits of the entered number.
// Condition:
// Find the Sum of the Digits of the entered Number.
// 
// Algorithm:
// 1. Invitation to Enter a natural number.
// 2. Form the array of digits of the number:
//    - numeral;
//    - char.
// 3. Count the sum of the elements of the formed array.
// 4. Output result.
// 5. Make timing.

void Invitation() // Prints an invitation to input a number
{
   Console.Clear();
   Console.WriteLine("Введите любое натуральное число:");
}

string InputString() // Enter string of digits
{
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

long StringToNumberDigital(string strNumber) // Convert string of digits to number
{
   return long.Parse(strNumber);
}

long CountSumOfDigits(long number) // Count sum of digits of the number
{
   long sum = 0;
   while (number != 0)
   {
      sum = sum + (number % 10); // Take last digit and sum it
      number = number / 10;      // Cut off last digit
   }
   return sum;
}

void VariantNumeral(string inputNumberStr) // Variant Numeral (Variant I)
{
   long inputNumber = 0; // Make this variable visible out of the try...catch constract
   try
   {
      inputNumber = StringToNumberDigital(inputNumberStr); // Convert entered string into number
   }
   catch
   {
      Console.WriteLine("Ошибка! Вы ввели не натуральное или слишком большое число.");
      return; // Exit method without parameter
   }

   long sumOfDigits = CountSumOfDigits(inputNumber);
   Console.WriteLine($"Сумма цифр числа {inputNumber} равна {sumOfDigits}");
}

char[] NumberStringToCharArr(string strNumber) // Convert string to char array
{
   return strNumber.ToCharArray();
}

int CountSumOfCharDigits(char[] array) // Count the sum of char array elements
{
   try
   {
      int sum = 0;
      foreach (char item in array)
      {
         int digit = (int)item - 48; // Convert char into digit
         if ((digit < 0) || (digit > 9)) throw new Exception("Ошибка! Вы ввели не натуральное число."); // Exception if it is not digit
         sum = sum + digit;
      }
      return sum;
   }
   catch
   {
      throw; // Pass Exception to parent method
   }

}

void VariantChar(string inputNumberStr) // Variant Char (Variant II)
{
   try
   {
      char[] charArray = NumberStringToCharArr(inputNumberStr); // String to char array
      int sumOfDigits = CountSumOfCharDigits(charArray); // Count sum and check if there is not only digits in the array
      Console.WriteLine($"Сумма цифр числа {inputNumberStr} равна {sumOfDigits}"); // Output result
   }
   catch (Exception ex) // Catch Exception from child method and print message
   {
      Console.WriteLine(ex.Message); // Print message from the child's throw
   }

}

Console.Clear();
Invitation();

string inputNumberStr = InputString(); // Input string of the digits

DateTime timeSharp; // System time

timeSharp = DateTime.Now;
VariantNumeral(inputNumberStr); // Calling Numeral method
Console.WriteLine("Numeral time = {0} ms", DateTime.Now - timeSharp);
Console.WriteLine();

timeSharp = DateTime.Now;
VariantChar(inputNumberStr); // Calling Char method
Console.WriteLine("Char time = {0} ms", DateTime.Now - timeSharp);
Console.WriteLine();
