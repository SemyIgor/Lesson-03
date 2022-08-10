// Lesson-03_Seminar05_Task35. Generate array with random 123 items. 
// Count items with values in range [10, 99]
// 
void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate array with random 123 items. Count items with values in range [10, 99]

   // Algorithms:
   // 1. Declare arrayLength-elements array
   // 2. Generate array: Cycle ("arrayLength" times):
   //    - generate integer number as an array's element [minValue; maxValue].
   //    - print generated number.
   // 3. Count alements with values in range [rangeFrom, rangeTo]
   //    - declare int Count;
   //    - arrange Cycle checking if this item in range
   // 4. Print Count;
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   int arrayLength = 123;
   int minValue = 0;
   int maxValue = 500;
   int rangeFrom = 10;
   int rangeTo = 99;


   int[] generatedArray = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(generatedArray);
   int countNumbersInRange = CountItemsByRange(generatedArray, rangeFrom, rangeTo);
   string outputString = $"В массиве {countNumbersInRange} элементов в диапазоне от {rangeFrom} до {rangeTo}";
   OutputString(outputString);

}

int[] GenerateArray(int arrayLength, int minValue, int maxValue)   // Generate array with length received 
{
   System.Random numberSintezator = new Random();
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
   Console.WriteLine(array[i] + "]\n");
}

int CountItemsByRange(int[] receivedArray, int rangeFrom, int rangeTo)
{
   int count = 0;
   for (int i = 0; i < receivedArray.Length; i++)
   {
      if (receivedArray[i] >= rangeFrom && receivedArray[i] <= rangeTo)
      {
         Console.Write(receivedArray[i] + " ");
         count++;
      }
   }
   Console.WriteLine();
   return count;
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message);
}

VariantMain();