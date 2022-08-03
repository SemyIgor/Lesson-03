// Lesson-03_Seminar04_Task26. Enter natural number and return the number of it's digits.

Console.Clear();
long t; // ticks of the clock gentrator

string inputString() // Enter string of digits
{
   Console.Write("Введите любое натуральное число: ");
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

void VariantChar(string charString) // Transformed the string of digits to char array and got it's length
// Преобразуем строку цифр в массив символов и определяем длину массива
{
   int digits = charString.ToCharArray().Length;
   Console.WriteLine("Во введенном числе {0} цифр", digits);
}

void VariantString(string strString) // Just measured the length of the entered string
// Определяем длину введённой строки
{
   Console.WriteLine("Во введенном числе {0} цифр", strString.Length);
}

void VariantNumeral(long numString) // Dividing the received number by 10 until it is less than 1 and watching the counter inside the method
// Полученное число в цикле делим на 10, пока оно не будет < 1, и отслеживаем при этом счётчик внутри метода
{
   int count = 1;
   while (numString > 1)
   {
      numString = numString / 10;
      count++;
   }
   Console.WriteLine("Во введенном числе {0} цифр", count);
}

int VariantRecurrent(ref int digitsCount, long numStr) // Recursively dividing the received number by 10 until it is less than 1 and watching the counter outside the method
// Рекурсивно делим число на 10, пока оно не будет < 1 и меняем при этом счётчик за пределами метода
{
   if (numStr < 1) return digitsCount;
   digitsCount++;
   return VariantRecurrent(ref digitsCount, numStr / 10);
}

// Вызываем метод ввода строки цифр
string inpString = inputString(); // Calling method inputing string of digits

try // Trying if the received string could be transformed into number
// Обрабатываем исключение на предмет перевода строки в число (без конкренизации исключения)
{
   long numberStr = long.Parse(inpString);

   t = Environment.TickCount; // getting tick count
   VariantNumeral(numberStr); // Calling number method
   Console.WriteLine("Numeral time = {0} ms", Environment.TickCount - t);
   Console.WriteLine();

   t = Environment.TickCount; // getting tick count
   int digitsCount = 0;
   VariantRecurrent(ref digitsCount, numberStr); // Calling recurrent method
   Console.WriteLine("Во введенном числе {0} цифр", digitsCount);
   Console.WriteLine("Recurrent time = {0} ms", Environment.TickCount - t);
   Console.WriteLine();
}
catch
{
   Console.WriteLine("Exception occured ! Too long or too short number.");
}
finally
{
   Console.WriteLine();
}

t = Environment.TickCount; // getting tick count
VariantChar(inpString); // Calling char method 
Console.WriteLine("Char time = {0} ms", Environment.TickCount - t);
Console.WriteLine(); // Line to separate results of different methods

t = Environment.TickCount; // getting tick count
VariantString(inpString); // Calling string method
Console.WriteLine("String time = {0} ms", Environment.TickCount - t);
Console.WriteLine();




// Method-in-method does not allow to measure timing of such module
// because inner method ReadLine() depends on the user's input