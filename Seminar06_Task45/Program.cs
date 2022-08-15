// Lesson-03_Seminar06_Task45. Copy one-dimention array one-by-one element
// 
// // Conditions:
// Copy one-dimention array one-by-one element
// 
// Algorithms:
// 1. Generate array
// 2. Create new array
// 3. Copy generated array cycling one-by-one element to the new created one 

void CopyOneDimArray() // Main method
{
   Console.Clear();
   DateTime timeSharp; // System time

   // Parameters of the one-dimention array
   int arrayLength = 123;
   int minValue = 100;       // min value of the array's item (for randomizer)
   int maxValue = 999;     // max value of the array's item (for randomizer)

   Console.WriteLine("Исходный (сгенерированный) массив"); // Explanatory message
   int[] ArrayGenerated = GenerateArray(arrayLength, minValue, maxValue); // Generate array and save it to variable
   PrintArray(ArrayGenerated); // Print generated array

   Console.WriteLine("Копия сгенерированного массива (классический метод)"); // Explanatory message
   timeSharp = DateTime.Now; // Run time begins
   int[] ArrayDuplicated = CopyIntArray(ArrayGenerated); // Copy generated array to variable ArrayDuplicated
   Console.WriteLine("Classic time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(ArrayDuplicated); // Print duplicated array

   Console.WriteLine("Копия сгенерированного массива (поэлементное копирование"); // Explanatory message
   timeSharp = DateTime.Now; // Run time begins
   int[] ArrayDuplicatedByOne = CopyIntArrayByOneElement(ArrayGenerated); // Copy generated array to variable ArrayDuplicated
   Console.WriteLine("One-by-one time = {0} ms", DateTime.Now - timeSharp);
   PrintArray(ArrayDuplicatedByOne); // Print duplicated array
}

int[] GenerateArray(int arrayLength, int minValue, int maxValue)   // Generate array with length received 
{
   System.Random numberSintezator = new Random(); // Using system random generator
   int[] array = new int[arrayLength]; // Creating new array
   Console.WriteLine(array.Length + " - Длина начального массива"); // Print the initial array length

   for (int i = 0; i < arrayLength; i++) // Iterating every element for filling it with random number
   {
      array[i] = numberSintezator.Next(minValue, maxValue + 1); // Generates next random element
   }
   // Console.WriteLine();
   return array;  // Returns array
}

void PrintArray(int[] array) // Print given array
{
   int i = 0;
   Console.Write($"["); // Print opening bracket
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write("{0,4}, ", array[i]); // Print elements and commas using formatting
      i++;
   }
   Console.WriteLine("{0,4} ]\n", array[i]); // Print last element and closing bracket
}

int[] CopyIntArray(int[] array) // Copy received array to new array by classic method
{
   int[] arrayDuped = new int[array.Length]; // Create new array
   array.CopyTo(arrayDuped, 0); // Copy received array to new array using CopyTo method
   return arrayDuped; // Return duped array
}

int[] CopyIntArrayByOneElement(int[] array) // Copy received array to new array one-by-one element
{
   int[] arrayDuped = new int[array.Length]; // Create new array
   for (int i = 0; i < array.Length; i++) // Cycle to copy one-by-one
   {
      arrayDuped[i] = array[i]; // Cycling copy one element of generated array to one element of new array
   }
   return arrayDuped; // Return duped array 
}

CopyOneDimArray();

