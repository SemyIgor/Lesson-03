// Seminar02_HW_Task13
// Check if there's a third digit in the input number, output it's third digit if it is, _
// or print message that there's no 3rd digit if it is not

Console.Clear();

// Recursive method
int div10(int number)
{
   if(number < 1000) return number%10;
   return div10(number / 10);
}

// Variant I Using char array
void VariantI(string inputStr)
{
// Enter string of digits, turn it into char array, check if it's length 
// is not less then 3 and output array element with index = 2
// =====================================================================
Console.WriteLine("VariantI Using char array");

char[] inputArray = inputStr.ToCharArray();
if(inputArray.Length >= 3)
   {
      Console.WriteLine("Третья цифра введенного числа = " + inputArray[2]);
   }
else
   {
      Console.WriteLine("Здесь нет третьей цифры");
   }
}

// Variant II Using numbers
void VariantII(string inputStr)
{
// Input string of digits and turn it into integer. Then check if the
// number has less then 3 digits (<100) and output message line if so.
// Using ternar operator check if the number's length has more then 2 digits, 
// using recursive method to find it's 3rd digit
// ======================================================================
   Console.WriteLine("VariantII Using numbers");
   int inputNumber = Convert.ToInt32(inputStr);

   string noThirdDigit = $"There's no third digit in {inputNumber}";
   string isThirdDigit = $"The third digit in {inputNumber} is {div10(inputNumber).ToString()}";

   string result = (inputNumber < 100) ? noThirdDigit : isThirdDigit;
   Console.WriteLine(result);
}

Console.Write("Введите целое число: ");
string? inputString = Console.ReadLine();
if(inputString != null)
{
   VariantI(inputString);

   VariantII(inputString);
}



