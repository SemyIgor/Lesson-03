// Lesson-03_Seminar06_Task43+. Calculates triangle area

void CountCoordsOfIntersection() // Main method
{
   Console.Clear();
   try
   {
      double[,] indexesArray = GetLineIndexesArray(); // Get array of the line's indexes
      double[,] coordsArray = CountCoordsOfPoints(indexesArray);

      Console.WriteLine();
      Console.WriteLine("Коэффициенты прямых:");
      PrintArray(indexesArray);

      Console.WriteLine();
      Console.WriteLine("Координаты точек:");
      PrintArray(coordsArray);

      Console.WriteLine();
      // Console.WriteLine("Координаты точек:");
      double triangleArea = TriangleAreaHeron(coordsArray);
      Console.WriteLine("Площадь полученного треугольника = {0}", triangleArea);


      // === Make it later =========================================
      // if (k1 == k2) /* Verification the lines are parallel */
      // {
      //    Console.WriteLine("Эти прямые не пересекаются - они параллельны");
      //    return;
      // }
      // -----------------------------------------------------------
   }
   catch
   {
      Console.WriteLine("Ошибка ввода данных");
   }
}

double InputStringToDouble(string message) // Input string and convert it to integer
{
   Console.Write(message); // Print input message
   double doubleNumber = double.Parse(Console.ReadLine() ?? ""); // Convert string to integer
   return doubleNumber; // Return inputed number (Is equal the length of the Fibonacci sequence)
}

double[,] GetLineIndexesArray()
{
   double[,] array = new double[3, 2];

   string k1InputMessage = "Введите коэффициенты первой прямой\nВведите k1 = "; // Invitation message
   array[0, 0] = InputStringToDouble(k1InputMessage); // Input index k1
   string b1InputMessage = "Введите b1 = "; // Invitation message
   array[0, 1] = InputStringToDouble(b1InputMessage); // Input index b1

   string k2InputMessage = "\nВведите коэффициенты второй прямой\nВведите k2 = "; // Invitation message
   array[1, 0] = InputStringToDouble(k2InputMessage); // Input index k2
   string b2InputMessage = "Введите b2 = "; // Invitation message
   array[1, 1] = InputStringToDouble(b2InputMessage); // Input index b2

   string k3InputMessage = "\nВведите коэффициенты третьей прямой\nВведите k3 = "; // Invitation message
   array[2, 0] = InputStringToDouble(k3InputMessage); // Input index k3
   string b3InputMessage = "Введите b3 = "; // Invitation message
   array[2, 1] = InputStringToDouble(b3InputMessage); // Input index b3

   return array;
}

double[,] CountCoordsOfPoints(double[,] indexesArray)
{
   double[,] coordsArray = new double[3, 2];
   // Intersection of lineA and lineB
   coordsArray[0, 0] = Math.Round(((indexesArray[1, 1] - indexesArray[0, 1]) /
   (indexesArray[0, 0] - indexesArray[1, 0])), 5); // Calculate X of intersection 
   coordsArray[0, 1] = Math.Round((indexesArray[0, 0] * coordsArray[0, 0] +
   indexesArray[0, 1]), 5); // Calculate Y of intersection

   // Проверка по Y
   // double y1 = Math.Round((indexesArray[1, 0] * coordsArray[0, 0] +
   // indexesArray[1, 1]), 5);
   // Console.WriteLine(y1);

   // Intersection of lineA and lineC
   coordsArray[1, 0] = Math.Round(((indexesArray[2, 1] - indexesArray[0, 1]) /
   (indexesArray[0, 0] - indexesArray[2, 0])), 5); // Calculate X of intersection 
   coordsArray[1, 1] = Math.Round((indexesArray[0, 0] * coordsArray[1, 0] +
   indexesArray[0, 1]), 5); // Calculate Y of intersection

   // Проверка по Y
   // double y2 = Math.Round((indexesArray[2, 0] * coordsArray[1, 0] +
   // indexesArray[2, 1]), 5);
   // Console.WriteLine(y2);

   // Intersection of lineB and lineC
   coordsArray[2, 0] = Math.Round(((indexesArray[2, 1] - indexesArray[1, 1]) /
   (indexesArray[1, 0] - indexesArray[2, 0])), 5); // Calculate X of intersection 
   coordsArray[2, 1] = Math.Round((indexesArray[1, 0] * coordsArray[2, 0] +
   indexesArray[1, 1]), 5); // Calculate Y of intersection

   // Проверка по Y
   // double y3 = Math.Round((indexesArray[2, 0] * coordsArray[2, 0] +
   // indexesArray[2, 1]), 5);
   // Console.WriteLine(y3);

   return coordsArray;
}

double TriangleAreaHeron(double[,] coordsArray)
{
   double sideA = Math.Sqrt(Math.Pow(coordsArray[0, 0] - coordsArray[1, 0], 2) +
   Math.Pow(coordsArray[0, 1] - coordsArray[1, 1], 2));
   double sideB = Math.Sqrt(Math.Pow(coordsArray[0, 0] - coordsArray[2, 0], 2) +
   Math.Pow(coordsArray[0, 1] - coordsArray[2, 1], 2));
   double sideC = Math.Sqrt(Math.Pow(coordsArray[1, 0] - coordsArray[2, 0], 2) +
   Math.Pow(coordsArray[1, 1] - coordsArray[2, 1], 2));

   double halfPerimeter = (sideA + sideB + sideC) / 2;

   double triangleArea = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

   triangleArea = Math.Round(triangleArea, 5);

   return triangleArea;
}



void PrintArray(double[,] array) // Print given array
{
   for (int j = 0; j < array.GetLength(0); j++)
   {
      int i = 0;
      Console.Write($"["); // Print opening bracket
      while (i < array.GetLength(1) - 1) // Print elements and commas, but not last element
      {
         Console.Write("{0,4}, ", array[j, i]); // Print elements and commas using formatting
         i++;
      }
      Console.WriteLine("{0,4} ]\n", array[j, i]); // Print last element and closing bracket

   }
}

CountCoordsOfIntersection();
