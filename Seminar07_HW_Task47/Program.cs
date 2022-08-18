// Generate a two-dimensional array of the required sizes with real numbers
// * Colorize every digit of it's elements

void GenerateFloatTwoDimArray()
{
   // int rows = 20; // Height of the matrix
   // int columns = 15; // Width of the matrix
   double minValue = 0; // Min Value of elements
   double maxValue = 21; // Max Value of elements

   Console.Clear();

   string rowInvitationMessage = "Введите количество строк таблицы:\n"; // Invitation message
   int rows = InputStringToInteger(rowInvitationMessage); // Input number of rows of the array

   string ColInvitationMessage = "Введите количество столбцов таблицы:\n"; // Invitation message
   int columns = InputStringToInteger(ColInvitationMessage); // IInput number of columns of the array

   double[,] generateTwoDimArray = DoubleGenerateTwoDimArray(rows, columns, minValue, maxValue);
   PrintTwoDimArray(generateTwoDimArray);

}

double[,] DoubleGenerateTwoDimArray(int row, int col, double minValue, double maxValue) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   double[,] twoDimArray = new double[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         // twoDimArray[i, j] = randomSintezator.Next(min, max);

         twoDimArray[i, j] = randomSintezator.NextDouble() *
         (maxValue + 1 - minValue); // Generates next random element
         twoDimArray[i, j] = Math.Round(twoDimArray[i, j], 2); // Round value to two digits
      }
   }
   return twoDimArray;
}

void PrintTwoDimArray(double[,] twoDimArray) // Print two-dimentional array
{
   // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 7}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

int InputStringToInteger(string message) // Input string and convert it to integer
{
   Console.Write(message); // Print input message
   int integerNumber = int.Parse(Console.ReadLine() ?? ""); // Convert string to integer
   return integerNumber; // Return inputed number 
}

GenerateFloatTwoDimArray();