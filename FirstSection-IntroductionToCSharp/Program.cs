using FirstSection_IntroductionToCSharp.Business;
using FirstSection_IntroductionToCSharp.Entities;

Console.WriteLine("Hello, World!");

Console.WriteLine("__________________________________________________");
string message1 = "Krediler";
int term = 12;
double amount = 100000;

// Variables --> camelCase
bool isAuthenticated = false;

Console.WriteLine(message1);

// Condition
if (isAuthenticated)
{
    Console.WriteLine("Buton --> Hoşgeldin Enes");
}
else
{
    Console.WriteLine("Buton --> Sisteme Giriş Yap");
}

string kredi1 = "Kredi 1";
string kredi2 = "Kredi 2";
string kredi3 = "Kredi 3";
string kredi4 = "Kredi 4";
string kredi5 = "Kredi 5";

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5" };
// string[] loans = new string[5];
// loans[0] = "Kredi 1";

//start    //condition       //increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

Console.WriteLine("__________________________________________________");
CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " --> " + courses[i].Price);
}