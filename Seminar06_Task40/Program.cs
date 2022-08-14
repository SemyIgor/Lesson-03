// Lesson-03_Seminar06_Task40. Receive 3 numbers. Check if it is possible to make triangle.
// Conditions:
// Check if triangle can be made using sides of received length
// 
// Algorithms:
// 1. Read three (3) numbers
// 2. Check if true a<b+c && b<a+c && c<a+b (can draw triangle)
// 3. Print message if it is possible or not to draw triangle

void IsItTriangle()
{
   Console.Clear();
   List<string> triangleSides = new List<string> { }; // Declare list of triangle sides

   // Block of messages
   // ---------------------------------------------------------------------------------------------
   string inputMessage = "Введите длины сторон треугольника через запятую:\n"; // Invitation message
   string itIsTriangle = "Мы получим треугольник, если соединим данные точки"; // It is triangle
   string itIsNotTriangle =
   "Мы не сможем получить треугольник, если соединим данные точки"; // It is not tirangle
   // ---------------------------------------------------------------------------------------------

   string enteredString = InputString(inputMessage); // Inviting message and receiving string

   triangleSides = StringToList(enteredString, ','); // Turning string of names into string array of names
   Console.WriteLine("sideA = {0};\nsideB = {1};\nsideC = {2}",
   triangleSides[0], triangleSides[1], triangleSides[2]); // Print triangle sides sizies

   bool ifTriangle = CheckIfTriangle(triangleSides); // Receiving result of checking
   if (ifTriangle)  // Check if the triangle inequality is true
   {
      OutputString(itIsTriangle); // Print if triangle inequality is true
   }
   else
   {
      OutputString(itIsNotTriangle); // Print if triangle inequality is false
   }
}

string InputString(string message) // Enter string of triangle lengths
{
   Console.Write(message);
   string stringOfNumbers = Console.ReadLine() ?? "";
   return stringOfNumbers;
}

List<string> StringToList(string enteredString, char separator) // Convert string with separators to list
{
   List<string> triangleSides = new List<string> { }; // changeable array declaration
   enteredString = enteredString.Replace(" ", String.Empty); // Delets spaces in the string
   triangleSides = enteredString.Split(separator).ToList(); // Array generation
   return triangleSides;
}

bool CheckIfTriangle(List<string> sidesOfTriangleList) // Checking if triangle inequality is true
{
   double sideA = double.Parse(sidesOfTriangleList[0]);
   double sideB = double.Parse(sidesOfTriangleList[1]);
   double sideC = double.Parse(sidesOfTriangleList[2]);

   return ((sideA < sideB + sideC) && (sideB < sideA + sideC) && (sideC < sideA + sideB));
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message);
}

IsItTriangle();

