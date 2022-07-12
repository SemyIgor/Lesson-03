// Lecture02_Task03 (Task10). Find array index of the given number 

int[] array = {1,12,31,4,18,15,16,17,18};
int arrayLength = array.Length;

int numberToFind = 18;

int arrayIndex = 0;

while(arrayIndex < arrayLength)
{
   if(array[arrayIndex] == numberToFind)
   {
      Console.WriteLine(arrayIndex);
      break;
   }
   arrayIndex++;
}

// Console.WriteLine(arrayLength);
