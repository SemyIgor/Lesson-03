// Program adds two numbers given and outputs the result

// Variant 01
// int numberA = 3;
// int numberB = 5;
// Console.WriteLine(numberA + numberB);

// Variant 02
// int numberA = 33;
// int numberB = 5;
// int result = numberA + numberB;
// Console.WriteLine(result);

// Variant 03. Random input
int numberA = new Random().Next(1, 10);   // [1 2 3 4 5 6 7 8 9] 10 is not in range
int numberB = new Random().Next(1, 10);   // [1 2 3 4 5 6 7 8 9] 10 is not in range
int result = numberA + numberB;
Console.Write(numberA + " + " + numberB + " = ");
Console.WriteLine(result);