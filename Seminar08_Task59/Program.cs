// lesson-03_Seminar08_Task59. Generate array. Remove row and colomn with the min element

void RemoveMinItemRowCol() // Main method
{
   int rows = 8; // Number of rows 
   int columns = 8; // Number of columns
   int minValue = 10; // Minimal value of the array item
   int maxValue = 50; // Maximum value of the array item

   Console.Clear();

   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generates array
   PrintTwoDimArray(initArray); // Prints array
   Console.WriteLine(); // Separating string

   int[] minItemIndexes = FindMinElemIndexs(initArray, maxValue); // Finds indexes of the minimum array item
   ColorPrintTwoDimArray(initArray, minItemIndexes); // Prints colorized lines to be removed
   Console.WriteLine(); // Separating string

   int[,] removeRowColArray = RemoveRowCol(initArray, minItemIndexes); // Removes selected row and colomn
   PrintTwoDimArray(removeRowColArray); // Prints array
}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col]; // Declares the array 
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Fills next array's item
      }
   }
   return twoDimArray; // Returns array
}

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 3}", twoDimArray[i, j]); // Prints array item
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

int[] FindMinElemIndexs(int[,] twoDimArray, int maxValue) // Finds indexes of the minimum array item
{
   int[] minItemIndexes = new int[2]; // Indexes of the min element of the array
   int minElem = maxValue, minElemI = 0, minElemJ = 0; // Sets initial value and indexes of the min element
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Iterates rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Iterates columns
      {
         /* Searching array item with minimum value and it's indexes */
         if (twoDimArray[i, j] < minElem)
         {
            minElem = twoDimArray[i, j];
            minElemI = i;
            minElemJ = j;
         }
      }
   }
   minItemIndexes[0] = minElemI; // Saves index of the minimum element's row to array
   minItemIndexes[1] = minElemJ; // Saves index of the minimum element's column to array
   return minItemIndexes; // Returns array of indexes of the row and the column of the min value element
}

void ColorPrintTwoDimArray(int[,] twoDimArray, int[] minElemIndexes) // Print two-dimentional array
{
   // System.Random randomSintezator = new Random();
   // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
         if (i == minElemIndexes[0] || j == minElemIndexes[1]) // If the row or column contains the min element
         {
            Console.ForegroundColor = ConsoleColor.Red; // Sets color
            Console.Write("{0, 3}", twoDimArray[i, j]); // Prints colorized element
            Console.ResetColor(); // Resets color to default color
         }
         else
         {
            Console.Write("{0, 3}", twoDimArray[i, j]); // Prints next element without painting
         }
      Console.WriteLine(); // Empty string to separate lines
   }
}

int[,] RemoveRowCol(int[,] initArray, int[] indexes) // Removes selected row and column
{
   int newRows = initArray.GetLength(0) - 1; // Finds number of rows of the new array
   int newCols = initArray.GetLength(1) - 1; // Finds number of columns of the new array
   int[,] outArray = new int[newRows, newCols]; // Declares new array

   int k = 0; // outArray's initial row index
   int l = 0; // outArray's initial column index
   for (int i = 0; i < initArray.GetLength(0); i++) // Iterates the initArray rows
   {
      if (i != indexes[0]) // If row != min element's row then do iteration
      {
         l = 0; // Start value of the outArray's colomn of the next row
         for (int j = 0; j < initArray.GetLength(1); j++) // Iterates the initArray columns
         {
            if (j != indexes[1]) // If column != min element's column
            {
               outArray[k, l] = initArray[i, j]; // Fills the next element of the outArray
               l++; // Increments the column index of the outArray
            }
         }
         k++; // Increments the row index of the outArray
      }
   }
   return outArray;
}

RemoveMinItemRowCol(); // Starts main method