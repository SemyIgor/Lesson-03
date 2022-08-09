// Lesson-03_Seminar05_Task31. Generate 12-item array of numbers with values of [-9;9] 

System.Random numberSintezator = new Random();

void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Generate 12-elements array of numbers with values of [-9;9]

   // Algorithms:
   // 1. Declare sumPlus and sumMinus
   // 2. Declare 12-elements array
   // 2. Cycle (12 times):
   //    - Generate integer number [-9;9]
   //    - If number > 0 sumPlus+=sumPlis
   //    - If number < 0 sumMinus+=sumMinus
   //    - If number == 0 does not matter and no influence on both sums, no need to check
   // 3. Print sumPlus, sumMinus;
}
ProblemStatement(); // Just to take away warning message

void VariantMain()
{
   int sumPlus = 0;
   int sumMinus = 0;
   int[] array = new int[12];
   Console.WriteLine("{0, 6}{1, 6}{2, 6}", "Array", "Pos", "Neg");
   for (int i = 0; i < 12; i++)
   {
      array[i] = numberSintezator.Next(-9, 9);
      if (array[i] < 0)
      {
         sumMinus += array[i];
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], "", array[i]);
      }
      else
      {
         sumPlus += array[i];
         Console.Write("{0, 6}{1,6}{2,6}\n", array[i], array[i], "");
      }

      // Console.WriteLine(sumMinus, sumPlus, array[i]);
   }
   Console.Write("{0, 6}{1,6}{2,6}\n", "Итого", sumPlus, sumMinus);

}

VariantMain();