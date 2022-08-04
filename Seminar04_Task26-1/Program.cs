// Lesson-03_Seminar04_Task26-1. Enter natural number and return the number of it's digits. DateTime.Now.

Console.Clear();
DateTime timeSharp; // System time

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

void VariantLog10(long number) // Getting logarithm of the received number
// Получаем логарифм введенного числа
{
   Console.WriteLine("Во введенном числе {0} цифр", ((long)Math.Log10(number) + 1));
}

// Вызываем метод ввода строки цифр
string inpString = inputString(); // Calling method inputing string of digits

try // Trying if the received string could be transformed into number
// Обрабатываем исключение на предмет перевода строки в число (без конкренизации исключения)
{
   long numberStr = long.Parse(inpString);

   timeSharp = DateTime.Now;
   VariantNumeral(numberStr); // Calling Number method
   Console.WriteLine("Numeral time = {0} ms", DateTime.Now - timeSharp);
   Console.WriteLine();

   timeSharp = DateTime.Now;
   VariantLog10(numberStr); // Calling Number method
   Console.WriteLine("Logarithm time = {0} ms", DateTime.Now - timeSharp);
   Console.WriteLine();

   timeSharp = DateTime.Now;
   int digitsCount = 0;
   VariantRecurrent(ref digitsCount, numberStr); // Calling Recurrent method
   Console.WriteLine("Во введенном числе {0} цифр", digitsCount);
   Console.WriteLine("Recurrent time = {0} ms", DateTime.Now - timeSharp);
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

timeSharp = DateTime.Now;
VariantChar(inpString); // Calling Char method 
Console.WriteLine("Char time = {0} ms", DateTime.Now - timeSharp);
Console.WriteLine(); // Line to separate results of different methods

timeSharp = DateTime.Now;
VariantString(inpString); // Calling String method
Console.WriteLine("String time = {0} ms", DateTime.Now - timeSharp);
Console.WriteLine();




// Method-in-method does not allow to measure timing of such module
// because inner method ReadLine() depends on the user's input
