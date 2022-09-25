// Transforn number of the day of week into it's name

//                 Variant I 
// ====================================================
string? inputLine = Console.ReadLine();
if(inputLine != null)
{
   int inputNumber = int.Parse(inputLine);

   string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputNumber));

   Console.WriteLine(outDayOfWeek);
}
// ----------------------------------------------------
//               End Variant I


//                 Variant II 
// ===================================================
// string? inputLine = Console.ReadLine();
// if(inputLine != null)
// {
//    int inputNumber = int.Parse(inputLine);
//    string[] dayOfWeek = new string[7];
//    dayOfWeek[0] = "Понедельник";
//    dayOfWeek[1] = "Вторник";
//    dayOfWeek[2] = "Среда";
//    dayOfWeek[3] = "Четверг";
//    dayOfWeek[4] = "Пятница";
//    dayOfWeek[5] = "Суббота";
//    dayOfWeek[6] = "Воскресенье";

//    Console.WriteLine(dayOfWeek[inputNumber-1]);
// }
// -----------------------------------------------------
//               End Variant II


//                Variant III
// ======================================================
// string? inputLine = Console.ReadLine();
// if(inputLine != null)
// {
//    int inputNumber = int.Parse(inputLine);
//    switch(inputNumber)
//       {
//          case 1:
//          Console.WriteLine("Понедельник");
//          break;
         
//          case 2:
//          Console.WriteLine("Вторник");
//          break;

//          case 3:
//          Console.WriteLine("Среда");
//          break;

//          case 4:
//          Console.WriteLine("Четверг");
//          break;

//          case 5:
//          Console.WriteLine("Пятница");
//          break;

//          case 6:
//          Console.WriteLine("Суббота");
//          break;

//          case 7:
//          Console.WriteLine("Воскресенье");
//          break;
//       }
// }
// ----------------------------------------------------------
//                    End Variant III


//                     Variant IV (without parsing)
// ==========================================================
// string? inputLine = Console.ReadLine();
// if(inputLine != null)
// {
//    switch(inputLine)
//       {
//          case "1":
//          Console.WriteLine("Понедельник");
//          break;
         
//          case "2":
//          Console.WriteLine("Вторник");
//          break;

//          case "3":
//          Console.WriteLine("Среда");
//          break;

//          case "4":
//          Console.WriteLine("Четверг");
//          break;

//          case "5":
//          Console.WriteLine("Пятница");
//          break;

//          case "6":
//          Console.WriteLine("Суббота");
//          break;

//          case "7":
//          Console.WriteLine("Воскресенье");
//          break;
//       }
// }
// --------------------------------------------------------------------------------------
//                  End Variant IV


//                    Variant V (without "inputNumber - 1")
// ======================================================================================
// We can set array element with index 0 into empty string (array[0] = "")

// string[] dayOfWeek = {"Нет такого дня недели !","Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};

// Console.Write("Введите порядковый номер дня недели: ");
// string? inputString = Console.ReadLine();

// if(inputString != null)
// {
//    int inputNumber = int.Parse(inputString);
//    Console.WriteLine(dayOfWeek[inputNumber]);
// }
// --------------------------------------------------------------------------------------
//                   End Variant V
