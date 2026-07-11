using System.Globalization;

string filePath = "D:\\IT beck end\\backend\\G2-Level-1\\N27-T1\\Xarajatlar.txt";
bool running = true;

while (running)
{
    Console.WriteLine("\n=== XARAJATLAR KUNDALIGI ===");
    Console.WriteLine("1. Yangi harajat qo'shish.");
    Console.WriteLine("2. Barcha harajatlarni ko'rish.");
    Console.WriteLine("3. Umumiy summani hisoblash.");
    Console.WriteLine("4. Eng katta xarajatni topish.");
    Console.WriteLine("5. Chiqish.");
    Console.Write("Tanlovingiz: ");

    string? tanlov = Console.ReadLine();

    switch (tanlov)
    {
        case "1":
            Console.Write("Xarajat nomi (masalan, Ovqat): ");
            string nomi = Console.ReadLine() ?? "";

            Console.Write("Summasi: ");
            string summaMatn = Console.ReadLine() ?? "";

            if (!double.TryParse(summaMatn, NumberStyles.Any, CultureInfo.InvariantCulture, out double summa))
            {
                Console.WriteLine("Summa noto'g'ri kiritildi. Son bo'lishi kerak!");
                break;
            }

            string sana = DateTime.Now.ToString("yyyy-WW-dd HH-mm");
            string qator = $"{nomi}|{summa}|{sana}";

            File.AppendAllText(filePath, qator + Environment.NewLine);
            Console.WriteLine("Xarajat qo'shildi!");
            break;

        case "2":
            if (!File.Exists(filePath) || File.ReadAllLines(filePath).Length == 0)
            {
                Console.WriteLine("Xarajatlar ro'yxati mavjud emas.");
                break;
            }
            string[] qatorlar = File.ReadAllLines(filePath);
            if (qatorlar.Length == 0)
            {
                Console.WriteLine("Ro'yhat hali bo'sh.");
                break;
            }
            Console.WriteLine("\n=== XARAJATLAR RO'YXATI ===");
            for (int i = 0; i < qatorlar.Length; i++)
            {
                string[] qismlar = qatorlar[i].Split('|');
                if (qismlar.Length < 3)
                    continue;
                string xarajatNomi = qismlar[0];
                string xarajatSummasi = qismlar[1];
                string xarajatSana = qismlar[2];
                Console.WriteLine($"{i + 1}. Nomi: {xarajatNomi}, Summasi: {xarajatSummasi}, Sana: {xarajatSana}");
            }
            break;

        case "3":
            if (!File.Exists(filePath) || File.ReadAllLines(filePath).Length == 0)
            {
                Console.WriteLine("Xarajatlar ro'yxati mavjud emas.");
                break;
            }

            double jamiSumma = 0;
            foreach (string q in File.ReadAllLines(filePath))
            {
                string[] qismlar = q.Split('|');
                if (qismlar.Length < 3)
                    continue;
                if (double.TryParse(qismlar[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double s))
                {
                    jamiSumma += s;
                }
            }

            Console.WriteLine($"Umumiy summa: {jamiSumma}");
            break;


        case "4":
            if (!File.Exists(filePath) || File.ReadAllLines(filePath).Length == 0)
            {
                Console.WriteLine("Xarajatlar ro'yxati mavjud emas.");
                break;
            }
            double engKattaSumma = double.MinValue;
            string engKattaXarajat = "";
            foreach (string q in File.ReadAllLines(filePath))
            {
                string[] qismlar = q.Split('|');
                if (qismlar.Length < 3)
                    continue;
                if (double.TryParse(qismlar[1], NumberStyles.Any, CultureInfo.InvariantCulture, out double s))
                {
                    if (s > engKattaSumma)
                    {
                        engKattaSumma = s;
                        engKattaXarajat = qismlar[0];
                    }
                }
            }
            if (engKattaSumma == double.MinValue)
            {
                Console.WriteLine("Xarajatlar ro'yxati bo'sh.");
            }
            else
            {
                Console.WriteLine($"Eng katta xarajat: {engKattaXarajat} - {engKattaSumma}");
            }
            break;

        case "5":
            running = false;
            break;

        default:
            Console.WriteLine("Noto'g'ri tanlov! Iltimos, 1 dan 5 gacha bo'lgan raqamni kiriting.");
            break;
    }
}

Console.WriteLine("Dastur tugatildi.");
