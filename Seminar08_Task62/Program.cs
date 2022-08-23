// Lesson-03_Seminar08_Task62. Fill spiral array

void FillSpiral()
{
   int row = 5; // Number of rows of the array
   int column = 5; // Number of columns of the array
   int[,] spiral = FillSpiralTwoDimArray(row, column); // Fills spural array

   PrintTwoDimArray(spiral); // Prints spiral array
}

int[,] FillSpiralTwoDimArray(int row, int column) // Fills spural array
{
   int[,] spiralMatrix = new int[row, column];

   int fillNumber = 1; // Counter of the array's items
   int i = 0; // Counter of the array's rows
   int j = 0; // Counter of the array's columns

   while (fillNumber <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1)) // array's size
   {
      spiralMatrix[i, j] = fillNumber; // Fills the array with one item
      fillNumber++; // Increments array items counter
      if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1) j++; // Horisontal to right
      else
         if (i < j && i + j >= spiralMatrix.GetLength(0) - 1) i++; // Vertical to bottom
      else
            if (i >= j && i + j > spiralMatrix.GetLength(1) - 1) j--; // Horisontal to left
      else i--; // Vertical to top
   }
   return spiralMatrix; // Returns filled matrix
}

void PrintTwoDimArray(int[,] array) // Prints spiral array
{
   // Two nested loops to iterate 2-d array
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         Console.Write(array[i, j] + "\t"); // Prints the next array's item
      }
      Console.WriteLine(); // Rows separator
   }
}

FillSpiral(); // Mait method starts