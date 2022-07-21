// Lecture03_Task02-dop. The Selection Sorting method algorithm (move maximum element)

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

Console.Clear();

void PrintArray(int[] array)
{
   int count = array.Length;
   for (int i = 0; i < count; i++)
   {
      Console.Write($"{array[i]} ");
   }
   Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for (int i = array.Length - 1; i >= 0; i--)
   {
      int maxPosition = i;
      for (int j = i - 1; j > 0; j--)
      {
         if (array[j] > array[maxPosition]) maxPosition = j;
      }
      int temporary = array[i];
      array[i] = array[maxPosition];
      array[maxPosition] = temporary;
   }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);


