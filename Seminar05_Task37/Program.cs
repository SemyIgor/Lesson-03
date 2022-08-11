// Lesson-03_Seminar05_Task37. Generate array, multiply items in pairs.
// 
void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate array, multiply items in pairs.

   // Algorithms:
   // 1. Declare arrayLength-elements array
   // 2. Generate array: Cycle ("arrayLength" times):
   //    - generate integer number as an array's element [minValue; maxValue].
   //    - print generated number.
   // 3. Take array and form a new array of multiplied pairs of the taken array's items
   // 4. Print formed array;
}
ProblemStatement(); // Just to take away warning message

void VariantIterate()
{
   Console.Clear();
   int arrayLength = 123;
   int minValue = 0;       // min value of the array's item (for randomizer)
   int maxValue = 500;     // max value of the array's item (for randomizer)

   int[] generatedArray = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(generatedArray);
   int[] newArray = FormNewArrayViaIterate(generatedArray);
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

int[] FormNewArrayViaIterate(int[] array)
{

   int newArrayLength = (array.Length / 2) + (array.Length % 2); // 2nd term is 1 if length is odd 
   Console.WriteLine(newArrayLength + " - Длина нового массива"); // Print new array length
   Console.WriteLine(); // Print separating empty line
   int[] outputArray = new int[newArrayLength]; // Declare new array

   Console.WriteLine("{0,-4} {1,6} {2,6} {3,8}", "i", "First", "Second", "Multiple"); // Print header

   for (int i = 0; i < newArrayLength; i++)
   {
      if (i != (array.Length - 1) - i) // Do, if the element is not a middle element in the odd length array  
      {
         outputArray[i] = array[i] * array[(array.Length - 1) - i]; // Form i-element of new array
         Console.WriteLine("{0,-4} {1,6} {2,6} {3,8}", i, array[i], array[(array.Length - 1) - i],
         outputArray[i]); // Print i-element of new array and data to form this element 
      }
      else // Do, if the element is a middle element in the odd length array
      {
         outputArray[i] = array[i];
         Console.WriteLine("{0,-4} {1,6} {2,6} {3,8}", i, array[i], array[(array.Length - 1) - i], outputArray[i]);
      }
   }
   return outputArray;
}

VariantIterate();