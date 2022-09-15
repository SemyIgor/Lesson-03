// Lesson-03_Seminar08_HW_Task58. Multiply two matrix.

void MulTwoMatrix()
{
   // Matrix A dimensions
   int rowsA = 8;
   int colsA = 10;

   // Matrix B dimensions
   int rowsB = 10;
   int colsB = 4;

   // Range of the matrix items values
   int minValue = 0;
   int maxValue = 9;

   string valueSize = "1"; // Sets the printing field's size equal to the maximum possible size of the item's value
   string gapSize = " "; // Sets the gap between elements of array

   Console.Clear();
   int[,] initArrayA = IntGenerateTwoDimArray(rowsA, colsA, minValue, maxValue); // Generates matrix A
   Console.WriteLine("Матрица А");
   PrintTwoDimArray(initArrayA, valueSize, gapSize); // Prints matrix A

   Console.WriteLine(); // Separating string

   int[,] initArrayB = IntGenerateTwoDimArray(rowsB, colsB, minValue, maxValue); // Generates matrix A
   Console.WriteLine("Матрица В");
   PrintTwoDimArray(initArrayB, valueSize, gapSize); // Prints matrix A

   Console.WriteLine(); // Separating string

   // Checks if it is possible to multiply A and B matrix
   if (initArrayA.GetLength(1) != initArrayB.GetLength(0))
   {
      Console.WriteLine("Невозможно перемножить матрицы");
      return;
   }
   // Matrix multiplication
   int[,] arrayC = MultiplyMatrix(initArrayA, initArrayB);
   Console.WriteLine("Матрица С = А х В");

   valueSize = "3"; // Makes tabulation field larger to fit it the values of product's sums
   PrintTwoDimArray(arrayC, valueSize, gapSize); // Prints matrix C
}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Random generation of the one array item
      }
   }
   return twoDimArray;
}

void PrintTwoDimArray(int[,] twoDimArray, string valueSize, string gapSize) // Print two-dimentional array
{
   valueSize = "{0, " + valueSize + "}";
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write(valueSize + gapSize, twoDimArray[i, j]); // Prints one next array item
      }
      Console.WriteLine(); // Empty string to separate rows
   }
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB) // Multiplies two matrix
{
   int rowsC = matrixA.GetLength(0); // Rows A
   int colsC = matrixB.GetLength(1); // Columns B
   int colsA = matrixA.GetLength(1); // Columns A

   int[,] matrixC = new int[rowsC, colsC];

   for (int i = 0; i < rowsC; i++) // Iterates rows of the matrix C for filling matrix C by formed rows of the matrix C
   {
      for (int j = 0; j < colsC; j++) // Iterates columns of the matrix C for filling one row of the matrix C
      {
         matrixC[i, j] = 0;               // Begins new row of the matrix C
         for (int k = 0; k < colsA; k++)  // Iterates columns of the matrix A for getting one item of matrix C
         {
            // Sums products of multiplying row of the matrix A (i means number of row, k means each item in this row)
            // by the column of the matrix B (j means the number of column, k means each item in this column)
            matrixC[i, j] += matrixA[i, k] * matrixB[k, j]; // summs products one-by-one to get one item of the matrix C
         }
      }
   }
   return matrixC;

   // for (int i = 0; i < rowsC; i++)
   // {
   //    for (int j = 0; j < colsC; j++)
   //    {
   //       matrixC[i, j] = matrixA
   //    }
   // }

}

MulTwoMatrix(); // Starts main method