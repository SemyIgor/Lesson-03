// Lesson -03_Seminar06_HW_Task41. Count positive numbers entered.
// 
// // Conditions:
// Count positive numbers entered
// 
// Algorithms:
// 1. Receive string of whole numbers
// 2. Count positive numbers entered
// 3. Print result

void CountEnteredPositiveNumbers() // Main method
{
   try
   {
      Console.Clear();
      string InvitationMessage = "Введите через запятую последовательность целых \n(положительных или отрицательных) чисел:\n"; // Invitation message
      string stringOfWholeNumbers = InputString(InvitationMessage); // Receives the string of numbers

      List<string> enteredStringNumbers =
      StringToList(stringOfWholeNumbers, ','); // Convert string to the list of numbers as strings

      int countPositiveNumbers =
      CountPositiveElements(enteredStringNumbers); // Iterates over the array to count positives
                                                   // countPositiveNumbers = 23; /* For testing the words endings */

      string nounEnding =
      NounEnding(countPositiveNumbers); // Choosing correct ending to the word "чис{ло}"

      string adverbEnding =
      AdverbEnding(countPositiveNumbers); // Choosing correct ending to the word "положительн{ое}"

      string resultMessage = /* Forming string to print result */
      ($"Вами было введено {countPositiveNumbers} положительн{adverbEnding} чис{nounEnding}");
      OutputString(resultMessage); // Prints result - number of positives entered
   }
   catch
   {
      Console.WriteLine("Ошибка ввода чисел!");
   }
}

string InputString(string message) // Enter string 
{
   Console.Write(message); // Print invitation message
   string stringOfNumbers = Console.ReadLine() ?? ""; // Input string
   return stringOfNumbers; // Return input string
}

List<string> StringToList(string enteredString, char separator) // Convert string with separators to list
{
   List<string> enteredStringNumbers = new List<string> { }; // changeable array declaration
   enteredString = enteredString.Replace(" ", String.Empty); // Delets spaces in the string
   enteredStringNumbers = enteredString.Split(separator).ToList(); // Array generation
   return enteredStringNumbers; // Returns list of entered numbers as the list of strings
}

int CountPositiveElements(List<string> enteredNumbers) // Count positive numbers in the List<> array
{
   int countPositive = 0; // Initial value
   foreach (string number in enteredNumbers) /* Iterate over the array */
   {
      if (int.Parse(number) > 0) countPositive++; // If element is positive then increment counter
   }
   return countPositive; // Return number of positives
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message); // Output message
}

string NounEnding(int number) // Choosing correct ending to the word "чис{ло}"
{
   string ending = String.Empty;
   if ((((number / 10) % 10) == 1) || /* Second digit from the end is 1 */
      ((number % 10) == 0) || /* Last digit is 0 */
      ((number % 10 > 4) && (number % 10 <= 9))) ending = "ел"; // Last digit is from 5 to 9
   if ((((number / 10) % 10) != 1) && /* Second digit from the end is not 1 */
      ((number % 10) == 1)) ending = "ло"; // and the last digit is 1,
   if ((((number / 10) % 10) != 1) && /* Second digit from the end is not 1 */
      (((number % 10) > 1) && /* and the last digit is more then 1 */
      ((number % 10) < 5))) ending = "ла"; // and the last digit is less then 5
   return ending;
}

string AdverbEnding(int number) // Choosing correct ending to the word "положительн{ое}"
{
   string ending = String.Empty;
   ending = (((number % 10) == 1) && /* Number ending by 1 */
      (((number / 10) % 10)) != 1) ? /* and second digit from the end is not 1 */
       "ое" : /* if true */
       "ых";  /* if false */
   return ending; // Return ending of the adverb "положительн{ое}"
}

CountEnteredPositiveNumbers();