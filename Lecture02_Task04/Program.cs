// Lecture02_Task04 (Task11). 

int arraySize = 20;  // We'll be finding number in the array dimensioned arraySize
int numberToFind = 14;   // Number we're finding
void FillArray(int[] collection) // Creating method to fill array (argument = collection) with random numbers
{
   int length = collection.Length;
   int index = 0;
   
   while(index < length)
   {
      collection[index] = new Random().Next(1, arraySize);
      index++;
   }
}

void PrintArray(int[] col)       // Creating method to print array (argument = col) to console
{
   int count = col.Length;
   int position = 0;
   while(position < count)
   {
      Console.WriteLine(position + "--" + col[position]);  
      position++;
   }
}

int IndexOf(int[] collection, int find) // Method to find index of element with the value 'find' in array 'collection'
{
   int count = collection.Length;
   int index = 0;    // Index for cycling through array 'collection'
   int position = -1; // For saving found element's index (-1 used to recognize the empty search result)

   while(index < count)
   {
      if(collection[index] == find)
      {
         position = index;
         break; //Leaving cycling if we've found the number first time (in case there are two equals)
      }
      index++;
   }
   return position;
}

int[] array = new int[arraySize]; // Creating array

// Call methods FillArray and PrintArray to do their work
FillArray(array);          // Filling array with random numbers
PrintArray(array);         // Array output
Console.WriteLine(); // To separate array's output by empty line

int pos = IndexOf(array, numberToFind);
Console.WriteLine("position = " + pos);

if(pos != -1)  // Checking if there's no such a number in the array
{
Console.WriteLine(numberToFind + " is in the " + pos + " position");
}
else
{
Console.WriteLine("There is no " + numberToFind + " in this array");
}