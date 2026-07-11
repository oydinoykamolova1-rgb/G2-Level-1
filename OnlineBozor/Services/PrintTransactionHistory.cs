using System;
using System.Globalization;
using System.IO;

namespace OnlineBozor.Services
{
    public static class PrintTransactionHistory
    {
        public static void Show()
        {
            Console.WriteLine();
            Console.WriteLine("===== Tranzaksiyalar tarixi =====");

            if (!File.Exists(OnlineMarket.TransactionsFile))
            {
                Console.WriteLine("Hozircha hech qanday tranzaksiya mavjud emas.");
                return;
            }

            string[] lines = File.ReadAllLines(OnlineMarket.TransactionsFile);

            if (lines.Length == 0)
            {
                Console.WriteLine("Hozircha hech qanday tranzaksiya mavjud emas.");
                return;
            }

            Console.WriteLine($"{"Sana",-20} | {"Mahsulot",-15} | {"Soni",-5} | {"Summa",-12} | Karta raqami");
            Console.WriteLine(new string('-', 75));

            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length != 5) continue;

                string date = parts[0];
                string productName = parts[1];
                string count = parts[2];
                string total = decimal.Parse(parts[3], CultureInfo.InvariantCulture).ToString("N2");
                string cardNumber = parts[4];

                Console.WriteLine($"{date,-20} | {productName,-15} | {count,-5} | {total,-12} | {cardNumber}");
            }
        }
    }
}