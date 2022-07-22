// Seminar03_HW_Task21. Take coordinates of two points in 3-d space and calculate distance between

// VariantI. 
void VariantI()
{
   try
   {
      Console.WriteLine("Variant I");

      CalculateDistance(EnterCoordinatesI());
   }
   catch
   {
      Console.WriteLine("Ошибка ввода");
   }
}

// Enter coordinates into variables Variant I
int[,] EnterCoordinatesI()
{
   int[,] coordinates = new int[1, 6];

   Console.Write("Введите координату X точки A: ");
   string? pointAcoordX = Console.ReadLine();

   Console.Write("Введите координату Y точки A: ");
   string? pointAcoordY = Console.ReadLine();

   Console.Write("Введите координату Z точки A: ");
   string? pointAcoordZ = Console.ReadLine();

   Console.Write("Введите координату X точки B: ");
   string? pointBcoordX = Console.ReadLine();

   Console.Write("Введите координату Y точки B: ");
   string? pointBcoordY = Console.ReadLine();

   Console.Write("Введите координату Z точки B: ");
   string? pointBcoordZ = Console.ReadLine();

   if ((pointAcoordX != null) && (pointAcoordY != null) && (pointAcoordZ != null) && (pointBcoordX != null) && (pointBcoordY != null) && (pointBcoordZ != null))
   {
      coordinates[0, 0] = int.Parse(pointAcoordX);
      coordinates[0, 1] = int.Parse(pointAcoordY);
      coordinates[0, 2] = int.Parse(pointAcoordZ);
      coordinates[0, 3] = int.Parse(pointBcoordX);
      coordinates[0, 4] = int.Parse(pointBcoordY);
      coordinates[0, 5] = int.Parse(pointBcoordZ);
   }
   return coordinates;

}

// Calculate distance between two points
void CalculateDistance(int[,] dis)
{
   double distance = Math.Sqrt(Math.Pow(dis[0, 0] - dis[0, 3], 2) + Math.Pow(dis[0, 1] - dis[0, 4], 2) + Math.Pow(dis[0, 2] - dis[0, 5], 2));
   Console.WriteLine($"Расстояние между точками A и B равно {distance}");
}

Console.Clear();
VariantI();
