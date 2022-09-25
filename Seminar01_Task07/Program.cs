// Shows a last digit of a 3-digit number

//              Variant I
// =======================================================
// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//    int inputNumber = int.Parse(inputLine);
//    int outputNumber = inputNumber % 10;
//    Console.WriteLine(outputNumber);
// }
// -------------------------------------------------------
//            End Variant I


//              Variant II
// =======================================================
// Console.Write("Введите трехзначное число: ");
// string? inputLine = Console.ReadLine();

// if(inputLine != null)
// {
//    string lastNum = inputLine.Substring(2, 1);  // .Substring(2, 1) - подстрока от символа с индексом 2 
//                                                 // (нумерация 0, 1, ...) и длиной 1 символ
//    Console.WriteLine(lastNum);
// }
// -------------------------------------------------------
//            End Variant II



//              Variant III
// =======================================================
Console.Write("Введите трехзначное число: ");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
   char[] charArray = inputLine.ToCharArray();  // .ToCharArray() - преобразует строку в массив символов 
   Console.WriteLine(charArray[2]);
}
// -------------------------------------------------------
//            End Variant III