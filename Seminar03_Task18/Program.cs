// Seminar03_Task18. Input coordinate plane quadrant number and print limits of this quqdrant 

void VariantI()
{
   try
   {
      Console.WriteLine("Variant I");

      Console.Write("Введите номер четверти координатной плоскости: ");
      string? quadrant = Console.ReadLine();

      if (quadrant != null)
      {
         PrintLimits(quadrant);
      }
   }
   catch
   {
      Console.WriteLine("Непредвиденная ошибка");
   }
}

void PrintLimits(string quad)
{
   string coordinatesLimits = String.Empty;

   if (quad == "1" || quad == "I") coordinatesLimits = "X > 0; Y > 0";
   if (quad == "2" || quad == "II") coordinatesLimits = "X < 0; Y > 0";
   if (quad == "3" || quad == "III") coordinatesLimits = "X < 0; Y < 0";
   if (quad == "4" || quad == "IV") coordinatesLimits = "X > 0; Y < 0";

   Console.WriteLine(coordinatesLimits);
}

Console.Clear();

// Using strings
VariantI();
