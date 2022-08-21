// Lesson-03_Seminar07_Task49. Generate two-dim array and square it's elements with both even indexes

void ChangeTwoDimArrayElements()
{
   int rows = 10;
   int columns = 14;
   int minRange = 0;
   int maxRange = 21;

   Console.Clear();

   Console.WriteLine("Сгенерированный массив, элементы с чётными индексами выделены");
   // PrintTwoDimArray(intTwoDimArray); // Print two-dimentional array
   int[,] intTwoDimArray =
   IntGenerateTwoDimArray(rows, columns, minRange, maxRange); // Generate two-dimentional array
   ColorMarkArrayChanges(intTwoDimArray);
   Console.WriteLine();

   Console.WriteLine("Элементы с чётными индексами возведены в квадрат, выделены");
   int[,] changedArray = ChangeElementsByRule(intTwoDimArray);
   ColorMarkArrayChanges(changedArray);
   Console.WriteLine();
}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col];
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max);
      }
   }
   return twoDimArray;
}

int[,] ChangeElementsByRule(int[,] twoDimArray)
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         if ((i % 2 == 0) && (j % 2 == 0))
         {
            twoDimArray[i, j] = twoDimArray[i, j] * twoDimArray[i, j];
         }
      }
   }
   return twoDimArray;
}

ConsoleColor[] col = new ConsoleColor[]{ConsoleColor.Black,ConsoleColor.Blue, ConsoleColor.Cyan,
               ConsoleColor.DarkBlue, ConsoleColor.DarkCyan, ConsoleColor.DarkGray, ConsoleColor.DarkGreen, ConsoleColor.DarkMagenta, ConsoleColor.DarkRed, ConsoleColor.DarkYellow, ConsoleColor.Gray, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Yellow};

void ColorMarkArrayChanges(int[,] twoDimArray)
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         if ((i % 2 == 0) && (j % 2 == 0))
         {
            Console.ForegroundColor = ConsoleColor.Red; // %16 use for keeping color in range 0 - 15 
            Console.Write("{0, 5}", twoDimArray[i, j]);
            Console.ResetColor(); // Resets color to default color
         }
         else Console.Write("{0, 5}", twoDimArray[i, j]);
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

ChangeTwoDimArrayElements();



// void ColorPrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
// {
//    System.Random randomSintezator = new Random();
//    Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
//    for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
//    {
//       for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
//       {
//          Console.ForegroundColor = ConsoleColor.Red;
//          Console.Write("{0, 5}", twoDimArray[i, j]);
//          Console.ResetColor(); // Resets color to default color
//       }
//       Console.WriteLine(); // Empty string to separate lines
//    }
// }

// void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
// {
//    Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
//    for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
//    {
//       for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
//       {
//          Console.Write("{0, 5}", twoDimArray[i, j]);
//       }
//       Console.WriteLine(); // Empty string to separate lines
//    }
// }