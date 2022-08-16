// Lesson-03_Seminar06_Task43. Count coordinates of the intersection point of 2 lines
// 
// Conditions:
// Count coordinates of the intersection point of 2 lines
// 
// Algorithms:
// 1. Receive indexes of two straight lines equation
// 2. Count coordinates of the intersection poing of this lines
// 3. Print coordinates

// SIMPLIFIED METHOD

void CountCoordsOfIntersection()
{
   Console.Clear();
   try
   {
      string k1InputMessage = "Введите коэффициенты первой прямой\nВведите k1 = "; // Invitation message
      double k1 = InputStringToDouble(k1InputMessage); // Input index k1

      string b1InputMessage = "Введите b1 = "; // Invitation message
      double b1 = InputStringToDouble(b1InputMessage); // Input index k1

      string k2InputMessage = "\nВведите коэффициенты второй прямой\nВведите k2 = "; // Invitation message
      double k2 = InputStringToDouble(k2InputMessage); // Input index k1

      string b2InputMessage = "Введите b2 = "; // Invitation message
      double b2 = InputStringToDouble(b2InputMessage); // Input index k1

      double intersectionX = Math.Round(((b2 - b1) / (k1 - k2)), 5); // Calculate X of intersection 
      double intersectionY = Math.Round((k1 * intersectionX + b1), 5); // Calculate Y of intersection
      double intersectionY1 = Math.Round((k2 * intersectionX + b2), 5); // Verification Y be second formula

      Console.WriteLine();
      Console.WriteLine("x = (b2 - b1) / (k1 - k2); x = {0}", intersectionX);
      Console.WriteLine("y = k1 * x + b1; y = {0}\n", intersectionY);
      Console.WriteLine("Проверка:");
      Console.WriteLine("y = k2 * x + b2; y = {0}\n", intersectionY);

      // Console.WriteLine(intersectionX + "\n" + intersectionY + "\n" + intersectionY1);

      Console.WriteLine("Координаты точки пересечения прямых ({0}; {1})",
      intersectionX, intersectionY);
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



CountCoordsOfIntersection();