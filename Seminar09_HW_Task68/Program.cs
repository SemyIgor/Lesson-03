// Lesson-03_Seminar09_Task68. Accerman's function
void AccermansFunc()
{
   Console.Clear();

   string enterM = InputString("Введите число m = ");
   uint m = uint.Parse(enterM);

   string enterN = InputString("Введите число n = ");
   uint n = uint.Parse(enterN);

   Console.WriteLine("Функция Аккермана равна {0}", Accerman(m, n));

}

// функция Аккермана
uint Accerman(uint m, uint n)
{
   if (m == 0)
   {
      return n + 1;
   }
   else
   {
      if ((m > 0) && (n == 0))
      {
         return Accerman(m - 1, 1);
      }
      else
      {
         return Accerman(m - 1, Accerman(m, n - 1));
      }
   }
}

string InputString(string message) // Invitation to and input of a string
{
   Console.Write(message);
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

AccermansFunc();



