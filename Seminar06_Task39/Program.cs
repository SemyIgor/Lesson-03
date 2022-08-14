// Lesson-03_Seminar06_Task39. Reverse array
// 
// Conditions:
// Reverse array
// 
// Algorithms:
// 
// -1. Generate array.
//  0. Print array
//  
// Variant I
// 1. Create new array
// 2. Iterate initial array from 0 to (array.Length-1) and fill new array from (array.Length-1) to 0
// 3. Print reversed array
// 
// Variant II
// 1. Create variable temp
// 2. Iterating re-write initial array by next order: 
//    temp<-array[i]; array[i]<-array[(arrayLength-1)-i]; array[(arrayLength-1)-i]<-temp
// 3. Print reversed initial array
// 
// Compare timing of the both methods

void ReverseArrayTwoMethods()
{
   DateTime timeSharp; // System time

   Console.Clear();
   int arrayLength = 123;
   int minValue = 100;
   int maxValue = 999;
   int[] initialArray = GenerateArray(arrayLength, minValue, maxValue);
   PrintArray(initialArray);

   Console.WriteLine("Variant I. Reverse array copy");
   timeSharp = DateTime.Now;
   int[] reverseToNewArray = ReverseToNewArray(initialArray);
   Console.WriteLine("Reverse new array time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(reverseToNewArray);

   Console.WriteLine("Variant II. Reverse array using temp variable");
   timeSharp = DateTime.Now;
   int[] reverseToVariable = ReverseToVariable(initialArray);
   Console.WriteLine("Reverse through variable time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(reverseToVariable);

   Console.WriteLine("Changed Initial array");
   PrintArray(initialArray);
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
   return array;  // Returns array
}

void PrintArray(int[] array) // Print given array
{
   int i = 0;
   Console.Write($"["); // Print opening bracket
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write("{0,4}, ", array[i]);
      i++;
   }
   Console.WriteLine("{0,4} ]\n", array[i]); // Print the last element and closing bracket
}

int[] ReverseToNewArray(int[] array) // Create new array and fill it by reverse using initial array
{
   int arrayLength = array.Length;
   int[] newArray = new int[arrayLength]; // Declare new array
   for (int i = 0; i < arrayLength; i++)
   {
      newArray[i] = array[arrayLength - 1 - i]; // Reversed filling of the new array
   }
   return newArray;
}

int[] ReverseToVariable(int[] array) // Reversing array using temp variable. 
{
   int arrayLength = array.Length;

   int[] sortedArray = new int[array.Length]; // Declare copy of the received array for "clean" timing

   for (int i = 0; i < arrayLength / 2; i++) // One iteration cycle - two elements changes
   {
      int temp = 0; // Declare temp variable
      temp = array[i]; // Left element save to temp variable
      array[i] = array[(arrayLength - 1) - i]; // Right element save to left element
      array[(arrayLength - 1) - i] = temp; // temp variable save to right element
   }
   array.CopyTo(sortedArray, 0); // Making copy of the reversed array for more "clean" timing 
   return sortedArray; // Return the copy of the reversed array
}

ReverseArrayTwoMethods();