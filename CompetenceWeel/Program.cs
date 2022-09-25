// Should help to count points in the Competence Wheel 
// Count begins the position "Extravert" clockwise
Console.Clear();

string programmer = "202013453135443";
string tester = "203013233134352";
string analyst = "302123342354534";
string projManager = "434455545333311";
string prodManager = "334445434232332";

string programmerPoints = "40 for programmer";
string testerPoints = "35 for tester";
string analystPoints = "44 for analyst";
string projManagerPoints = "53 for projManager";
string prodManagerPoints = " for prodManager";

string personal = "322322342444333";
char[] personalChar = personal.ToCharArray();

void test(string profession, string points)
{
   string pointsStr = String.Empty;
   int pointsSum = 0;
   char[] biggerChar = new char[15];
   char[] professionChar = profession.ToCharArray();
   for (int i = 0; i < personal.Length; i++)
   {
      biggerChar[i] = professionChar[i] < personalChar[i] ? professionChar[i] : personalChar[i];
      pointsStr = pointsStr + biggerChar[i];
      pointsSum = pointsSum + biggerChar[i] - 48;
   }
   Console.WriteLine(biggerChar);
   Console.WriteLine($"You've received {pointsSum} points of {points}");
}

test(programmer, programmerPoints);
test(tester, testerPoints);
test(analyst, analystPoints);
test(projManager, projManagerPoints);
test(prodManager, prodManagerPoints);

// var programmer = new Dictionary<int, int>()
// {
// {0,2},   // Экстраверт
// {1,0},   // Наставничество
// {2,2},   // Эмпатия
// {3,0},   // Ораторское искусство
// {4,1},   // Организационные способности
// {5,3},   // Многозадачность
// {6,4},   // Стрессоустойчивость
// {7,5},   // Работа с большим объёмом информации
// {8,3},   // Контраль времени
// {9,1},  // Креативность
// {10,3},  // Критическое мышление
// {11,5},  // Любопытство
// {12,4},  // Аналитические навыки
// {13,4},  // Способность к монотонной работе
// {14,3}   // Интроверт
// };
