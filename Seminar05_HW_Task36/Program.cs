// Lesson-03_Seminar05_Task36. Generate array, sum items placed at the pos with odd indexes. 
// * Print all pairs in the array
// 
void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate array, sum items placed at the pos with odd indexes.
   // * Print all pairs in the array

   // Algorithms:
   // 1. Declare arrayLength-elements array
   // 2. Generate array: Cycle ("arrayLength" times):
   // 3. Print generated array.
   // 4. Sum items with odd indexes.
   // * ============================================
   // 4.* Find and show all pairs.
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   Console.Clear();
   int arrayLength = 123;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   int[] generatedArray = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(generatedArray);

   long sumOdd = SumOddIndexItem(generatedArray);
   Console.WriteLine("Сумма нечётных элементов равна {0}", sumOdd);
}

int[] GenerateArray(int arrayLength, int minValue, int maxValue)   // Generate array with length received 
{
   System.Random numberSintezator = new Random();
   int[] array = new int[arrayLength];
   Console.WriteLine(array.Length + " - Длина начального массива"); // Print the initial array length

   for (int i = 0; i < arrayLength; i++)
   {
      array[i] = numberSintezator.Next(minValue, maxValue + 1); // Generates next random element
   }
   // Console.WriteLine();
   return array;  // Returns array
}

void PrintArray(int[] array) // Print given array
{
   int i = 0;
   Console.Write($"[");
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write("{0,5}, ", array[i]);
      i++;
   }
   Console.WriteLine("{0, 5} ]\n", array[i]);
}

long SumOddIndexItem(int[] array)
{
   long sumOdd = 0;
   for (int i = 1; i < array.Length; i += 2)
   {
      sumOdd = sumOdd + array[i];
   }
   return sumOdd;
}

VariantMain();