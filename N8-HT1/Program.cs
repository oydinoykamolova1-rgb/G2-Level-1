#region 1 masala
//string ism, familiya;
//int yosh;

//Console.Write("Ismingizni kiriting: ");
//ism = Console.ReadLine().Trim();

//Console.Write("Familiyangizni kiriting: ");
//familiya = Console.ReadLine().Trim();

//Console.Write("Yoshingizni kiriting: ");
//yosh = int.Parse(Console.ReadLine().Trim());

//Console.WriteLine($"Ismingiz: {ism}, Familiyangiz: {familiya}, Yoshingiz: {yosh}");
#endregion
#region 2 masala
//string jumla;

//Console.Write("Jumla kiriting: ");
//jumla = Console.ReadLine().Trim();
//string[] sozlar = jumla.Split(' ');
//for (int i = 0; i < sozlar.Length; i++)
//{
//    char[] harflar = sozlar[i].ToCharArray();
//    Array.Reverse(harflar);
//    sozlar[i] = new string(harflar);
//}
//string natija = string.Join(" ", sozlar);

//Console.WriteLine($"Natija: {natija}");
#endregion 
#region 3 masala
//using System;
//using System.Text;

//StringBuilder jadval = new StringBuilder();

//for (int i = 1; i <= 5; i++)
//{
//    for (int j = 1; j <= 5; j++)
//    {
//        jadval.AppendLine($"{i} x {j} = {i * j}");
//    }
//}

//Console.WriteLine(jadval.ToString());
#endregion
#region 4 masala
using System;
using System.Text;

string text = "  C#   juda   zo'r   til.   Har   kun   mashq   qil!  ";

string[] sozlar = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine($"So'zlar soni: {sozlar.Length}");

StringBuilder natija = new StringBuilder();

foreach (string soz in sozlar)
{
    natija.AppendLine(soz);
}
Console.WriteLine(natija.ToString());
#endregion
