// Lesson-03_Seminar07_Task50+. Get VALUE of the two-dim array element and print it or say there's no any

void FindElemByXYAdressInArray()
{
   int rows = 6; // Height of the table
   int columns = 7; // Width of the table

   Console.Clear();

   int lengthOfRow = rows * columns; // Length of the Fibonacci sequence to fill the table
   int[] fibonacciSequence = GenerateFibonacciUsingArray(lengthOfRow); // Generate one-dim array of Fibonacci sequence

   int[,] intTwoDimArray =
   FillFibonacciTwoDimArray(rows, columns, fibonacciSequence); // Creating a suitable two-dimensional array and filling it with the Fibonacci sequence

   PrintTwoDimArray(intTwoDimArray); // Prints array for user to choose the Fibonacci number by entering row and column

   try
   {
      string rowInvitationMessage = "Введите значение элемента массива для поиска:\n"; // Invitation message
      int findValue = InputStringToInteger(rowInvitationMessage); // Input number of rows of the array
      Console.WriteLine();

      int left = Console.CursorLeft; // Save the current left position
      int top = Console.CursorTop; // Save the current top position
      SetCursorPosition(0, 0); // Setting cursor to zero position to re-print the table with colorized chosen number
      PrintTwoDimArrayCondition(intTwoDimArray, findValue); // Re-printing the table, colorizing the chosen number
      SetCursorPosition(left, top); // Repositioning the cursor into saved position
   }
   catch
   {
      Console.WriteLine("Ошибка ввода !");
   }
}

int InputStringToInteger(string message) // Input string and convert it to integer
{
   Console.Write(message); // Print input message
   int integerNumber = int.Parse(Console.ReadLine() ?? ""); // Convert string to integer
   return integerNumber; // Return inputed number 
}

int[] GenerateFibonacciUsingArray(int lengthOfRow) // Generates Fibonacci sequence using one-dimentional array
{
   int[] array = new int[lengthOfRow]; // Declaring an array
   array[0] = 0; // First element of the sequence
   if (lengthOfRow > 1) array[1] = 1; // If the length of sequence is >1 so second element is 1 
   for (int i = 2; i < lengthOfRow; i++) // Generates elements with index >1
   {
      array[i] = array[i - 2] + array[i - 1]; // Calculate new element of the sequence
   }
   return array;
}

int[,] FillFibonacciTwoDimArray(int row, int col, int[] fibonacciSequence) // Createing two-dimentional array and filling it
{
   int[,] twoDimArray = new int[row, col]; // Declaring an array
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = fibonacciSequence[i * col + j]; // Filling two-dim array with Fibonacci numbers from one-dim array 
      }
   }
   return twoDimArray; // Return two-dim array
}

void PrintTwoDimArray(int[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 14}", twoDimArray[i, j]); // Printing element [i, j]
      }
      Console.WriteLine(); // Empty string to separate lines
   }
   Console.WriteLine(); // Empty string to separate table
}

void PrintTwoDimArrayCondition(int[,] twoDimArray, int findValue) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         if (twoDimArray[i, j] == findValue) // If it is a chosen number we should colorize the [i, j] element
         {
            Console.ForegroundColor = ConsoleColor.Red; // Set color for printing the sum 
            Console.Write("{0, 14}", twoDimArray[i, j]); // Printing chosen number in red
            Console.ResetColor(); // Resets color to default color
            return;
         }
         else Console.Write("{0, 14}", twoDimArray[i, j]); // If this number is not chosen, print it in default color
      }
      Console.WriteLine(); // Empty string to separate lines
   }
   Console.WriteLine("Чмсло не найдено");
}

void SetCursorPosition(int left, int top) // Sets cursor to the specified position
{
   Console.SetCursorPosition(left, top); // Sets cursor to the specified position 
}

FindElemByXYAdressInArray(); // The main method starts here
