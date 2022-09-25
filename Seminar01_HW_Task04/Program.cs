// Find max of three numbers

//                Variant I
// =======================================================
// Console.Write("Введите первое число: ");
// string? firstNumberStr = Console.ReadLine();

// Console.Write("Введите второе число: ");
// string? secondNumberStr = Console.ReadLine();

// Console.Write("Введите третье число: ");
// string? thirdNumberStr = Console.ReadLine();

// if((firstNumberStr != null) && (secondNumberStr != null) && (thirdNumberStr != null))
// {
//    int firstNumber = int.Parse(firstNumberStr);
//    int secondNumber = int.Parse(secondNumberStr);
//    int thirdNumber = int.Parse(thirdNumberStr);

//    if(firstNumber < secondNumber)
//    {
//       if(thirdNumber < secondNumber)
//       {
//          Console.WriteLine("max = " + secondNumber);
//       }
//       else
//       {
//          Console.WriteLine("max = " + thirdNumber);
//       }
//    }
//    else
//    {
//       if(firstNumber < thirdNumber)
//       {
//          Console.WriteLine("max = " + thirdNumber);
//       }
//       else
//       {
//          Console.WriteLine("max = " + firstNumber);
//       }
//    }
// }
// -------------------------------------------------------
//                End Variant I


//                Variant II
// =======================================================

//    Console.Write("Введите первое число: ");
//    string? firstNumberStr = Console.ReadLine();

//    Console.Write("Введите второе число: ");
//    string? secondNumberStr = Console.ReadLine();

//    Console.Write("Введите третье число: ");
//    string? thirdNumberStr = Console.ReadLine();

// if((firstNumberStr != null) && (secondNumberStr != null) && (thirdNumberStr != null))
// {
//    int firstNumber = int.Parse(firstNumberStr);
//    int secondNumber = int.Parse(secondNumberStr);
//    int thirdNumber = int.Parse(thirdNumberStr);

//    if((firstNumber > secondNumber) && (firstNumber > thirdNumber))
//    {
//       Console.WriteLine("max = " + firstNumber);
//    }

//    if((secondNumber > firstNumber) && (secondNumber > thirdNumber))
//    {
//       Console.WriteLine("max = " + secondNumber);
//    }

//    if((thirdNumber > firstNumber) && (thirdNumber > secondNumber))
//    {
//       Console.WriteLine("max = " + thirdNumber);
//    }
// }
// -------------------------------------------------------
//                End Variant II


//                Variant III
// =======================================================

//    Console.Write("Введите первое число: ");
//    string? firstNumberStr = Console.ReadLine();

//    Console.Write("Введите второе число: ");
//    string? secondNumberStr = Console.ReadLine();

//    Console.Write("Введите третье число: ");
//    string? thirdNumberStr = Console.ReadLine();

// if((firstNumberStr != null) && (secondNumberStr != null) && (thirdNumberStr != null))
// {
//    int firstNumber = int.Parse(firstNumberStr);
//    int secondNumber = int.Parse(secondNumberStr);
//    int thirdNumber = int.Parse(thirdNumberStr);

//    switch(firstNumber > secondNumber)
//    {
//       case true:
//          switch(firstNumber > thirdNumber)
//          {
//             case true:
//                Console.WriteLine("max = " + firstNumber);
//                break;
//             case false:
//                Console.WriteLine("max = " + thirdNumber);
//                break;
//          }
//          break;
//       case false:
//          switch(secondNumber > thirdNumber)
//          {
//             case true:
//                Console.WriteLine("max = " + secondNumber);
//                break;
//             case false:
//                Console.WriteLine("max = " + thirdNumber);
//                break;
//          }
//          break;
//    }
// }
// -------------------------------------------------------
//                End Variant III


//                Variant IV
// =======================================================
   Console.Write("Введите первое число: ");
   string? firstNumberStr = Console.ReadLine();

   Console.Write("Введите второе число: ");
   string? secondNumberStr = Console.ReadLine();

   Console.Write("Введите третье число: ");
   string? thirdNumberStr = Console.ReadLine();

if((firstNumberStr != null) && (secondNumberStr != null) && (thirdNumberStr != null))
{
   int firstNumber = int.Parse(firstNumberStr);
   int secondNumber = int.Parse(secondNumberStr);
   int thirdNumber = int.Parse(thirdNumberStr);
   
   int max = Math.Max(firstNumber, Math.Max(secondNumber, thirdNumber));

   Console.WriteLine(max);
}
// -------------------------------------------------------
//                End Variant IV

