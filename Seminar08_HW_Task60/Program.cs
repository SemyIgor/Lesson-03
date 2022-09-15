// Lesson-03_Seminar08_HW_Task60. Generate 3-d array of non-repeating two-digit items
// and print it out with their indexes
// 
// Сформируйте трёхмерный массив из неповторяющихся двухзначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2х2х2:
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

void GenerationThreeDimArray()
{
   System.Random randomSintezator = new System.Random();
   // Matrix A dimensions
   int firstDim = randomSintezator.Next(3, 5); // Generates the first dimention of the 3-d array
   int secondDim = randomSintezator.Next(3, 5); // Generates the second dimention of the 3-d array
   int thirdDim = randomSintezator.Next(3, 5); // Generates the third dimention of the 3-d array

   Console.WriteLine("{0} x {1} x {2}", firstDim, secondDim, thirdDim); // Prints dimentions

   // Range of the matrix items values
   int minValue = 10;
   int maxValue = 99;

   string valueSize = "2"; // Sets the printing field's size equal to the maximum possible size of the item's value
   string gapSize = " "; // Sets the gap while printing elements of array

   int[,,] threeDimArray = GenThreeDimArray(firstDim, secondDim, thirdDim); // Creats 3-d array
   threeDimArray = FillThreeDimArray(threeDimArray, minValue, maxValue); // Fills 3-d array

   PrintThreeDimArray(threeDimArray, valueSize, gapSize); // Prints 3-d array
}

// Creats 3-d array
int[,,] GenThreeDimArray(int firstDim, int secondDim, int thirdDim)
{
   int[,,] threeDimArray = new int[firstDim, secondDim, thirdDim];
   return threeDimArray;
}

// Fills 3-d array with non-repeating two-digit items
int[,,] FillThreeDimArray(int[,,] threeDimArray, int minValue, int maxValue)
{
   System.Random randomSintezator = new System.Random();
   List<int> tempArray = new List<int>(); // Creats temp array to exclude repeating items
   int temp; // Creats temp variable to exclude repeating items

   // Three nested loops to iterate 3-d array
   for (int i = 0; i < threeDimArray.GetLength(0); i++)
   {
      for (int j = 0; j < threeDimArray.GetLength(1); j++)
      {
         for (int k = 0; k < threeDimArray.GetLength(2); k++)
         {
            temp = randomSintezator.Next(minValue, maxValue + 1); // Generate temp variable
            while (tempArray.Contains(temp)) // While temp array contains the generated variable...
            {
               temp = randomSintezator.Next(minValue, maxValue + 1); // ... generates new variable
            }
            threeDimArray[i, j, k] = temp; // Puts non-repeating temp variable to the 3-d array
            tempArray.Add(temp); // Puts temp variable to the temp array to mark the value is used
         }
      }
   }
   return threeDimArray;
}

// Prints the 3-d array using strict format
void PrintThreeDimArray(int[,,] threeDimArray, string valueSize, string gapSize)
{
   // Sets index component and alignment component for printing
   valueSize = "{0, " + valueSize + "}";

   // Three nested loops to iterate 3-d array
   for (int i = 0; i < threeDimArray.GetLength(0); i++)
   {
      for (int j = 0; j < threeDimArray.GetLength(1); j++)
      {
         for (int k = 0; k < threeDimArray.GetLength(2); k++)
         {
            // Prints the array item with it's dimentions in the demanded format
            Console.Write(valueSize + "({1},{2},{3})" + gapSize, threeDimArray[i, j, k], i, j, k);
         }
         Console.WriteLine(); // Empty string to separate rows
      }
      Console.WriteLine(); // Empty string to separate rows
   }
   Console.WriteLine(); // Empty string to separate rows
}

GenerationThreeDimArray();