//                Variant I
// =======================================================
// Console.Write("Введите первое число: ");
// string? firstNumberStr = Console.ReadLine();

// Console.Write("Введите второе число: ");
// string? secondNumberStr = Console.ReadLine();

// if((firstNumberStr != null) && (secondNumberStr != null))
// {
//    int firstNumber = int.Parse(firstNumberStr);
//    int secondNumber = int.Parse(secondNumberStr);

//    if(firstNumber < secondNumber)
//    {
//       Console.WriteLine("max = " + secondNumber);
//    }
//    else
//    {
//       Console.WriteLine("max = " + firstNumber);
      
//    }
// }
// -------------------------------------------------------
//                End Variant I


//                Variant II
// =======================================================
Console.Write("Введите первое число: ");
string? firstNumberStr = Console.ReadLine();

Console.Write("Введите второе число: ");
string? secondNumberStr = Console.ReadLine();

if((firstNumberStr != null) && (secondNumberStr != null))
{
   int firstNumber = int.Parse(firstNumberStr);
   int secondNumber = int.Parse(secondNumberStr);

   int max = (firstNumber < secondNumber) ? secondNumber : firstNumber;

   Console.WriteLine("max = " + max);
}
// -------------------------------------------------------
//                End Variant II

