// Find all even numbers
// 
//                Variant I 
// =======================================================
Console.Write("Введите число: ");
string? inputString = Console.ReadLine();

if(inputString != null)
{
   int inputNumber = int.Parse(inputString);
   int counter = 2;

   while (counter < inputNumber)
   {
      Console.Write(counter + ", ");
      counter += 2;
   }
      Console.Write(counter);
}
// -------------------------------------------------------
//                End Variant I


//                Variant II 
// =======================================================
// Console.Write("Введите число: ");
// string? inputString = Console.ReadLine();

// if(inputString != null)
// {
//    int inputNumber = int.Parse(inputString);
//    int counter = 2;
//    string outputString = "";

//    while (counter <= inputNumber - 2)
//    {
//       outputString = outputString + counter + ", ";
//       counter += 2;
//    }

//    if(inputNumber > 1)
//    {
//       outputString = outputString + counter;
//       Console.WriteLine(outputString);
//    }
// }
// -------------------------------------------------------
//                End Variant II