// Lesson-03_Seminar05_Task34. Generate array, count even items
// * Sort array by bubble sort
// 
// Conditions:
// Generate array, count even items.
// * Sort array by bubble sort.

// Algorithms:
// 1. Declare arrayLength-elements array
// 2. Generate array: Cycle ("arrayLength" times):
// 3. Print generated array.
// 4. Сount even items
// * ============================================
// 4.* Sort initial array using bubble sort
// 4.** Sort initial array using counting sort

void VariantSort()
{
   Console.Clear();
   int arrayLength = 123;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   int[] generatedArray = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(generatedArray);
   int coutnEven = CountEvenItems(generatedArray);

   string outputString = $"В массиве {coutnEven} чётных элементов";
   OutputString(outputString);

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

int CountEvenItems(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] % 2 == 0)
      {
         // Console.WriteLine("{0,4}{1,5}", i, array[i]); // Print even items and their indexes
         count++;
      }
   }
   return count;
}

void OutputString(string message) // Just print received message
{
   Console.WriteLine(message);
}

VariantSort();


