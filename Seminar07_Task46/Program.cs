// Lesson-03_Seminar07_Task46. Create two-dimentional array.

void CreateTwoDimArray()
{
   int rows = 7;
   int columns = 5;
   int minRange = 0;
   int maxRange = 100;

   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minRange, maxRange); // Generate two-dimentional array
   PrintTwoDimArray(intTwoDimArray); // Print two-dimentional array

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
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 3}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

// Двумерный массив с рациональными (double) элементами сделать потом
// void PrintArray(double[,] array) // Print given array
// {
//    for (int j = 0; j < array.GetLength(0); j++)
//    {
//       int i = 0;
//       Console.Write($"["); // Print opening bracket
//       while (i < array.GetLength(1) - 1) // Print elements and commas, but not last element
//       {
//          Console.Write("{0,4}, ", array[j, i]); // Print elements and commas using formatting
//          i++;
//       }
//       Console.WriteLine("{0,4} ]\n", array[j, i]); // Print last element and closing bracket

//    }
// }


CreateTwoDimArray();