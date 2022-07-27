// Seminar03_Task17. Input coordinates X and Y of the point and specify coordinate plane quadrant

// VariantI. Prints quadrant number (enter coordinats X and Y separately)
void VariantI()
{
   try
   {
      Console.WriteLine("Variant I");

      Console.Write("Введите координату X: ");
      string? X = Console.ReadLine();

      Console.Write("Введите координату Y: ");
      string? Y = Console.ReadLine();

      if (X != null && Y != null)
      {
         string quadrantNumber = String.Empty;
         int numberX = int.Parse(X);
         int numberY = int.Parse(Y);
         if ((numberX != 0) && (numberY != 0))
         {
            if (numberX > 0 && numberY > 0) quadrantNumber = "Первая четверть";
            if (numberX < 0 && numberY > 0) quadrantNumber = "Вторая четверть";
            if (numberX < 0 && numberY < 0) quadrantNumber = "Третья четверть";
            if (numberX > 0 && numberY < 0) quadrantNumber = "Четвертая четверть";
         }
         else
         {
            quadrantNumber = "Input numbers should not be equal 0 !";
         }
         Console.WriteLine(quadrantNumber);
      }
   }
   catch
   {
      Console.WriteLine("Ошибка ввода");
   }
}

// VariantII. Prints quadrant number (enter coordinats using string form "x=34; y=-18")
// Using embedded method [ printQuadrant(readPoints()); ]
// ===================================================================================
// Read input line and output two-dimensional array of point's coordinates
int[,] readPoints()
{
   Console.WriteLine("Variant II");
   int[,] arrayOut = new int[1, 2];
   try
   {
      Console.Write("Enter coordinates using x=34 ; y=-18 form: ");
      string? inputLine = Console.ReadLine();
      if ((inputLine != null) && (inputLine != ""))
      {
         string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
         coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);

         string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
         coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

         int coordX = int.Parse(coordXLine);
         int coordY = int.Parse(coordYLine);

         arrayOut[0, 0] = coordX;
         arrayOut[0, 1] = coordY;
      }
      return arrayOut;
   }
   catch
   {
      Console.WriteLine("Input error");
      arrayOut[0, 0] = -1000;
      arrayOut[0, 1] = -1000;
      return arrayOut;
   }
}

// Check coordinates and print quadrant of the point's position
void printQuadrant(int[,] readPoints)
{
   // VariantII
   int[,] coordArray = readPoints;
   string quadrantNumber = String.Empty;

   if ((coordArray[0, 0] != -1000) && (coordArray[0, 1] != -1000))
   {
      if ((coordArray[0, 0] != 0) && (coordArray[0, 1] != 0))
      {
         if (coordArray[0, 0] > 0 && coordArray[0, 1] > 0) quadrantNumber = "Quadrant I";
         if (coordArray[0, 0] < 0 && coordArray[0, 1] > 0) quadrantNumber = "Quadrant II";
         if (coordArray[0, 0] < 0 && coordArray[0, 1] < 0) quadrantNumber = "Quadrant III";
         if (coordArray[0, 0] > 0 && coordArray[0, 1] < 0) quadrantNumber = "Quadrant IV";
      }
      else
      {
         quadrantNumber = "Input numbers should not be equal 0 !";
      }
      Console.WriteLine(quadrantNumber);
   }
}
// ------------------------------------------------------------------------------------
// End VariantII

Console.Clear();

// Variant I. Enter every coordinate separately
VariantI();
Console.WriteLine();

// VariantII
printQuadrant(readPoints());