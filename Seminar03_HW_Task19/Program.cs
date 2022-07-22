// Seminar03_HW_Task19. Enter 5-digit number and check if it is a palyndrome

// Variant I
void VariantI(int num)
{
   if ((num < 100000) && (num > 9999))
   {
      int[] digits = new int[5];
      int remainder = num;
      for (int i = 4; i >= 0; i--)
      {
         digits[i] = remainder % 10;
         remainder = remainder / 10;
      }
      if ((digits[0] == digits[4]) && (digits[1] == digits[3]))
      {
         Console.WriteLine($"Число {num} является полиндромом");
      }
      else
      {
         Console.WriteLine($"Число {num} не является полиндромом");
      }
   }
   else
   {
      Console.WriteLine(num + " не пятизначное число");
   }
}

Console.Clear();
Console.Write("Введите пятизначное число: ");
string? numberStr = Console.ReadLine();
if (numberStr != null)
{
   int number = int.Parse(numberStr);
   VariantI(number);
}
