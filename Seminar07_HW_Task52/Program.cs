// Lesson-03_Seminar07_HW_Task52. Generate integer two-dim array, calculate the average of every column

void ArrayColumnsCalcAveage() // The Main metod
{
   int rows = 20; // Height of the matrix
   int columns = 12; // Width of the matrix
   int minRange = 5; // Min Value of elements
   int maxRange = 25; // Max Value of elements

   Console.Clear();

   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minRange, maxRange); // Generates two-dimentional array

   PrintTwoDimArray(intTwoDimArray); // Print two-dimentional array

   double[] AverageColumnsArray = CalcAverageForColumns(intTwoDimArray); // Calculating average of columns of the two-dim array and saving them in new one-dim array
   PrintArray(AverageColumnsArray); // Print new array of averages

}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Generate the next element of the two-dimentional array
      }
   }
   return twoDimArray; // Return generated two-dimentional array
}

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 6}", twoDimArray[i, j]); // Printing element [i, j]
      }
      Console.WriteLine(); // Empty string to separate lines
   }
   Console.WriteLine(); // Empty string to separate table
}

double[] CalcAverageForColumns(int[,] twoDimArray) // Calculating the averages of the columns and save them to one-dim array 
{
   int twoDimArrayRows = twoDimArray.GetLength(0); // Saving the number of rows of given two-dim array to the variable
   int twoDimArrayColumns = twoDimArray.GetLength(1); // Saving the number of columns of given two-dim array to the variable
   double columnSum = 0; // Creating the variable to accumulate the sum of the column

   double[] resultArray = new double[twoDimArrayColumns]; // Creating new one-dim array for saving averages

   for (int j = 0; j < twoDimArrayColumns; j++) // Iteration of the columns
   {
      columnSum = 0;
      for (int i = 0; i < twoDimArrayRows; i++) // Iteration of the rows
      {
         columnSum += twoDimArray[i, j]; // Accumulating sum of the column
      }
      resultArray[j] = Math.Round((columnSum / twoDimArrayRows), 2); // Calculating average, round it and save to one-dim array
   }
   return resultArray; // Returning the array of averages
}

void PrintArray(double[] array) // Print given array
{
   int i = 0;
   while (i < array.Length/* - 1*/) // Print elements and commas, but not last element
   {
      Console.ForegroundColor = ConsoleColor.Red; // Set color for printing the sum 
      Console.Write("{0,6}", array[i]);
      Console.ResetColor(); // Resets color to default color
      i++;
   }
}

ArrayColumnsCalcAveage(); // The main method starts
