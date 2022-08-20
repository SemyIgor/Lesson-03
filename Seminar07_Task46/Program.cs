// Lesson-03_Seminar07_Task46. Create two-dimentional array.

void CreateTwoDimArray()
{
   int rows = 7;
   int columns = 5;
   int minValue = 0;
   int maxValue = 100;

   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generate two-dimentional array
   PrintTwoDimArray(intTwoDimArray); // Print two-dimentional array

}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random(); // Initiates random number generator
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Generates one random array item
      }
   }
   return twoDimArray; // returns two-dimantional array
}

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 3}", twoDimArray[i, j]); // Print one next element
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

CreateTwoDimArray();