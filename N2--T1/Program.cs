
//string name;
//string secondName;
//byte age;

//Console.Write("Ismingizni kiriting: ");
//name = Console.ReadLine();

//Console.Write("Otangizni ismi: ");
//secondName = Console.ReadLine();

//Console.Write("Yoshingizni kiriting: ");
//age = byte.Parse(Console.ReadLine());

//Console.WriteLine($"Ismingiz: {name}, Otangizni ismi: {secondName}, Yoshingiz: {age}");






﻿
#region Primitive Type
using System.Globalization;

int age1 = 24;
uint ageA = 12;
float height = 1.75f;
short temperature = -5;
byte raqam = 0;
long maximumNumber = 9_000_000_000_000_000_000;
float pi = 3.14f;
double e = 2.71828;
decimal price = 200m;
var son = Math.PI;
// Console.WriteLine(age);

int studentCount = 6;
decimal noutbookPrice = 1500.50m;
float avarageAge = 16.0f;
bool isPassed = false;

Console.WriteLine($"O'quvchilar soni: {studentCount}");
Console.WriteLine($"Noutbuklar narxi: {noutbookPrice}");
Console.WriteLine($"Imtixondan o'tganmi: {isPassed}");
#endregion

#region Defination and Initialization
// Defination - E'lon qilish
int yosh;

// Initialization - Qiymat berish
yosh = 24;
#endregion

#region Read and Write
// Read - O'qish
Console.WriteLine("Whats up!");

// Write - Yozish
string name1 = Console.ReadLine();
Console.WriteLine($"Hello, {name1}!");
#endregion

#region Literals or Constants
// Literals - Adadiy qiymatlar
const double PI = 3.14159;
// PI = 3.14; // Error: Cannot assign to 'PI' because it is a 'const'
int number = 23;
number = 34; // This is allowed because 'number' is not a constant
#endregion

#region Complex type
// Complex types - Murakkab tiplar
int[] numbers = { 1, 2, 3, 4, 5 };
string[] names = { "Alijon", "Diyorbek", "Oydinoy", "Sherbek", "Salohiddin", "Asilbek" };

#endregion

#region Rules
// Rules - Qoidalar // Noto'g'ri elon qilishlar
// int 1number = 10; // Error: Identifiers cannot start with a digit   
// string first-name = "Alijon"; // Error: Identifiers cannot contain hyphens
// int long = 232333; // This is allowed but not recommended because 'long' is a keyword in C#


// To'g'ri elon qilishlar
int number1 = 10;
string firstName = "bonu";
bool isActive = true;
#endregion

// Bir qatorli comment  

/*
 Ko'p qatorli
comment
 */
