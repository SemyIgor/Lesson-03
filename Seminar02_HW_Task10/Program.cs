// Seminar02_HW_Task10
// Show second digit of the input 3-digit number

Console.Clear();
Console.Write("Input 3-digit number: ");
string? inputString = Console.ReadLine();

if(inputString != null){

   
   if(inputString.Length == 3)
   {
      //               Variant I
      // Using char array
      // =====================================================
      char[] digits = inputString.ToCharArray();
      Console.WriteLine($"The second digit is {digits[1]}");
      // -----------------------------------------------------
      //               End Variant I


      //               Variant II
      // Using string as array
      // ========================================================
      // Console.WriteLine($"The second digit is {inputString[1]}");
      // --------------------------------------------------------
      //              End Variant II


      //                Variant III
      // Using char array and ASCII-code of the digit
      // ==============================================================
      // char[] digits = inputString.ToCharArray();
      // Console.WriteLine($"The second digit is {((int)digits[1] - 48)}");
      // --------------------------------------------------------------
      //                End Variant III
   }
   else
   {
      Console.WriteLine($"The number {inputString} is not 3-digit!");
   }


    //                Variant IV
      // Using numbers
      // ==============================================================
      // int inputNumber = int.Parse(inputString);
      // if(!((inputNumber / 100 < 1) || (inputNumber / 1000 > 1)))
      // {
      //    Console.WriteLine($"The second digit is {inputNumber/10%10}");
      // }
      // else
      // {
      //    Console.WriteLine($"The number {inputNumber} is not 3-digit number!");
      // }
      // --------------------------------------------------------------
      //                End Variant IV
}
