// Lesson-03_Seminar08_HW_Task56. Generate array, find the row with the minimum sum of array's items 

void FindRowWithMinSum()
{
   int rows = 8;
   int columns = 10;
   int minValue = 10;
   int maxValue = 99;

   Console.Clear();
   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generates two-dim init array

   PrintTwoDimArray(initArray); // Prints unsorted initial array

   int minSumRowIndex = FindMinSumIndex(initArray, maxValue); // Finds the index of the row with the minimum sum of items
   Console.WriteLine("   Минимальная сумма найдена в строке № {0}", minSumRowIndex);
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

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 5}", twoDimArray[i, j]); // Printing one next array item
      }
      Console.WriteLine(); // Empty string to separate rows
   }
}

int CalcSumOfRow(int[,] twoDimArray, int rowIndex) // Calculating the sum of the array's items in one row
{
   int columns = twoDimArray.GetLength(1);
   int sum = 0;
   for (int j = 0; j < columns; j++)
   {
      sum = sum + twoDimArray[rowIndex, j];
   }
   return sum; // Returns sum of the row
}

int FindMinSumIndex(int[,] twoDimArray, int maxValue) // Finds minimum sum of the rows and the index of this row
{
   int columns = twoDimArray.GetLength(1);
   int rows = twoDimArray.GetLength(0);

   int sum = 0;
   int minSum = maxValue * columns; // Using maximum possible value not to get this abstract number as minimum
   int indexRowMinSum = 0; // initial value of the row with the minimum sum

   for (int i = 0; i < rows; i++) // Iterates rows
   {
      sum = CalcSumOfRow(twoDimArray, i); // Calculates the sum of the elements in the i-row

      // Finds minimum sum of the row and the number of this row
      if (sum < minSum)
      {
         minSum = sum;
         indexRowMinSum = i;
      }
   }
   Console.WriteLine("   Минимальная сумма найденной строки равна {0}", minSum);
   return indexRowMinSum; // Returns the index of the found row
}

FindRowWithMinSum();