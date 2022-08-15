// Lesson-03_Seminar06_Task44. Output N fibonacci numbers when n1=0, n2=1.
// // Conditions:
// Output N fibonacci numbers when n1=0, n2=1.
// Don't use recursion !
// 
// Algorithms:
// 1. Read number of items
// 2. Generate items and print them in line

void GenerateFibonacciRow() // Generate and output fibonacci numbers
{
   Console.Clear();
   DateTime timeSharp; // System time

   string invitationMessage = "Введите требуемое количество чисел Фибоначчи\n"; // Invitation message
   int inputedNumber =
   InputStringToInteger(invitationMessage); // Input length of the fibonacci sequnce

   Console.WriteLine("Variant I - without using arrays"); // Header of the method
   timeSharp = DateTime.Now; // Run time begins
   GenerateFibonacciNoArray(inputedNumber); // Call method not using arrays and strings
   Console.WriteLine("noArrays time = {0} ms", DateTime.Now - timeSharp); // Print run time

   Console.WriteLine(); // Separates methods output

   Console.WriteLine("Variant II - using arrays"); // Header of the method
   timeSharp = DateTime.Now; // Run time begins
   int[] arrayOfFibonacciRow = GenerateFibonacciUsingArray(inputedNumber); // Calling not using arrays and strings method
   PrintArray(arrayOfFibonacciRow); // Prints generated array
   Console.WriteLine("Array time = {0} ms", DateTime.Now - timeSharp); // Print run time
}

int InputStringToInteger(string message) // Input string and convert it to integer
{
   Console.Write(message); // Print input message
   int integerNumber = int.Parse(Console.ReadLine() ?? ""); // Convert string to integer
   return integerNumber; // Return inputed number (Is equal the length of the Fibonacci sequence)
}

void GenerateFibonacciNoArray(int lengthOfRow) // Generate Fibonacci sequence using variables
{
   int nFirst = 0; // First element
   int nSecond = 1; // Second element
   int nThird = 1; // Third element
   if (lengthOfRow == 1) Console.WriteLine("[ 0 ]"); // Execute if the input number is 1
   if (lengthOfRow == 2) Console.WriteLine("[ 0, 1 ]"); // Execute if the input number is 2
   if (lengthOfRow > 2) // Execute if the input number is greater then 2
   {
      Console.Write("[ {0}, {1}, ", nFirst, nSecond); // Print two first elements of the sequence
      for (int i = 3; i < lengthOfRow; i++) // Calculate elements from the third one
      {
         Console.Write("{0}, ", nThird); // Print next element
         nFirst = nSecond; nSecond = nThird; nThird = nFirst + nSecond; // Calculate next element
      }
      Console.WriteLine($"{nThird} ]"); // Print the last element and closing bracket
   }
}

int[] GenerateFibonacciUsingArray(int lengthOfRow) // Generate Fibonacci sequence using array
{
   int[] array = new int[lengthOfRow];
   array[0] = 0; // First element of the sequence
   if (lengthOfRow > 1) array[1] = 1; // If the length of sequence is >1 so second element is 1 
   for (int i = 2; i < lengthOfRow; i++) // Generates elements with index >1
   {
      array[i] = array[i - 2] + array[i - 1]; // Calculate new element of the sequence
   }
   return array;
}

void PrintArray(int[] array) // Print given array
{
   int i = 0;
   Console.Write($"["); // Print opening bracket
   while (i < array.Length - 1) // Print elements and commas, but not last element
   {
      Console.Write("{0,4}, ", array[i]); // Print the next element
      i++;
   }
   Console.WriteLine("{0,4} ]\n", array[i]); // Print the last element and closing bracket
}

GenerateFibonacciRow(); // Starts main method



