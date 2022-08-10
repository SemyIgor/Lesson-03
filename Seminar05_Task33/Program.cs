// Lesson-03_Seminar05_Task33. Check if given number is in the array

System.Random numberSintezator = new Random();
int arrayLength = 12;
int minValue = -10;
int maxValue = 10;

void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Check if given number is in the array.

   // Algorithms:
   // 1. Declare "arrayLength" -elements array
   // 2. Cycle ("arrayLength" times):
   //    - generate integer number as an array's element [-10; 11].
   //    - print generated number.
   // 3. Enter number and check if this number is contained by geven array
   // 4. Print result message;
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   string invitationMessage = $"Скажите, какое число от {minValue} до {maxValue} ищем в массиве: ";
   int searchingNumber = InputString(invitationMessage); // Printing message and receiving number

   int[] generatedArray = GenerateArray(arrayLength); // Generate array with length received
   PrintArray(generatedArray); // Print given (gentrated) array
   bool ifFound = IsNumberInArray(generatedArray, searchingNumber); // Check if the number in array
   string resultMessage = ifFound ? $"Число {searchingNumber} найдено" : $"Числа {searchingNumber} нет в массиве";
   OutputString(resultMessage);
}

int[] GenerateArray(int arrayLength)   // Generate array with length received 
{
   int[] array = new int[arrayLength];
   for (int i = 0; i < arrayLength; i++)
   {
      array[i] = numberSintezator.Next(minValue, maxValue + 1); // Generates next random element
   }
   Console.WriteLine();
   return array;  // Returns array
}

void PrintArray(int[] array) // Print given array
{
   int i = 0;
   Console.Write("[");
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write(array[i] + ", ");
      i++;
   }
   Console.WriteLine(array[i] + "]");
}

int InputString(string message) // Prints received invitation and inputs number
{
   Console.Write(message);
   int inputString = int.Parse(Console.ReadLine() ?? "");
   return inputString;
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message);
}

bool IsNumberInArray(int[] array, int number)
{
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] == number)
      {
         return true;
      }
   }
   return false;
}

VariantMain();