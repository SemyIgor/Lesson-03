// Lesson-03_Seminar05_Task38. Generate array with real items, 
// count difference between min and max items. 
// * Sort array through count sort and insertion sort
// * and count difference between first and last items.

void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate array with real items,count difference between min and max items.
   // * Sort array through count sort and insertion sort and
   // * count difference between the first and the last items

   // Algorithms:
   // 1. Declare arrayLength-elements array
   // 2. Generate array: Cycle ("arrayLength" times):
   // 3. Print generated array.
   // 4. Find min and max items of the array
   // 5. Print difference between min and max values.
   // * ============================================
   // * Sort array through count sort 
   // * ort array through insertion sort and
   // * count difference between the first and the last items
   // 5. Print difference between the first and the last item values.
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   Console.Clear();
   int arrayLength = 120;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   double[] generatedArrayDouble = GenerateArrayDouble(arrayLength, minValue, maxValue);
   PrintArray(generatedArrayDouble);

   double minItem = findMinValueInArray(generatedArrayDouble);
   Console.WriteLine("Минимальный элемент массива = {0}", minItem);

   double maxItem = findMaxValueInArray(generatedArrayDouble);
   Console.WriteLine("Максимальный элемент массива = {0}", maxItem);

   Console.WriteLine("Разница между минимальным и максимальным = {0}",
   Math.Round(maxItem - minItem, 2));
}

double[] GenerateArrayDouble(int arrayLength, int minValue, int maxValue)   // Generate array with length received 
{
   System.Random numberSintezator = new Random();
   double[] array = new double[arrayLength];
   Console.WriteLine(array.Length + " - Длина начального массива"); // Print the initial array length

   double randomNum = 0;
   for (int i = 0; i < arrayLength; i++)
   {
      randomNum = numberSintezator.NextDouble() *
      (maxValue + 1 - minValue); // Generates next random element
      array[i] = Math.Round(randomNum, 2); // Round value to two digits
   }
   // Console.WriteLine();
   return array;  // Returns array
}

void PrintArray(double[] array) // Print given array
{
   int i = 0;
   // Console.Write($"[");
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write("{0,8}| ", array[i]);
      i++;
   }
   Console.WriteLine("{0, 8}|\n", array[i]);
}

double findMinValueInArray(double[] array)
{
   int i = 0;
   double min = array[i];
   while (i < array.Length)
   {
      if (array[i] < min) min = array[i]; // If next item less then min, min value become next item
      i++;
   }
   return min;
}

double findMaxValueInArray(double[] array)
{
   int i = 0;
   double max = array[i];
   while (i < array.Length)
   {
      if (array[i] > max) max = array[i]; // If next item greater then max, max value become next item
      i++;
   }
   return max;
}

VariantMain();

