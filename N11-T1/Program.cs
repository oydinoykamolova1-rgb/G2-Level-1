// bu yerda funksiyaga nusxa sifatida yuboriladi va funksiyada o'zgartiriladi, lekin tashqi o'zgaruvchi o'zgarmaydi
//void AddOne(int son)
//{
//    son++;
//}

//int x = 10;

//AddOne(x);
//Console.WriteLine($"x = {x}");


// ref - kalit sozli funksiya ichida o'zgaruvchini nusxa sifatida emas, balki o'zgaruvchining manzilini yuboradi.
// Shuning uchun funksiya ichida o'zgartirilgan qiymat tashqi o'zgaruvchiga ham ta'sir qiladi.

//void AddOne(ref int son)
//{
//    son++;
//}

//int y = 12;

//AddOne(ref y);
//Console.WriteLine($"y = {y}");

// oddiy bo'lsa - nusxasini yuboradi
// ref - "menga o'zgaruvchini o'zini ber, nusxasini emas!"

//// Amaliy masala (Pul yechish)
//void PulYechish(ref double balans, double miqdor)
//{
//    if (balans >= miqdor)
//    {
//        balans -= miqdor;
//        Console.WriteLine($"{miqdor} so'm pul yechildi. Qoldiq : {balans} so'm");
//    }
//    else
//    {
//        Console.WriteLine("Hisobda mablag' yetarli emas!");
//    }
//}

//void PulQoshish(ref double balans, double miqdor)
//{
//    balans += miqdor;
//    Console.WriteLine($"{miqdor} so'm pul qo'shildi. Balans : {balans} so'm");
//}

//double meningHisobim = 5_000_000;

//PulQoshish(ref meningHisobim, 200_000);  // 5_200_000 ming
//PulYechish(ref meningHisobim, 1_000_000);  // 4_200_000 ming
//PulYechish(ref meningHisobim, 5_000_000);  // Hisobda mablag' yetarli emas!



//// Params - holati funksiyalarda

//// Har hil sondagi argumentlar uchun alohida funksiya yozamiz

//int Add5(int a, int b) => a + b;
//int Add3(int a, int b, int c) => a + b + c;
//int Add4(int a, int b, int c, int d) => a + b + c + d;

//int Add(params int[] sonlar)
//{
//    int sum = 0;
//    for (int i = 0; i < sonlar.Length; i++)
//    {
//        sum += sonlar[i];
//    }

//    return sum;
//}

//Console.WriteLine(Add(1, 2, 3, 4, 5));
//Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 14, 15, 16));

//// Array ham uzatsa bo'ladi
//int[] sonlarArrayi = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//Console.WriteLine(Add(sonlarArrayi));


// masala restoran hisobi
//void CheckHisoblash(string mijozIsmi, params double[] buyurtmalar)
//{
//    double jami = 0;
//    Console.WriteLine($"\n === {mijozIsmi} ning hisob-kitobi ===");

//    for (int i = 0; i < buyurtmalar.Length; i++)
//    {
//        Console.WriteLine($" Buyurtma {i + 1}: {buyurtmalar[i]} so'm");
//        jami += buyurtmalar[i];
//    }

//    double soliq = jami * 0.12; // 12% QQS
//    Console.WriteLine($" Soliq : {soliq} so'm");
//    Console.WriteLine($" Jami : {jami + soliq} so'm");
//}

//CheckHisoblash("Oydinoy", 45_000, 30_000, 250_000);
//CheckHisoblash("Iqbol", 60_000, 40_000);
//CheckHisoblash("Alijon", 100_000, 50_000, 75_000);