using N21_HT1;


// Qo'shimcha shart: abstract classdan bevosita obyekt yaratishga urinish
// Oqituvchi o = new Oqituvchi("Ali", 5);
// Xato: abstract classdan obyekt yaratib bo'lmaydi.
// Compiler xabari:
//   CS0144: Cannot create an instance of the abstract class or interface 'Oqituvchi'

// --- List<Oqituvchi> — baza tip orqali polimorfizm ---
List<Oqituvchi> oqituvchilar = new List<Oqituvchi>
        {
            new MatematikaOqituvchi("Jasur Abdulhayev",  12),
            new IngilizTiliOqituvchi("Oydinoy Kamolova",  7),
            new TarixOqituvchi     ("Bonu Kamolova",     3),
        };

Console.WriteLine("========== O'qituvchilar ro'yxati ==========\n");

// foreach + polimorfizm: Tanishtir() ichida to'g'ri FanniAytish() chaqiriladi
foreach (Oqituvchi o in oqituvchilar)
{
    o.Tanishtir();
}

Console.WriteLine("\n============================================");

