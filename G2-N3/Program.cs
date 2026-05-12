

//#region Xotira haqida malumot
////// Stack xotirada joylashadi
////int age = 25;
////double height = 1.75;

//// Stack xotira bu yengil va tezkor ozgaruvchilarni saqlash uchun ishlatilinadi va hajmi 1-2 mb oshmaydi. Stack xotira avtomatik ravishda boshqariladi va ozgaruvchilar stackga joylashtiriladi va undan olinadi. Stack xotira tezkor ishlaydi, ammo uning hajmi cheklangan.

////Value Type nima?

////Value Type — qiymatning o‘zi saqlanadi.

////Odatda stack’da yashaydi.

////Misollar:
////int
////double
////bool
////char
////decimal
////DateTime
////struct
////Enum

////2.Reference Type nima?

////Reference Type — object’ning address’i saqlanadi.

////Object’ning o‘zi heap’da bo‘ladi.

////Misollar:
////class
////string
////array
////delegate
////interface
////object

//int a = 10;
//int b = a; // b ning qiymati a ning qiymatiga teng, yani 10
//a = 12; // a ning qiymati 12 ga o'zgartiriladi, lekin b ning qiymati o'zgarmaydi, chunki b a ning qiymatini nusxaladi, yani 10

//Console.WriteLine($"a: {a}, b: {b}");

//string str1 = "Hello";
//string str2 = str1; // str2 ning qiymati str1 ning qiymatiga teng, yani "Hello"
//str2 = "World";
//Console.WriteLine($"str1: {str1}, str2: {str2}");
//#endregion

//#region Operatorlar haqida malumot - Arifmetik
//// Arifmetik operatorlar: +, -, *, /, %
//// Taqqoslash operatorlari: ==, !=, >, <, >=, <=
//// Mantiqiy operatorlar: &&, ||, !
//// Shart operatorlari: ?:
//// Tanlash operatorlari: if, switch
//// Takrorlash operatorlari: for, while, do-while
//// O'tish operatorlari: break, continue, return

////// Arifmetik operatorlar: +, -, *, /, %
////Console.Write("\nBirinchi sonni kiriting: ");
////double num1 = double.Parse(Console.ReadLine());

////Console.Write("Ikkinchi sonni kiriting: ");
////double num2 = double.Parse(Console.ReadLine());

////Console.WriteLine($"Yig'indisi: {num1 + num2}");
////Console.WriteLine($"Ayirma: {num1 - num2}");
////Console.WriteLine($"Ko'paytma: {num1 * num2}");
////Console.WriteLine($"Bo'linma: {num1 / num2}");
////Console.WriteLine($"Qoldiq: {num1 % num2}");

//#endregion

//#region Oeratorlar - If-else

//// && - va operatori, ikkala shart ham to'g'ri bo'lishi kerak
//// || - yoki operatori, kamida bitta shart to'g'ri bo'lishi kerak

//Console.Write("\nYoshingizni kiriting: ");
//int age = int.Parse(Console.ReadLine());

//// Ternary operator yordamida voyaga yetganlik shartini tekshirish
//bool isAdult = age >= 18 && age <= 60; // Voyaga yetganlik sharti

//string voyagaYetganmi = age >= 18 && age <= 60 ? "Voyaga yetgan!" : "Voyaga yetmagan yoki keksaygan!";


////if (age < 18)
////{
////    Console.WriteLine("Voyaga yetmagan!");
////}
////else if (age > 18 && age < 60)
////{
////    Console.WriteLine("Voyaga yetgan!");
////}
////else
////{
////    Console.WriteLine("Keksaygan!\n");
////}



//#endregion   



#region kalkulator



//int a, b;

//Console.Write("1-son: ");
//a = Convert.ToInt32(Console.ReadLine());

//Console.Write("2-son: ");
//b = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Qo‘shish: " + (a + b));
//Console.WriteLine("Ayirish: " + (a - b));
//Console.WriteLine("Ko‘paytirish: " + (a * b));
//Console.WriteLine("Bo‘lish: " + (a / b));





#endregion


#region task 2


//int son;

//Console.Write("Son kiriting: ");
//son = Convert.ToInt32(Console.ReadLine());

//if (son % 2 == 0)
//{
//    Console.WriteLine("Juft son");
//}
//else
//{
//    Console.WriteLine("Toq son");
//}



#endregion

#region task 3



//int a, b;

//Console.Write("1-sonni kiriting: ");
//a = Convert.ToInt32(Console.ReadLine());

//Console.Write("2-sonni kiriting: ");
//b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("1-son katta");
//}
//else if (b > a)
//{
//    Console.WriteLine("2-son katta");
//}
//else
//{
//    Console.WriteLine("Ikkala son teng");
//}

#endregion

#region task 4



//const string parol = "12345";

//Console.Write("Parolni kiriting: ");
//string kirilganParol = Console.ReadLine();

//string natija = (kirilganParol == parol)
//    ? "Tizimga muvaffaqqiyatli kirdingiz"
//    : "Noto'g'ri parol";

//Console.WriteLine(natija);


#endregion

#region task 5


//int matematika;
//int ingliz;

//Console.Write("Matematika balini kiriting: ");
//matematika = Convert.ToInt32(Console.ReadLine());

//Console.Write("Ingliz tili balini kiriting: ");
//ingliz = Convert.ToInt32(Console.ReadLine());

//if (matematika >= 70 || ingliz >= 70)
//{
//    Console.WriteLine("Imtihondan o'tdingiz");
//}
//else
//{
//    Console.WriteLine("Imtihondan yiqildingiz");
//}
#endregion

#region task 6


//int ball;

//Console.Write("Imtihon balini kiriting: ");
//ball = Convert.ToInt32(Console.ReadLine());

//if (ball >= 90)
//{
//    Console.WriteLine("5 baho");
//}
//else if (ball >= 70)
//{
//    Console.WriteLine("4 baho");
//}
//else if (ball >= 50)
//{
//    Console.WriteLine("3 baho");
//}
//else
//{
//    Console.WriteLine("2 baho");
//}




#endregion

#region task 7

//int son;

//Console.Write("Son kiriting: ");
//son = Convert.ToInt32(Console.ReadLine());

//if (son > 0)
//{
//    Console.WriteLine("Musbat son");
//}
//else if (son < 0)
//{
//    Console.WriteLine("Manfiy son");
//}
//else
//{
//    Console.WriteLine("Bu nol");
//}


#endregion


