using FirstSection_IntroductionToCSharp.Business;
using FirstSection_IntroductionToCSharp.DataAccess.Concretes;
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

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}
// NOT: Bir dizinin(array) eleman sayısını bulmak için ".Lenght", listenin(list) eleman sayısını bulmak için ".Count" kullanılır. 

Console.WriteLine("Kod Bitti");
Console.WriteLine("__________________________________________________");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.CustomerNumber = "123456";
customer1.FirstName = "Enes";
customer1.LastName = "YALÇIN";
customer1.NationalIdentity = "12345678902";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.CustomerNumber = "123457";
customer2.FirstName = "Sena Betül";
customer2.LastName = "YAZICIOĞLU";
customer2.NationalIdentity = "12345678904";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.CustomerNumber = "123458";
customer3.Name = "Cosmsos Technology";
customer3.TaxNumber = "1234567890";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.CustomerNumber = "123459";
customer4.Name = "Scorpii Technology";
customer4.TaxNumber = "1234567891";


// Value types --> int, bool, double...
int number1 = 10;
int number2 = 20;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);

// Reference types --> Arrays, Classs, Interfaces...
string[] cities1 = { "Ankara", "Kastamonu", "Sinop" };
string[] cities2 = { "Eskişehir", "Samsun", "İstanbul" };


cities2 = cities1;
cities1[0] = "Bursa";
Console.WriteLine(cities2[0]);

Console.WriteLine("__________________________________________________");
                             //101      //102      //103      //104
BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

// Polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}