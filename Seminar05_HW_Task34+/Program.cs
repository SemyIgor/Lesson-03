// Lesson-03_Seminar05_Task34+. Generate array, * Sort array by bubble sort

// Conditions:
// Generate array, * Sort array by bubble sort.

// Algorithms:
// 1. Declare arrayLength-elements array
// 2. Generate array: Cycle ("arrayLength" times):
// 3. Print generated array.
// 4.* Sort initial array using bubble sort

void VariantBubbleSort()
{
   Console.Clear();
   int arrayLength = 123;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   Console.WriteLine("Исходный (сгенерированный) массив");
   int[] ArrayGenerated = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(ArrayGenerated);

   Console.WriteLine("Отсортированный пузырьковой сортировкой массив");
   int[] ArraySorted = BubbleSort(ArrayGenerated);
   PrintArray(ArraySorted);
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
      Console.Write("{0,4}, ", array[i]);
      i++;
   }
   Console.WriteLine("{0,4} ]\n", array[i]);
}

int[] BubbleSort(int[] array) // Sorts given array with bubble sort method
{
   int[] arraySorted = new int[array.Length];
   array.CopyTo(arraySorted, 0);
   int temp = 0;
   int cycle = 1;
   int arrayLength = arraySorted.Length; // Put array length to variable

   while (cycle < arrayLength) // Cycle of passes through array
   {
      int i = 0; // Index changes from first to last unsorted element in one pass through array
      while (i < (arrayLength - cycle)) // One pass through array begins
      {
         if (arraySorted[i] > arraySorted[i + 1]) // If next item of the pair is less then previous
         {
            temp = arraySorted[i];
            arraySorted[i] = arraySorted[i + 1];
            arraySorted[i + 1] = temp;
         }
         i++;
      }
      cycle++; // Count passes through array
   }
   return arraySorted;
}

VariantBubbleSort();