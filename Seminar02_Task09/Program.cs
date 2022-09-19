// Seminar02_Task09. Creates random number in range 10 - 99 and finds biggest digit in it

//                 Variant I ( With numbers ) 
void VariantI(System.Random numberSintezator)
{
   // System.Random numberSintezator = new Random();  // System.Random - it's a variable's type wich can not be deleted _
                                                   // by garbage collector
                                                   // Random() - it's a Class
                                                   // new Random() - it's an Object, created by applying Class 'Random' 
                                                   // numberSintezator - it's an Object too, and it has some methods _
   int number = numberSintezator.Next(10,100);     // ( method Next(), for example )
   Console.WriteLine("Random number = " + number);

   int firstDigit = number / 10;
   int secondDigit = number % 10;

   if(firstDigit > secondDigit)
   {
      Console.WriteLine("Biggest digit is: " + firstDigit); // WriteLine() is a method too _
   }                                                        // and Console is a Class / Method
   else
   {
      Console.WriteLine("Biggest digit is: " + secondDigit);
   }
// -------------------------------------------------------------------------------------------------
//                End Variant I
}

//                 Variant II  ( Kirill's )
// Turns random number into string and compares two elements of the string (as a characters)
void VariantII(System.Random numberSintezator)
{
   int randomNum = numberSintezator.Next(10, 100);
   Console.Write("The random number is: ");
   Console.WriteLine(randomNum);

   string stringNum = randomNum.ToString();
   Console.Write("The biggest digit is: ");
   if(stringNum[0] > stringNum[1])
   {
      Console.WriteLine(stringNum[0]);
   }
   else
   {
      Console.WriteLine(stringNum[1]);
   }
// -------------------------------------------------------------------------------------------------
//                End Variant II
}

//                 Variant III ( Char array with explanations )
void VariantIII(System.Random numberSintezator)
{
int randomNumber = numberSintezator.Next(10, 100);

char[] digits = randomNumber.ToString().ToCharArray();
Console.WriteLine("Random namber = " + randomNumber);   // Printing random number (example: 57)

//               /* EXPLANATIONS of the method: NUMBER -> STRING -> CHARACTARS -> DIGITS */
//               /* You can uncomment every string in bellow list to watch the result of it's work */
// Console.WriteLine(randomNumber.ToString());  // Printing random string (example: "57")
// Console.WriteLine(randomNumber.ToString().ToCharArray());  // Printing random char array (example:array of characters {5, 7})
//  Console.WriteLine(digits[0]);      // Printing element [0] of the char array (example: 5)
//  Console.WriteLine(digits[1]);      // Printing element [1] of the char array (example: 7)
// Console.WriteLine((int)digits[0]);    // Printing element's [0] ASCII - code as integer (example: 53)
// Console.WriteLine((int)digits[1]);    // Printing element's [1] ASCII - code as integer (example: 55)
//  Console.WriteLine((int)digits[0]-48);    // Converting element's [0] ASCII - code as integer into integer digit (example: 5)
//  Console.WriteLine((int)digits[1]-48);    // Printing element's [1] ASCII - code as integer into integer digit (example: 7)
//                           /* End of the EXPLANATIONS */

int firstDigit = ((int)digits[0]-48);  // Converting character into integer number (examle: char 5 -> int 5) 
int secondDigit = ((int)digits[1]-48);  // Converting character into integer number (examle: char 7 -> int 7)  

int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
Console.WriteLine("Max digit = " + maxDigit);
// ---------------------------------------------------------------------------------------------------
//                   End Variant III 
}

Console.Clear();

System.Random numberSintezator = new Random();

VariantI(numberSintezator);

VariantII(numberSintezator);

VariantIII(numberSintezator);