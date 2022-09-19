// Input day of week number and return if it is weekend
// 
Console.Clear();
// Creating the list of the weekday's ordinal numbers
List<int> weekDays = new List<int>();
for(int i = 0; i < 7; i++)
{
   weekDays.Add(i + 1);
}
// Creating the list of the workday's ordinal numbers
List<int> workdays = new List<int>(){1,2,3,4,5};

// Creating the dictionary of the weekdays
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

// Variant I Using List
void VariantI(string dayStr)
{
   Console.WriteLine("Variant I");
   int dayNumber = int.Parse(dayStr);
   if(weekDays.Contains(dayNumber))
      {
         if (workdays.Contains(dayNumber))
            {
               Console.WriteLine($"The day №{dayNumber} is a workday");
            }
            else
            {
               Console.WriteLine($"The day №{dayNumber} is a weekend !");
            }
      }
      else
      {
         Console.WriteLine($"There's no day №{dayNumber} in a week !!!");
      }
}

// Variant II Using Dictionary
void VariantII(string dayStr)
{
   Console.WriteLine("Variant II");
   if(daysOfWeek.ContainsKey(dayStr))
   {
      if(dayStr == "6" || dayStr == "7")
      {
         Console.WriteLine($"{daysOfWeek[dayStr]} - это выходной");
      }
      else
      {
         Console.WriteLine($"{daysOfWeek[dayStr]} - это рабочий день");
      }
   }
   else
   {
      Console.WriteLine($"В неделе нет дня под номером {dayStr} !!!");
   }
}

Console.Write("Введите порядковый номер дня недели: ");
string? dayString = Console.ReadLine();
if(dayString != null)
{
   VariantI(dayString);

   VariantII(dayString);
}


   