
#region 1 masala
//Console.Write("ismizni kiriting: ");
//string ism = Console.ReadLine();

//ism = ism.Trim();
//ism = char.ToUpper(ism[0]) + ism.Substring(1).ToLower();

//Console.WriteLine(ism);
#endregion

#region 2 masala
//Console.Write("loginizni kiriting: ");
//string login = Console.ReadLine();

//if (login.ToLower() == "admin")
//{
//    Console.WriteLine("Xush kelibsiz!");
//}
//else
//{
//    Console.WriteLine("Noto'g'ri login");
//}
#endregion

#region 3 masala
//Console.Write("so`z kiriting: ");
//string jumla = Console.ReadLine();

//string[] sozlar = jumla.Split(' ');

//Console.WriteLine(sozlar.Length + " ta so'z");

#endregion

#region masala 4
//Console.Write("email kiriting: ");
//string email = Console.ReadLine();

//bool atBor = email.Contains("@");
//bool comBilan = email.EndsWith(".com");

//if (atBor && comBilan)
//{
//    Console.WriteLine("To'g'ri");
//}
//else if (!atBor)
//{
//    Console.WriteLine("@ yo'q");
//}
//else
//{
//    Console.WriteLine(".com bilan tugamaydi");
//}
#endregion

#region masala 5
//Console.Write("parol kiriting: ");
//string parol = Console.ReadLine();

//string yulduzlar = new string('*', parol.Length);

//Console.WriteLine(yulduzlar);
#endregion

#region masala 6
//Console.Write("soz kiriting: ");
//string kirish = Console.ReadLine();

//string[] ismlar = kirish.Split(',');

//for (int i = 0; i < ismlar.Length; i++)
//{
//    Console.WriteLine((i + 1) + ". " + ismlar[i]);
//}
#endregion

#region masala 7
//Console.Write("soz kiriting: ");
//string soz = Console.ReadLine();

//char[] harflar = soz.ToCharArray();

//Array.Reverse(harflar);

//string natija = new string(harflar);

//Console.WriteLine(natija);
#endregion

#region masala 8
//Console.Write("soz kiriting: ");
//string soz = Console.ReadLine();
//string takrorlangan = "";

//for (int i = 0; i < soz.Length; i++)
//{
//    char harf = soz[i];

//    // Bu harf oldin chiqganmi? Yo'q bo'lsa tekshir
//    if (soz.IndexOf(harf) != i && !takrorlangan.Contains(harf.ToString()))
//    {
//        takrorlangan += harf + ", ";
//    }
//}

//Console.WriteLine("Takrorlangan: " + takrorlangan.TrimEnd(',', ' '));
#endregion

#region masala 9
//Console.Write("soz kiriting: ");
//string jumla = Console.ReadLine();

//string[] sozlar = jumla.Split(' ');

//for (int i = 0; i < sozlar.Length; i++)
//{
//    sozlar[i] = char.ToUpper(sozlar[i][0]) + sozlar[i].Substring(1).ToLower();
//}

//string natija = string.Join(" ", sozlar);
//Console.WriteLine(natija);
#endregion

#region masala 10
//Console.Write("parol kiriting: ");
//string parol = Console.ReadLine();

//int ball = 0;

//if (parol.Length >= 8)
//    ball++;

//if (parol.ToLower() != parol)   // katta harf bor
//    ball++;

//bool raqamBor = false;
//foreach (char c in parol)
//{
//    if (char.IsDigit(c))
//    {
//        raqamBor = true;
//        break;
//    }
//}
//if (raqamBor)
//    ball++;

//if (ball <= 1)
//    Console.WriteLine("Kuchsiz");
//else if (ball == 2)
//    Console.WriteLine("O'rtacha");
//else
//    Console.WriteLine("Kuchli");
#endregion