// Create two-dim array [m,n], each element is m+n.
// * Colorise elements
void ColorTwoDimArray()
{
   int rows = 10;
   int columns = 14;
   int minRange = 0;
   int maxRange = 100;

   Console.Clear();
   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minRange, maxRange); // Generate two-dimentional array
   PrintTwoDimArray(intTwoDimArray); // Print two-dimentional array
   ColorPrintTwoDimArray(intTwoDimArray); // Color print two-dimentional array

}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{

   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = i + j;
      }
   }
   return twoDimArray;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue, ConsoleColor.Cyan,
               ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 3}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

void ColorPrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   System.Random randomSintezator = new Random();
   Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.ForegroundColor = col[(i + j) % 16]; // %16 use for keeping color in range 0 - 15 
         Console.Write("{0, 3}", twoDimArray[i, j]);
         Console.ResetColor(); // Resets color to default color
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

ColorTwoDimArray();