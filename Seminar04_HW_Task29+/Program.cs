// Seminar04_HW_Task29+. Input list of names and print random name from the list

System.Random numberSintezator = new Random();

void ProblemStatement() // Algorithms description
{
   // Conditions:
   // Input list of names and print random name from the list

   // Algorithms:
   // VariantCommaSeparated
   // 1. Invitation to enter the list of names separated by commas
   // 2. Input string of the names
   // 3. Form the List array of the names 
   // 4. Random choice one name from the array
   // 5. Print chosen name.

   // VariantEnterSeparated
   // 1. Invitation to enter the list of names, separating them by pressing Enter key
   // 2. Input names and form the list array of the names
   // 3. Random choice one name from the array
   // 5. Print chosen name.
}
ProblemStatement(); // Just to take away warning message

void ChooseVariant(string choice) // Choose variant of decision and starts it
{
   switch (choice)
   {
      case "1":
         VariantCommaSeparated();
         break;
      case "2":
         VariantEnterSeparated();
         break;
      default:
         Console.WriteLine("Выбор непонятен...");
         break;
   }
}

void VariantCommaSeparated() // Variant I, elements are separated by ','
{
   List<string> playersList = new List<string> { };
   Console.Clear();
   string inputMessage = "Введите список имён, \nразделяя их запятой:\n"; // Invitation message
   string enteredString = InputString(inputMessage); // Inviting and receiving string
   playersList = StringToList(enteredString, ','); // Turning string of names into array of names

   Console.WriteLine("{0}, Сбегай за пивом!", playersList[numberSintezator.Next(0, playersList.Count)]); // Generates random index and prints corresponding array item
}

string InputString(string message) // Prints received invitation and inputs string
{
   Console.Write(message);
   string inputString = Console.ReadLine() ?? "";
   return inputString;
}

void OutputString(string message) // Just output received message
{
   Console.WriteLine(message);
}

List<string> StringToList(string enteredString, char separator) // Convert string with separators to list
{
   List<string> playersNames = new List<string> { }; // changeable array declaration
   enteredString = enteredString.Replace(" ", String.Empty); // Delets spaces in the string
   playersNames = enteredString.Split(separator).ToList(); // Array generation
   return playersNames;
}

void VariantEnterSeparated()
{
   Console.Clear();
   List<string> playersList = new List<string> { };
   string inputMessage = "Вводите имена, завершая ввод каждого имени\n" +   // Invitation text
   "нажатием клавиши ENTER.\n" + "Для завершения введите 'ъ' твёрдый знак"; // text continuation
   OutputString(inputMessage); // Invites to enter and enters names
   OutputString(EnterNames(playersList)); // Output result name
}

string EnterNames(List<string> enteredList) //Fills player's list and gives random name from it
{
   string name = String.Empty;   // Name to add it to list
   while (name != "ъ")           // Flag to stop input names
   {
      name = Console.ReadLine() ?? ""; // Enter a name to variable
      if (name != null && name != "" && name != " ") // If false, then skip next block 
      {
         enteredList.Add(name);     // Add variable to the list
      }
   }
   // while (Console.ReadKey().Key != ConsoleKey.Escape);
   enteredList.Remove(name); // Deleting 'ъ' from the list
   Console.Clear();
   string shopper = enteredList[numberSintezator.Next(0, enteredList.Count)]; // Receive chosen
   for (int i = 0; i < enteredList.Count; i++) // Cycling print of the list
   {
      Console.WriteLine(enteredList[i]);
   }
   Console.WriteLine(); // Empty string before chosen
   return shopper + ", " + "сбегай за пивом!"; // Returning chosen (shopper) to print
}

Console.Clear();

string inputMessage = "1. Для выбора метода ввода целиком всей строки введите 1,\n" + // Message
"2. Для выбора метода ввода каждого имени отдельной строчкой введите 2.\nВвод: ";
string chosen = InputString(inputMessage); // Print message and input digit 1 or 2 (Variant's choice)

ChooseVariant(chosen); // Choose variant and start it

