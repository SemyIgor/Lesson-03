// If the number is even ?
// 
//                Variant I
// =======================================================
// Console.Write("Введите число: ");
// string? inputString = Console.ReadLine();

// if(inputString != null)
// {
//    int inputNumber = int.Parse(inputString);

//    if(inputNumber % 2 == 0)
//    {
//       Console.WriteLine("Число " + inputString + " - чётное");
//    }
//    else
//    {
//       Console.WriteLine("Число " + inputString + " - нечётное");
//    }
// }
// -------------------------------------------------------
//                End Variant I


//                Variant II (нерациональный)
// =======================================================
// Console.Write("Введите число: ");
// string? inputString = Console.ReadLine();

// if(inputString != null)
// {
//    int inputNumber = int.Parse(inputString);
//    int counter = 0;

//    while (counter < inputNumber)
//    {
//       counter += 2;
//    }
//    if (counter == inputNumber)
//    {
//       Console.WriteLine("Число " + inputString + " - чётное");
//    }
//    else
//    {
//       Console.WriteLine("Число " + inputString + " - нечётное");
//    }
// }
// -------------------------------------------------------
//                End Variant II


//                Variant Ia - Выходные данные по техзаданию
// ===========================================================
Console.Write("Введите число: ");
string? inputString = Console.ReadLine();

if(inputString != null)
{
   int inputNumber = int.Parse(inputString);

   if(inputNumber % 2 == 0)
   {
      Console.WriteLine("да");
   }
   else
   {
      Console.WriteLine("нет");
   }
}
// -----------------------------------------------------------
//                End Variant Ia