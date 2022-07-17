// Input day of week number and return if it is weekend
// 
//                   Variant I
// Using generic List<>
// ==================================================================
// Console.Clear();
// List<int> daysOfWeek = new List<int>();
// for(int i = 0; i < 7; i++)
// {
//    daysOfWeek.Add(i + 1);
// }

// List<int> workdays = new List<int>(){1,2,3,4,5};

// Console.Write("Введите порядковый номер дня недели: ");
// string? dayString = Console.ReadLine();
// if(dayString != null)
// {
//    int dayNumber = int.Parse(dayString);

//    if(daysOfWeek.Contains(dayNumber))
//    {
//       if (workdays.Contains(dayNumber))
//          {
//             Console.WriteLine($"The day №{dayNumber} is a workday");
//          }
//          else
//          {
//             Console.WriteLine($"The day №{dayNumber} is a weekend !");
//          }
//    }
//    else
//    {
//       Console.WriteLine($"There's no day №{dayNumber} in a week !!!");
//    }
// }
// ----------------------------------------------------------------------
//               End of Variant I


//                   Variant II
// Using generic Dictionary
// ==================================================================
var daysOfWeek = new Dictionary<string, string>()
{
   {"1", "Понедельник"},
   {"2", "Вторник"},
   {"3", "Среда"},
   {"4", "Четверг"},
   {"5", "Пятница"},
   {"6", "Суббота"},
   {"7", "Воскресенье"}
};
Console.Clear();
Console.Write("Введите порядковый номер дня недели: ");
string? dayString = Console.ReadLine();

if(dayString != null)
{
   if(daysOfWeek.ContainsKey(dayString))
   {
      if(dayString == "6" || dayString == "7")
      {
         Console.WriteLine($"{daysOfWeek[dayString]} - это выходной");
      }
      else
      {
         Console.WriteLine($"{daysOfWeek[dayString]} - это рабочий день");
      }
   }
   else
   {
      Console.WriteLine($"В неделе нет дня под номером {dayString} !!!");
   }
}
// ----------------------------------------------------------------------
//               End of Variant II