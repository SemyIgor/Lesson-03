// Seminar02_HW_Task10
// Show second digit of the input 3-digit number

Console.Clear();
Console.Write("Input 3-digit number: ");
string? inputString = Console.ReadLine();

// Variant I Using char array
void VariantI(string inputStr)
{
   char[] digits = inputStr.ToCharArray();
   Console.WriteLine("Variant I Using char array");
   Console.WriteLine($"The second digit is {digits[1]}");
}

// Variant II Using string as array
void VariantII(string inputStr)
{
   Console.WriteLine("Variant II Using string as array");
   Console.WriteLine($"The second digit is {inputStr[1]}");
}

// Variant III Using char array and ASCII-code of the digit
void VariantIII(string inputStr)
{
   char[] digits = inputString.ToCharArray();
   Console.WriteLine("Variant III Using char array and ASCII-code of the digit");
   Console.WriteLine($"The second digit is {((int)digits[1] - 48)}");
}

// Variant IV Using numbers
void VariantIV(string inputStr)
{
   Console.WriteLine("Variant IV Using numbers");
   int inputNumber = int.Parse(inputStr);
   if(!((inputNumber / 100 < 1) || (inputNumber / 1000 > 1)))
   {
      Console.WriteLine($"The second digit is {inputNumber/10%10}");
   }
   else
   {
      Console.WriteLine($"The number {inputNumber} is not 3-digit number!");
   }

}

if(inputString != null){
   if(inputString.Length == 3)
   {
      VariantI(inputString);

      VariantII(inputString);

      VariantIII(inputString);
   }
   else
   {
      Console.WriteLine("VariantI, VariantII and VariantIII");
      Console.WriteLine($"The number {inputString} is not 3-digit!");
   }

   VariantIV(inputString);
}
