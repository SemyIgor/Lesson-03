// Lesson-03_Seminar04_HW_Task25. Perform calculator for '+', '-', '*', '/', '^' operations

// Condition:
// Code cycle to perform '+', '-', '\*', '/', '^' operations

// Algorithm:
// 1. Invitation to input arithmetic problem (for example: 4 / 2; 7 ^ 2; 8 - 3 etc.).
// 2.Split problem to numbers and operators.
// 3. Choose operation and it's method.
// 4. Call respective method.
// 5. Print result.
// 6. Return to invitation.

void calculator() // launches calculator
{
   string stringLine = String.Empty;
   string mathOperator = String.Empty;
   double numberFirst = 0;
   double numberSecond = 0;

   while (stringLine.ToLower() != "q")
   {
      invitation(); // Prints an invitation to input problem and a short instruction how to do it
      stringLine = inputString().Replace(" ", String.Empty); // Receives the line of problem and delets spaces in it
      switch (takeOperator(stringLine)) // Takes the operator sign and perform respective math operation
      {
         case "+":
            mathOperator = "+";
            takeNumbers(stringLine, mathOperator, out numberFirst, out numberSecond); // extract numbers
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, mathOperator, numberSecond, numberFirst + numberSecond); // calculate and print result
            break;
         case "-":
            mathOperator = "-";
            takeNumbers(stringLine, mathOperator, out numberFirst, out numberSecond);
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, mathOperator, numberSecond, numberFirst - numberSecond);
            break;
         case "*":
            mathOperator = "*";
            takeNumbers(stringLine, mathOperator, out numberFirst, out numberSecond);
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, mathOperator, numberSecond, numberFirst * numberSecond);
            break;
         case "/":
            mathOperator = "/";
            takeNumbers(stringLine, mathOperator, out numberFirst, out numberSecond);
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, mathOperator, numberSecond, numberFirst / numberSecond);
            break;
         case "^":
            mathOperator = "^";
            takeNumbers(stringLine, mathOperator, out numberFirst, out numberSecond);
            Console.WriteLine("{0} {1} {2} = {3}", numberFirst, mathOperator, numberSecond, Math.Pow(numberFirst, numberSecond));
            break;
         case "":
            Console.WriteLine("Повторите ввод, не понял задачу");
            break;
      }
      Console.WriteLine("Нажмите ENTER чтобы продолжить");
      while (Console.ReadKey().Key != ConsoleKey.Enter) { }
      // System.Threading.Thread.Sleep(3000);
   }
}

void invitation() // Prints an invitation to input problem and a short instruction how to do it
{
   Console.Clear();
   Console.WriteLine("Введите арифметический пример по форме:");
   Console.WriteLine("'a+b' - для сложения");
   Console.WriteLine("'a-b' - для вычитания");
   Console.WriteLine("'a*b' - для умножения");
   Console.WriteLine("'a/b; - для деления");
   Console.WriteLine("'a^b' - для возведения в степень");
   Console.WriteLine("Для выхода из программы введите q или Q");
}

string inputString() // Enter string of problem
{
   string stringNumber = Console.ReadLine() ?? "";
   return stringNumber;
}

void takeNumbers(string strLine, string mathOp, out double numFirst, out double numSecond) // Takes numbers
{
   numFirst = double.Parse(strLine.Substring(0, strLine.IndexOf(mathOp))); // Takes the first number of the math problem
   numSecond = double.Parse(strLine.Substring(strLine.IndexOf(mathOp) + 1)); // Takes the second number of the math problem
}

string takeOperator(string strLine) // Takes an operator of the math problem
{
   if (strLine.Contains("+")) return "+";
   if (strLine.Contains("*")) return "*";
   if (strLine.Contains("/")) return "/";
   if (strLine.Contains("^")) return "^";
   if (strLine.Contains("-")) return "-"; // Should be the last of these tests to provide operations with negatives
   if (strLine.ToLower().Contains("q")) return "q";
   return "";
}

calculator();
