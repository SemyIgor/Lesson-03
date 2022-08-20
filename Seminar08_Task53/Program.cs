// Lesson-03_Seminar08_Task53. Exchange values of the first and the last rows

void ExchangeTwoDimArrayElements()
{
   int rows = 10;
   int columns = 14;
   int minValue = 0;
   int maxValue = 21;

   Console.Clear();
   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue);

   PrintTwoDimArray(initArray);

   Console.WriteLine();

   int[,] changedArray = ChangeRowsTwoDimArray(initArray);

   PrintTwoDimArray(changedArray);

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

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 5}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

int[,] ChangeRowsTwoDimArray(int[,] twoDimArray)
{
   int columns = twoDimArray.GetLength(1);
   int rows = twoDimArray.GetLength(0);
   // int[] oneDimArray = new int[columns];
   int temp = 0;
   for (int j = 0; j < columns; j++)
   {
      temp = twoDimArray[0, j]; // Save top line of two-dim array
      twoDimArray[0, j] = twoDimArray[rows - 1, j];
      twoDimArray[rows - 1, j] = temp;
   }
   return twoDimArray;
}

ExchangeTwoDimArrayElements();