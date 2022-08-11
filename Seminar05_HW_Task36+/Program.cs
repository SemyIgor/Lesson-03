// Lesson-03_Seminar05_Task36+. Generate array, * Find and show all pairs.

// Conditions:
// Generate array, * Find and show all pairs.

// Algorithms:
// 1. Declare arrayLength-elements array
// 2. Generate array: Cycle ("arrayLength" times):
// 3. Print generated array.
// 4.* Sort array with bubble sort.
// 4.* Find and show all pairs

void VariantFindPairs()
{
   Console.Clear();
   int arrayLength = 120;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 200;     // max value of the array's item (for randomizer)

   Console.WriteLine("Исходный (сгенерированный) массив");
   int[] arrayGenerated = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(arrayGenerated);

   Console.WriteLine("Отсортированный пузырьковой сортировкой массив");
   int[] arraySorted = BubbleSort(arrayGenerated);
   PrintArray(arraySorted);

   FindPairs(arraySorted);
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

void FindPairs(int[] array) // Find pairs in given array
{
   for (int i = 0; i < array.Length - 1; i++) // Last check should be done with the pre-last item
   {
      if (array[i] == array[i + 1])
      {
         Console.Write(array[i] + "=" + array[i + 1] + " "); // Print pairs while cycling
         i++; // Delete this line if pair in 5,5,5 means 5=5 5=5, leave it alone if it means 5=5 only
      }
   }
   Console.WriteLine();
}

VariantFindPairs();
