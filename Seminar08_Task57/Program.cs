// Lesson-03_Seminar08_Task57. Frequency vocabulary
// 
// 1. Создать массив
// 2. Напечатать массив для наглядности
// 3. Создать одномерный массив алфавита с частотной раскладкой каждой "буквы"
//    - Выбрать элементы 2-d массива в одномерный массив, где индексы - диапазон значений 2-d массива
//      от 0 (сместив диапазон индексов к нулю путём вычитания из каждого индекса / значения величины min значений) 
//      расположенные по возрастанию до значения последнего индекса, равного max - min, где значения элементов - 
//      это количество появлений этого значения в исходном 2-d массиве, то есть из массива:
//      [1, 3, 2, 2]
//      [3, 1, 5, 8] => [0,1,2,3,4,5,6,7,8] - индексы создаваемого 2-d массива
//      [5, 2, 3, 0]    [1,2,3,3,-,2,-,-,1] - значения создаваемого 2-d массива (сумма элементов равна количеству 
//      элементов 2-d массива, в данном случае 1+2+3+3+0+2+0+0+1 = 12). 
//      Для упрощения в 2-d массиве присутствует минимальное значение элемента, равное 0. Если бы было иное число, то из всех 
//      значений 2-d массива потребовалось бы для создания индексов 1-d массива вычесть из всех значений этот минимум,
//      чтобы всегда получался ряд от 0 до max-min. Это связано с тем, что индексация массива должна начинаться с 0.
//      Надо помнить, что после получения результата, все "буквы" алфавита следует увеличить на min, вернув им прежние значения.
//      Как вариант, можно не менять эти значения, но в новом массиве будут пустые элементы от 0 до min, что увеличит массив.
//      
// 4. Сократить массив, удалив пустые элементы. В результате должно получиться:
//      [1, 3, 2, 2]
//      [3, 1, 5, 8] => [0,1,2,3,4,5,6,7,8] => [0,1,2,3,5,8]
//      [5, 2, 3, 0]    [1,2,3,3,-,2,-,-,1] => [1,2,3,3,2,1]

void ExchangeTwoDimArrayElements() // Main method
{
   int rows = 4; // Number of rows 
   int columns = 5; // Number of columns
   int minValue = 0; // Minimal value of the array item
   int maxValue = 9; // Maximum value of the array item

   Console.Clear();

   int[,] initArray = IntGenerateTwoDimArray(rows, columns, minValue, maxValue); // Generates array
   PrintTwoDimArrayColor(initArray); // Prints array
   Console.WriteLine(); // Separating string

   int[,] abcArray = CreateABC(initArray, minValue, maxValue); // Creates the array of frequences
   PrintTwoDimArrayColor(abcArray); // Prins the array of frequences

   // CutZeroItems(abcArray); // Delete empty array items
}

int[,] IntGenerateTwoDimArray(int row, int col, int min, int max) // Generate two-dimentional array
{
   System.Random randomSintezator = new Random();
   int[,] twoDimArray = new int[row, col]; // Declares the array 
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         twoDimArray[i, j] = randomSintezator.Next(min, max); // Fills next array's item
      }
   }
   return twoDimArray; // Returns array
}

int[,] CreateABC(int[,] twoDimArray, int min, int max) // Creates the array of vocabulary
{
   int columns = twoDimArray.GetLength(1);
   int rows = twoDimArray.GetLength(0);
   int range = (max - min); // Range of the array's items
   int vocRows = 2; // Set two lines of ABC - the line of "latters" and the line of frequencies of the "letters"
   int[,] abcArray = new int[vocRows, range]; // Declares the array of vocabulary

   // Fills two-dim array of vocabulary
   for (int i = 0; i < rows; i++) // Iterating the two-dim array's rows
   {
      for (int j = 0; j < columns; j++) // Iterating the two-dim array's columns
      {
         abcArray[0, twoDimArray[i, j]] = twoDimArray[i, j]; // Forms the row of "letters"
         abcArray[1, twoDimArray[i, j]]++; // Forms the row of frequences of the "letters"
      }
   }
   return abcArray;
}

void PrintTwoDimArrayColor(int[,] twoDimArray) // Print two-dimentional array
{
   for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
   {
      for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
      {
         Console.Write("{0, 3}", twoDimArray[i, j]); // Prints array item
      }
      Console.WriteLine(); // Empty string to separate lines
   }
}

ExchangeTwoDimArrayElements(); // Main method starts here


// МОДИФИЦИРОВАТЬ
// int[,] CutZeroItems(int[,] twoDimArray) // Remove empty array items
// {
//    List<int>[,] tempArray = new List<int>[2, twoDimArray.GetLength(1)];
//    int j = 0;
//    for (int i = 0; i < twoDimArray.GetLength(1); i++)
//    {

//       if (twoDimArray[1, i] != 0)
//       {
//          tempArray.Add(twoDimArray[0, i]);
//          // tempArray[1, j].Add(twoDimArray[1, i]);
//          j++;
//          Console.Write("Буква = {0}; Частота = {1}", tempArray[0, i], tempArray[1, i]);
//          Console.WriteLine();
//       }
//    }
//    Console.WriteLine("Длина алфавита = {0}", tempArray.GetLength(1));
//    return twoDimArray;
// }


// void PrintTwoDimArrayColor(int[,] twoDimArray) // Print two-dimentional array
// {
//    // Console.ForegroundColor = ConsoleColor.Yellow; // Changes color of the text in console
//    for (int i = 0; i < twoDimArray.GetLength(0); i++) // Rows
//    {
//       for (int j = 0; j < twoDimArray.GetLength(1); j++) // Columns
//       {
//          // Checks if the item is located on the second main diagonal and changes it's color if so
//          if ((i + j) == (twoDimArray.GetLength(0) - 1))
//          {
//             Console.ForegroundColor = ConsoleColor.Blue; // Changes color of the text in console
//             Console.Write("{0, 3}", twoDimArray[i, j]); // Prints array's item
//             Console.ResetColor(); // Resets color to default color
//          }
//          // If its not the second main diagonal prints item without changing the color
//          else Console.Write("{0, 3}", twoDimArray[i, j]);
//       }
//       Console.WriteLine(); // Empty string to separate lines
//    }
// }