// Show all whole numbers from -inputNumber to +inputNumber

//              Variant I
// One line shorter, then Variant II
// =======================================================
// Console.Write("Введите любое натуральное число: ");
// string? inputString = Console.ReadLine();

// if(inputString != null)
// {
//    int inputNumber = int.Parse(inputString);
//    int counter = -1 * inputNumber;
//    string? result = "" + counter;
//    while(counter < inputNumber)
//    {
//       counter++;
//       result = result + ", " + counter;
//    }
//       Console.WriteLine(result);
// }
// -------------------------------------------------------
//            End Variant I


//              Variant II
// =======================================================
// string? inputLineOne = Console.ReadLine();

// if(inputLineOne != null)
// {
//    int inputNumber = int.Parse(inputLineOne);
//    int startNumber = (inputNumber * -1);
//    string lineOutput = "";
//    while (startNumber < inputNumber)
//    {
//       lineOutput = lineOutput + startNumber + ", ";
//       startNumber++;
//    }
//    lineOutput = lineOutput + inputNumber;
//    Console.WriteLine(lineOutput);
// }
// -------------------------------------------------------
//            End Variant II

//              Variant III
// =======================================================
string? inputLineOne = Console.ReadLine();

if(inputLineOne != null)
{
   int inputNumber = int.Parse(inputLineOne);
   int startNumber = 1;
   string lineOutput = "0";
   while (startNumber <= inputNumber)
   {
      lineOutput = startNumber*(-1) + ", " + lineOutput + ", " + startNumber;
      startNumber++;
   }
   Console.WriteLine(lineOutput);
}
// -------------------------------------------------------
//            End Variant III