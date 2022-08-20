// Lesson-03_Seminar08_Task55. Exchanges rows to columns and vice versa
// 

void ExchangeTwoDimArrayElements() // General method
{
   int rows = 10; // Number of rows 
   int columns = 10; // Number of columns
   int minValue = 0; // Minimal value of the array item
   int maxValue = 10; // Maximum value of the array item

   Console.Clear();

   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generates array
   PrintTwoDimArrayColor(initArray); // Prints array
   Console.WriteLine(); // Separating string

   // Checking if it is possible to transform the array
   if (initArray.GetLength(0) != initArray.GetLength(1))
   {
      Console.WriteLine("В массиве {0}x{1} невозможно заменить строки на столбцы и наоборот", initArray.GetLength(0), initArray.GetLength(1)); // Printing if impossible to transform
      return;
   }

   Console.WriteLine(); // Separating string

   int[,] changedArray = ChangeRowsToColTwoDimArray(initArray); // Transforming the array
   PrintTwoDimArrayColor(changedArray); // Prins the transformed array
}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Fills next array's item
      }
   }
   return twoDimArray; // Returns array
}

int[,] ChangeRowsToColTwoDimArray(int[,] twoDimArray)
{
   int columns = twoDimArray.GetLength(1);
   int rows = twoDimArray.GetLength(0);
   int temp = 0;

   for (int i = 0; i < rows; i++)
   {
      for (int j = i; j < columns; j++)
      {
         temp = twoDimArray[i, j]; // Save to variable
         twoDimArray[i, j] = twoDimArray[j, i];
         twoDimArray[j, i] = temp;
      }
   }
   return twoDimArray;
}

void PrintTwoDimArrayColor(int[,] twoDimArray) // Print two-dimentional array
{
   // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         // Checks if the item is located on the second main diagonal and changes it's color if so
         if ((i + j) == (twoDimArray.GetLength(0) - 1))
         {
            Console.ForegroundColor = ConsoleColor.Blue; // Changes color of the text in console
            Console.Write("{0, 3}", twoDimArray[i, j]); // Prints array's item
            Console.ResetColor(); // Resets color to default color
         }
         // If its not the second main diagonal prints item without changing the color
         else Console.Write("{0, 3}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

ExchangeTwoDimArrayElements(); // Main method starts here

// 
// void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
// {
//    // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
//    for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
//    {
//       for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
//       {
//          Console.Write("{0, 3}", twoDimArray[i, j]);
//       }
//       Console.WriteLine(); // Empty string to separate lines
//    }
// }