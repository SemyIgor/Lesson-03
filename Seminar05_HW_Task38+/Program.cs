// Lesson-03_Seminar05_Task38+. Generate array, * Sort array by counting sort and selection sort

// Conditions:
// Generate array, * Sort array by counting sort and insertion sort.

// Algorithms:
// 1. Declare arrayLength-elements array
// 2. Generate array: Cycle ("arrayLength" times):
// 3. Print generated array.
// 4.* Sort initial array using counting sort
// 5.* Sort initial array using insertion sort

void VariantSortingThreeMethods()
{
   Console.Clear();
   DateTime timeSharp; // System time
   int arrayLength = 123;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   Console.WriteLine("Исходный (сгенерированный) массив");
   int[] ArrayGenerated = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(ArrayGenerated);

   Console.WriteLine("Отсортированный пузырьковой сортировкой массив");
   timeSharp = DateTime.Now;
   int[] ArraySortedBubble = BubbleSort(ArrayGenerated);
   Console.WriteLine("Bubble time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(ArraySortedBubble);


   Console.WriteLine("Массив, отсортированный сортировкой выбора");
   timeSharp = DateTime.Now;
   int[] ArraySelectionSorted = SelectionSort(ArrayGenerated);
   Console.WriteLine("Selection time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(ArraySelectionSorted);


   Console.WriteLine("Массив, отсортированный сортировкой подсчёта");
   timeSharp = DateTime.Now;
   int[] ArrayCountingSorted = CountingSort(ArrayGenerated, minValue, maxValue);
   Console.WriteLine("Counting time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(ArrayCountingSorted);

   // Console.WriteLine("Массив, отсортированный сортировкой вставки");
   // int[] ArrayInsertionSorted = InsertionSort(ArrayGenerated);
   // PrintArray(ArrayInsertionSorted);
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

int[] SelectionSort(int[] array) // Sorts given array with counting sort method
{
   int[] sortedArray = new int[array.Length];
   array.CopyTo(sortedArray, 0); // Copy of the initial array

   int arrayLength = array.Length; // Save array length in the variable
   int k;
   int minUnsortedItem;
   for (int i = 0; i < arrayLength; i++)
   {
      k = i; // Marking index
      minUnsortedItem = sortedArray[i];
      for (int j = i + 1; j < arrayLength; j++)
      {
         if (sortedArray[k] > sortedArray[j]) // If use "<", we will have descending sort order
         {
            k = j;
         }
      }
      sortedArray[i] = sortedArray[k];
      sortedArray[k] = minUnsortedItem;
   }
   return sortedArray;
}

int[] CountingSort(int[] array, int minValue, int maxValue) // Sorts given array with insertion sort method
{
   int[] sortedArray = new int[array.Length]; // Declare copy of the received array
   int[] tempArray = new int[maxValue - minValue]; // Create temp array 
   array.CopyTo(sortedArray, 0); // Create copy of the received array

   for (int j = 0; j < sortedArray.Length; j++) // Iterate received array to fill temp array
   {
      tempArray[sortedArray[j] - minValue]++; // Fill tempArray (- minValue take into account that the range begins not from 0)
   }

   for (int i = 0; i < sortedArray.Length; i++) // Iterate received array
   {
      for (int j = 0; j < tempArray.Length; j++) // Iterate temp array
      {
         while (tempArray[j] > 0) // If there is a mark in temp array to fill received array
         {
            sortedArray[i] = j + minValue; // Fill received array (+ minValue take into account that the range begins not from 0)
            tempArray[j]--; // Decrease counter of the repeated values in received array
            i++; // Move to the next item in the received array
         }
      }
   }
   return sortedArray;
}

int[] InsertionSort(int[] array) // Sorts given array with insertion sort method
{
   int[] sortedArray = new int[array.Length];
   array.CopyTo(sortedArray, 0);


   return sortedArray;
}

VariantSortingThreeMethods();
