// Seminar03_Task20. Input coordinates X and Y of two points and print distance between the points

// VariantI. 
void VariantI()
{
   try
   {
      Console.WriteLine("Variant I");

      CalculateDistance(EnterCoordinates());
   }
   catch
   {
      Console.WriteLine("Ошибка ввода");
   }
}

// Enter coordinates into variables
int[,] EnterCoordinates()
{
   int[,] coordinates = new int[1, 4];

   Console.Write("Введите координату X точки A: ");
   string? pointAcoordX = Console.ReadLine();

   Console.Write("Введите координату Y точки A: ");
   string? pointAcoordY = Console.ReadLine();

   Console.Write("Введите координату X точки B: ");
   string? pointBcoordX = Console.ReadLine();

   Console.Write("Введите координату Y точки B: ");
   string? pointBcoordY = Console.ReadLine();

   if ((pointAcoordX != null) && (pointAcoordY != null) && (pointBcoordX != null) && (pointBcoordY != null))
   {
      coordinates[0, 0] = int.Parse(pointAcoordX);
      coordinates[0, 1] = int.Parse(pointAcoordY);
      coordinates[0, 2] = int.Parse(pointBcoordX);
      coordinates[0, 3] = int.Parse(pointBcoordY);
   }
   return coordinates;

}

// Calculate distance between two points
void CalculateDistance(int[,] dis)
{
   double distance = Math.Sqrt(Math.Pow(dis[0, 0] - dis[0, 2], 2) + Math.Pow(dis[0, 1] - dis[0, 3], 2));
   Console.WriteLine($"Расстояние между точками A и B равно {distance}");
}

Console.Clear();
VariantI();