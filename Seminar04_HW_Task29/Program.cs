// Lesson-03. Seminar04_HW_Task29. Input array length and range of values of it's items. Generate and print the array.
//  
// 1. Input length and range of values in template:
//    - "Введите длину массива" [18]
//    - "Введите диапазон значений элемента в формате [125 - 300]".
// 2. Generate array.
// 3. Print array.

void ArrayGenerator() // Root method
{
   Console.Clear();
   int minValue = 0;
   int maxValue = 0;

   string arrayLengthStr = InputString("Укажите длину массива: "); // Enter array length
   long arrayLengthNum = StringToNumberDigital(arrayLengthStr); // Convert string to number

   string arrayItemRangeStr = InputString("Укажите диапазон значений для элемента массива по форме min-max: "); // Enter range
   // arrayItemRangeStr = arrayItemRangeStr.Replace(" ", String.Empty); // Delets spaces in the received string
   TakeNumbers(arrayItemRangeStr, "-", out minValue, out maxValue); // Extract from the string "min-max" numbers "min" and "max"
   GenerateArray(arrayLengthNum, minValue, maxValue); // Generates and prints the array
}

string InputString(string message) // Invitation to and input of a string
{
   Console.Write(message);
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

long StringToNumberDigital(string strNumber) // Convert string of digits to number
{
   return long.Parse(strNumber);
}

void TakeNumbers(string strLine, string mathOp, out int numFirst, out int numSecond) // Takes numbers
{
   numFirst = int.Parse(strLine.Substring(0, strLine.IndexOf(mathOp))); // Takes the first number of the math problem
   numSecond = int.Parse(strLine.Substring(strLine.IndexOf(mathOp) + 1)); // Takes the second number of the math problem
}

void GenerateArray(long length, int min, int max) // Generates and prints the array
{
   System.Random arrayGenerator = new Random(); // Create array gentrator
   int[] numbersArray = new int[length];

   for (int i = 0; i < length; i++)
   {
      numbersArray[i] = arrayGenerator.Next(min, max);
      Console.WriteLine("{0, -3} - {1, 8}", i, numbersArray[i]);
   }
   // return numbersArray;
}

// ===================================================================================================

ArrayGenerator();
