
string filePath = "D:\\IT beck end\\backend\\G2-Level-1\\N27-HT1\\Talabalr.txt";
bool running = true;

while (true)
{
    Console.WriteLine("=== Talabalar royxati ===");
    Console.WriteLine("1.Yangi talaba qoshish/");
    Console.WriteLine("2.Barcha talabalrni korish");
    Console.WriteLine("3. Chiqish");
    Console.WriteLine("Tanlovingiz");

    string tanlov = Console.ReadLine();


    switch (tanlov)
    {
        case "1":
            Console.Write("Talabaning ismini kiriting:");
            string name = Console.ReadLine() ?? "";

            Console.WriteLine("yoshi:");
            string yosh = Console.ReadLine() ?? "";

            Console.WriteLine("Gruxi:");
            string Grux = Console.ReadLine() ?? "";

            string qator = $"{name},{yosh},{Grux}";
            File.AppendAllText(filePath, qator + Environment.NewLine);


            Console.WriteLine("Talaba qoshildi!");
            break;



        case "2":
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Talabalar royxati mavjud emas.");
                break;
            }

            string[] qatorlar = File.ReadAllLines(filePath);

            if (qatorlar.Length == 0)
            {
                Console.WriteLine("royxat hal bosh");
                break;
            }

            Console.WriteLine("=== Talabalar royxati ===");
            for (int i = 0; i < qatorlar.Length; i++)
            {
                string[] qisimlar = qatorlar[i].Split(',');
                if (qisimlar.Length == 3)
                {
                    string talabaIsmi = qisimlar[0];
                    string talabaYoshi = qisimlar[1];
                    string talabaGruxi = qisimlar[2];
                    Console.WriteLine($"Talaba {i + 1}: Ism: {talabaIsmi}, Yoshi: {talabaYoshi}, Gruxi: {talabaGruxi}");
                }
            }
            break;



        case "3":
            running = false;
            break;

        default:
            Console.WriteLine("Natori tanlov iltimos qayta urinib koring ");
            break;



    }

    if (!running)
        break;

}

Console.WriteLine("Dasturdan chiqishi amlaga oshirildi.DASTURNI YOPISH UCHUN ENTER TUGMASINI BOSING");