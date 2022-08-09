// Lesson-03_Seminar05_Task31. Generate 12-item array of numbers with values of [-9;9] 

System.Random numberSintezator = new Random();
int arrayLength = 12;


void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate 12-elements array of numbers with values of [-9;9]

   // Algorithms:
   // VariantMy
   // 1. Declare sumPlus and sumMinus
   // 2. Declare 12-elements array
   // 2. Cycle (12 times):
   //    - Generate integer number [-9;9]
   //    - If number > 0 sumPlus+=sumPlis
   //    - If number < 0 sumMinus+=sumMinus
   //    - If number == 0 does not matter and no influence on both sums, no need to check
   // 3. Print sumPlus, sumMinus;
   // 
   // VariantMain
   // 1. Generate array
   // 2. Cycle (Iterate array)
   //    - If number > 0 sumPlus+=sumPlis
   //    - If number < 0 sumMinus+=sumMinus
   //    - If number == 0 does not matter and no influence on both sums, no need to check
   // 3. Print sumPlus, sumMinus;
}
ProblemStatement(); // Just to take away warning message

void VariantMy()     // VariantI
{
   Console.WriteLine("Variant I");
   int sumPlus = 0;     // Sum of positives
   int sumMinus = 0;    // Sum of negatives
   int[] array = new int[12];
   Console.WriteLine("{0, 6}{1, 6}{2, 6}", "Array", "Pos", "Neg");      // Header of the output
   for (int i = 0; i < 12; i++)                                         // Cycle
   {
      array[i] = numberSintezator.Next(-9, 9);  // Generate next array's element
      if (array[i] < 0)
      {
         sumMinus += array[i];                  // Sum negatives
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], "", array[i]);   // Print next line
      }
      else
      {
         sumPlus += array[i];                   // Sum positives
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], array[i], "");   // Print next line
      }
   }
   Console.Write("{0, 6}{1,6}{2,6}\n", "Итого", sumPlus, sumMinus); // Print result line
   Console.WriteLine();
}

void VariantMain()   // VariantII
{
   Console.WriteLine("Variant II");
   IterateArray(GenerateArray(arrayLength));
   Console.WriteLine();
}

int[] GenerateArray(int arrayLength)   // Generate array with length received 
{
   int[] array = new int[arrayLength];
   for (int i = 0; i < arrayLength; i++)
   {
      array[i] = numberSintezator.Next(-9, 9); // Generates next random element
   }
   return array;
}

void IterateArray(int[] array)
{
   int sumPlus = 0;
   int sumMinus = 0;
   int arrayLength = array.Length;

   Console.WriteLine("{0, 6}{1, 6}{2, 6}", "Array", "Pos", "Neg");   // Header of the output

   for (int i = 0; i < arrayLength; i++) // Iterate received array
   {
      if (array[i] < 0)
      {
         sumMinus += array[i];      // Sum negatives
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], "", array[i]);
      }
      else
      {
         sumPlus += array[i];       // Sum positives
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], array[i], "");
      }
   }
   Console.Write("{0, 6}{1,6}{2,6}\n", "Итого", sumPlus, sumMinus);  // Print result line
}

VariantMy();

VariantMain();
