// Seminar03_HW_Task19. Enter 5-digit number and check if it is a palyndrome

// Variant I. Turn number into array
void VariantI(int num)
{
   Console.WriteLine("Variant I");
   int[] digits = new int[5];
   int remainder = num;
   for (int i = 4; i >= 0; i--)   // Turn 5-digit number into 5-element array
   {
      digits[i] = remainder % 10; // Save last digit into array digits[]
      remainder = remainder / 10; // Cut last digit of the received number num _
                                  // to take it's last digit at the previous step
   }
   if ((digits[0] == digits[4]) && (digits[1] == digits[3])) // Compare numbers 1st <=> 5th and 2nd <=> 4th _
                                                             // (5th does not matter)
   {
      Console.WriteLine($"Число {num} является полиндромом");
   }
   else
   {
      Console.WriteLine($"Число {num} не является полиндромом");
   }
   Console.WriteLine();
}

// Variant II. Generate dictionary of 4-digit palyndrome
// Checking at the moment of adding palyndrome. If number meets the dictionary, generation stops. 
void VariantII(int num)
{
   Console.WriteLine("Variant II");
   string result = "";
   // int num4Digit = Convert.ToInt32(num.ToString().Substring(0, 2) + num.ToString().Substring(3, 2));
   int num4Digit = num / 10000 * 1000 + ((num / 1000) % 10) * 100 + ((num % 100) / 10) * 10 + num % 10;
   Dictionary<int, int> palyndromes = new Dictionary<int, int>();
   int count = 0;
   for (int i = 1; i <= 9; i++)
   {
      for (int j = 0; j <= 9; j++)
      {
         palyndromes.Add(count, i * (1000 + 1) + j * (100 + 10));
         if (palyndromes.ContainsValue(num4Digit))
         {
            result = $"{num} is a polyndrome";
            goto Found;
         }
         count++;
      }
   }
   result = $"{num} is not a polyndrome";
Found:
   Console.WriteLine(result);
   Console.WriteLine();
}

// Variant III. Generate dictionary of 4-digit palyndrome
// Checking after the dictionary generated 
void VariantIII(int num)
{
   Console.WriteLine("Variant III");
   string result = "";
   // int num4Digit = Convert.ToInt32(num.ToString().Substring(0, 2) + num.ToString().Substring(3, 2));
   int num4Digit = num / 10000 * 1000 + ((num / 1000) % 10) * 100 + ((num % 100) / 10) * 10 + num % 10;
   Dictionary<int, int> palyndromes = new Dictionary<int, int>();
   int count = 0;
   for (int i = 1; i <= 9; i++)
   {
      for (int j = 0; j <= 9; j++)
      {
         palyndromes.Add(count, i * (1000 + 1) + j * (100 + 10));
         count++;
      }
   }

   result = palyndromes.ContainsValue(num4Digit) ? $"{num} is a polyndrome" : $"{num} is not a polyndrome";
   Console.WriteLine(result);
}

int InputNumber()
{
   Console.Clear(); // Clear console
   Console.Write("Введите пятизначное число: "); // Enter number as a string
   string? numberStr = Console.ReadLine();       //
   if ((numberStr != null) && (numberStr != ""))     // Check if the string is empty. If so the next mod performs
   {
      int number = int.Parse(numberStr); // String to integer number
      if ((number < 100000) && (number > 9999)) // check if the number is 5-digit number
      {
         return number;
      }
      else
      {
         return -1; // не пятизначное число
         // Console.WriteLine(number + " не пятизначное число");
      }
   }
   return -2; // Ошибка ввода. введена пустая строка
}

int number = InputNumber();

switch (number)
{
   case -1:
      Console.WriteLine("не пятизначное число");
      break;
   case -2:
      Console.WriteLine("Ошибка ввода !");
      break;
   default:
      VariantI(number);          // Call method Variant I
      VariantII(number);            // Call method Variant II
      VariantIII(number);            // Call method Variant III
      break;
}
