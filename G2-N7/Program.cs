#region string 
// Mavzu: String

//string ism = "Sherbek";
//string familiya = "Jumabekov";

//Console.WriteLine("Sizning ismingiz: " + ism + "\nSizning familiyangiz: " + familiya);  // concatenation
//Console.WriteLine("\n");
//Console.WriteLine($"Sizning ismingiz: {ism}\nSizning familiyangiz: {familiya}");  // interpolation

//// Malumotlar
//string name = "Oydinoy";
//string emptyString = string.Empty;  // bo'sh string
//string nullString = null;  // null string

//// length
//Console.WriteLine(name.Length); // 7
//Console.WriteLine(emptyString.Length); // 0
//// Console.WriteLine(nullString.Length); // Bu xatolikka olib keladi

//// Katta kichik harflar
//string name = "OzODbeK";
//Console.WriteLine(name.ToUpper());  // OZODBEK
//Console.WriteLine(name.ToLower());  // ozodbek

//// Qidirish - Contains, StartsWith, EndsWith
//string sentence = "C# dasturlash tili juda qulay va kuchli.";

//// Berilgan matn ichida "qulay" so'zi bormi?
//Console.WriteLine(sentence.Contains("qulay"));  // True

//// Matn "C#" bilan boshlanadimi ?
//Console.WriteLine(sentence.StartsWith("C#"));  // True

//// Matn "kuchli." bilan tugaydimi ?
//Console.WriteLine(sentence.EndsWith("kuchli."));  // True


//// Kesish va tozalash
//string sentence = "   Sherbek va Ozodbek qo'shimcha shug'ullanishga umuman kelmayabdi!   ";

//// trim - boshi va oxiridagi bo'sh joylarni olib tashlaydi
//Console.WriteLine(sentence.Trim()); // "Sherbek va Ozodbek qo'shimcha shug'ullanishga umuman kelmayabdi!"

//// trimStart - boshi bo'sh joylarni olib tashlaydi
//Console.WriteLine(sentence.TrimStart()); // "Sherbek va Ozodbek qo'shimcha shug'ullanishga umuman kelmayabdi!   "

//// trimEnd - oxiridagi bo'sh joylarni olib tashlaydi
//Console.WriteLine(sentence.TrimEnd()); // "   Sherbek va Ozodbek qo'shimcha shug'ullanishga umuman kelmayabdi!"


//string str = "Kamolova Oydinoy!";
//// substring - matnning bir qismini kesib olish
//Console.WriteLine(str.Substring(9, 7));  // "Oydinoy"
//Console.WriteLine(str.Substring(4, 4));  // "lova"


// Almashtirish
//string str = "Sherbek va Ozodbek juda zo'r do'stlar!";
//string updated = str.Replace("zo'r", "yomon");
//Console.WriteLine(updated);


//// Bo'lish va Birlashtirish
//string csv = "Sherbek;Ozodbek;Oydinoy;Jasur;Alijon";

//string[] names = csv.Split(';');  // csv stringini ';' bo'yicha bo'lib, string arrayga joylashtiradi

//foreach (var name in names)
//{
//    Console.WriteLine(name);
//}

//// Join - string array elementlarini birlashtirish
//string joined = string.Join(", ", names);
//Console.WriteLine(joined);  // "Sherbek, Ozodbek, Oydinoy, Jasur, Alijon"


//// Formatlash
//string name = "Ozodbek";
//int age = 16;
//double salary = 3200.5432424;

//// string interpolation
//string info1 = $"Ism: {name}, Yoshi: {age}, Maosh: {salary:F2}";
//Console.WriteLine(info1);

//// string.Format
//Console.WriteLine(string.Format("Ism: {0}, Yoshi: {1}, Maosh: {2:F2}", name, age, salary));

//// Tekshirish
//string input = "12345";

//Console.WriteLine(input.All(char.IsDigit));  // input stringidagi barcha belgilar raqam mı? True
//Console.WriteLine(input.Any(char.IsLetter));  // input stringidagi hech bo'lmagan belgi harf mı? False
#endregion



#region masala 1
Console.Write("ismizni kiriting ");



#endregion
