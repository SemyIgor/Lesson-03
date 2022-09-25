Console.Write("Put in your number: ");
string? inputLine = Console.ReadLine();

if(inputLine != null)
{
   int inputNumber = int.Parse(inputLine);  // Turns string into integer (double precision)
   // int outNumber = inputNumber * inputNumber;
   int outNumber = (int)Math.Pow(inputNumber,2); // Using exponentation Math function
   Console.WriteLine("outNumber = " + outNumber);
}
