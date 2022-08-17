// Lesson-03_Seminar07_Task51. Generates two-dim array, sum elements in main diagonal

void ArrayMainDiagonalCalcSum()
{
   int rows = 20; // Height of the matrix
   int columns = 15; // Width of the matrix
   int minRange = 0; // Min Value of elements
   int maxRange = 21; // Max Value of elements

   Console.Clear();

   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minRange, maxRange); // Generates two-dimentional array
   CalcMainDiagonalSum(intTwoDimArray); // Calculates sum of the main diagonal elements and prints colorized result

}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max);
      }
   }
   return twoDimArray;
}

void CalcMainDiagonalSum(int[,] twoDimArray) // Calculates sum of the main diagonal elements and prints colorized result and then prints sum under the last colomn of the matrix
{
   int sum = 0;
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         if (i == j) /* If element belongs to main diagonal */
         {
            Console.ForegroundColor = ConsoleColor.Red; // Color of the main diagonal element 
            Console.Write("{0, -5}", twoDimArray[i, j]); // Print element
            Console.ResetColor(); // Resets color to default one

            sum = sum + twoDimArray[i, j]; // Sum elements in cycle
         }
         else Console.Write("{0, -5}", twoDimArray[i, j]); // Prints all elements but main diagonal
      }
      Console.WriteLine(); // Separates lines printed
   }
   int origCol = Console.CursorLeft; // Get cursor horizontal pos
   int origRow = Console.CursorTop; // Get cursor vertical pos
   int shift = (twoDimArray.GetLength(1) < twoDimArray.GetLength(0)) ?
    twoDimArray.GetLength(1) : twoDimArray.GetLength(0); // Calculates shift position for sum printing
   Console.Write("Сумма:"); // Prints header of the sum
   Console.SetCursorPosition(origCol + 5 * (shift - 1), origRow); // Sets cursor for printing sum

   Console.ForegroundColor = ConsoleColor.Red; // Set color for printing the sum 
   Console.WriteLine("{0}", sum); // Prints sum
   Console.ResetColor(); // Resets color to default color
}

ArrayMainDiagonalCalcSum();