// Lesson-03_Seminar07_Task47+. Generate a two-dimensional array of the required sizes with real numbers
// * Colorize every digit of it's elements

void GenerateFloatTwoDimArray()
{
   double minValue = 5; // Min Value of elements
   double maxValue = 25; // Max Value of elements

   Console.Clear();

   string rowInvitationMessage = "Введите количество строк таблицы:\n"; // Invitation message
   int rows = InputStringToInteger(rowInvitationMessage); // Input number of rows of the array

   string ColInvitationMessage = "Введите количество столбцов таблицы:\n"; // Invitation message
   int columns = InputStringToInteger(ColInvitationMessage); // Input number of columns of the array

   double[,] generateTwoDimArray = DoubleGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generate two-dim array
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
         twoDimArray[i, j] =
         minValue +
         randomSintezator.NextDouble() *
         (maxValue - minValue); // Generates next random element in range from minValue to maxValue
         twoDimArray[i, j] = Math.Round(twoDimArray[i, j], 4); // Round value to four digits
      }
   }
   return twoDimArray; // return array
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue, ConsoleColor.Cyan,
               ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

void PrintTwoDimArray(double[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         PrintColorizedRealNumber(twoDimArray[i, j]);
         Console.Write("  ");
         // Console.Write("{0, 9}", twoDimArray[i, j]); // Print the next element
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

void PrintColorizedRealNumber(double arrayElem) // Colorize one real number element of the two-dim array
{
   System.Random randomGenerator = new Random();
   string stringElem = Convert.ToString(arrayElem); // Converting real number to string
   for (int i = 0; i < stringElem.Length; i++) // Iterating digits of the string (digits of one element)
   {
      Console.ForegroundColor = col[randomGenerator.Next(0, 15)]; // Set color for printing the sum 
      Console.Write(stringElem[i]); // Printing one colorized digit
      Console.ResetColor(); // Resets color to default color
   }
   Console.Write(new string(' ', 9 - stringElem.Length)); // Aligning the number in column
}

int InputStringToInteger(string message) // Input string and convert it to integer
{
   Console.Write(message); // Print input message
   int integerNumber = int.Parse(Console.ReadLine() ?? ""); // Convert string to integer
   return integerNumber; // Return inputed number 
}



GenerateFloatTwoDimArray(); // Starts main method