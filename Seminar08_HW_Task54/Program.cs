// Lesson-03_Seminar08_HW_Task54. Descending sort of every row of the two-dim array
// 
void SortRowsOfArray()
{
   int rows = 8;
   int columns = 10;
   int minValue = 10;
   int maxValue = 99;

   Console.Clear();
   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generates two-dim init array

   Console.WriteLine("Сгенерированный не отсортированный массив");
   PrintTwoDimArray(initArray); // Prints unsorted initial array
   Console.WriteLine(); // Separating row

   Console.WriteLine("Отсортированный массив");
   SortRowsTwoDimArray(initArray); // Descending sorting rows of the initial array
   PrintTwoDimArray(initArray); // Prints descending sorted initial array
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

int[,] SortRowsTwoDimArray(int[,] twoDimArray) // Descending sorting rows of the initial array
{
   int columns = twoDimArray.GetLength(1);
   int rows = twoDimArray.GetLength(0);

   int[] tmpArray = new int[columns]; // Creating temp one-dim array 

   for (int i = 0; i < rows; i++)
   {
      // Copying i-array's row to the temp array
      for (int j = 0; j < columns; j++)
      {
         tmpArray[j] = twoDimArray[i, j];
      }
      // Sorting temp Array (containing i-row of the initial array)
      tmpArray = SelectionSort(tmpArray);

      // Copying temp array to the i-array's row
      for (int j = 0; j < columns; j++)
      {
         twoDimArray[i, j] = tmpArray[j];
      }
   }
   return twoDimArray; // Returns sorted array
}

int[] SelectionSort(int[] array) // Sorts given array with selection sort method
{
   int[] sortedArray = new int[array.Length];
   array.CopyTo(sortedArray, 0); // Copy of the initial array

   int arrayLength = array.Length; // Save array length in the variable
   int k; // Initiates marking index
   int minUnsortedItem; // Minimum unsorted array item
   for (int i = 0; i < arrayLength; i++)
   {
      k = i; // Marking index
      minUnsortedItem = sortedArray[i];
      for (int j = i + 1; j < arrayLength; j++)
      {
         if (sortedArray[k] < sortedArray[j]) // If use "<", we will have descending sort order
         {
            k = j;
         }
      }
      sortedArray[i] = sortedArray[k]; // Fixating the next sorted position
      sortedArray[k] = minUnsortedItem; // Moving marking index to the next unsorted position
   }
   return sortedArray;
}

SortRowsOfArray();