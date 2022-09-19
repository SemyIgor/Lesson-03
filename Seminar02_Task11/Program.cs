// Seminar02_Task11. Generates random 3-digit number and converts it into 2-digit by removing it's 2nd digit

Console.Clear();
System.Random numGenerator = new Random(); 

//             Variant I (numbers)
// ========================================================================
void VariantI(System.Random numGenerator)
{
   int randomNum = numGenerator.Next(100, 1000);
   Console.WriteLine("Variant I");
   Console.WriteLine($"Random number = {randomNum}");
   int transNumber = randomNum / 100 * 10 + randomNum % 10; // Example: 456/100*10 = 40; 456%10 = 6; 40+6 = 46
   Console.WriteLine($"Transformed number = {transNumber}");
// ------------------------------------------------------------------------
//               End Variant I
}

//             Variant II (string)
// ========================================================================
void VariantII(System.Random numGenerator)
{
   Console.WriteLine("Variant II");
   int randomNum = numGenerator.Next(100, 1000);
   Console.WriteLine($"Random number = {randomNum}");
   string randomStr = randomNum.ToString();
   Console.WriteLine($"Transformed number = {randomStr[0]}{randomStr[2]}");
// ------------------------------------------------------------------------
//               End Variant II
}

//             Variant III (char)
// ========================================================================
void VariantIII(System.Random numGenerator)
{
   Console.WriteLine("Variant III");
   int randomNum = numGenerator.Next(100, 1000);
   Console.WriteLine($"Random number = {randomNum}");
   char[] randomChar = randomNum.ToString().ToCharArray();
   Console.WriteLine($"Transformed number = {randomChar[0]}{randomChar[2]}");
// ------------------------------------------------------------------------
//               End Variant III
}

VariantI(numGenerator);
VariantII(numGenerator);
VariantIII(numGenerator);