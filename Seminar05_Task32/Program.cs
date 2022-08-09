// Lesson-03_Seminar05_Task32. Change sign of the every array element to opposite one.
System.Random numberSintezator = new Random();
int arrayLength = 12;

void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Change sign of the every array element to opposite one.

   // Algorithms:
   // 1. Declare 12-elements array
   // 2. Cycle (12 times):
   //    - Generate integer number [-999;999]
   //    - If number > 0 sumPlus+=sumPlis
   //    - If number < 0 sumMinus+=sumMinus
   //    - If number == 0 does not matter and no influence on both sums, no need to check
   // 3. Print arrayOld, arrayNew;
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   Console.Clear();
   int[] arrayOld = GenerateArray(arrayLength);
   int[] arrayNew = ReverseArray(arrayOld);
   PrintArraysInComparision(arrayOld, arrayNew);
}

int[] GenerateArray(int arrayLength)   // Generate array with length received 
{
   int[] array = new int[arrayLength];
   for (int i = 0; i < arrayLength; i++)
   {
      array[i] = numberSintezator.Next(-999, 999); // Generates next random element
   }
   Console.WriteLine();
   return array;  // Returns array
}

int[] ReverseArray(int[] arrayOld)
{
   int[] arrayNew = new int[arrayOld.Length]; // Sould be new array, not an arrayOld's link
   for (int i = 0; i < arrayOld.Length; i++)
   {
      arrayNew[i] = arrayOld[i] * (-1);
      // arrayNew[i] = ~arrayOld[i] + 1; // This works faster
   }
   return arrayNew;  // Returns array
}

void PrintArraysInComparision(int[] arrOld, int[] arrNew) // Print in Comparision two equal-dimensions-arrays  
{
   Console.WriteLine("{0, 6} {1, 6}", "Old", "New");   // Header of the output

   for (int i = 0; i < arrOld.Length; i++)
   {
      Console.WriteLine("{0, 6} {1, 6}", arrOld[i], arrNew[i]);   // Header of the output
   }
   Console.WriteLine();
}

VariantMain();