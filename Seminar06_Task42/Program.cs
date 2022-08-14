// Lesson-03_Seminar06_Task42. Converts decimal number into binary number
// 
// Conditions:
// The task is to convert decimal number into binary number
// 
// Algorithms:
// 1. Input decimal number
// 2. Convert decimal number into binary one (two variants of conversion)
// 3. Print binary number

void ConvertDecToBin()
{
   // Console.Clear();
   // Block of messages
   // -------------------------------------------------------------------------------------
   string inputMessage = "Введите десятичное число:\n"; // Invitation message
   string outputMessage = "To be continued";
   // -------------------------------------------------------------------------------------

   string enteredString = InputString(inputMessage); // Inviting message and receiving string

   OutputString(DecToBinPrototype(enteredString)); // Variant I
   OutputString(DecToBinClassic(enteredString));   // Variant II
}

string InputString(string message) // Enter string 
{
   Console.Write(message);
   string inputedString = Console.ReadLine() ?? ""; // Enter string
   return inputedString; // Return result input string
}

string DecToBinPrototype(string enteredString) // The String of a decimal number to the string of a binary one 
{
   string binNumber = Convert.ToString(int.Parse(enteredString), 2); // 2 - binary, 8 - octal, 16 - hexadecimal
   return binNumber;
}

string DecToBinClassic(string enteredString) // Converting decimal number to binary by devision by 2
{
   string binNumber = ""; // Binary number accumulates to this string
   int decNumber = int.Parse(enteredString); // Converts entered string to integer
   while (decNumber > 0) // Cycling devision by 2 to receive remainder to accumulate it in binNumber as string
   {
      binNumber = ((decNumber % 2) == 1) ? "1" + binNumber : "0" + binNumber; // one step of the accumulation
      decNumber /= 2; // Result of devision by 2 to be divided by 2 again in cycle
   }
   return binNumber; // Returns result string of binary number
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message);
}

ConvertDecToBin();