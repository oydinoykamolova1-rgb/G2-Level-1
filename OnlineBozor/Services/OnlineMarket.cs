using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using OnlineBozor.Interfaces;
using OnlineBozor.Models;

namespace OnlineBozor.Services
{
    public class OnlineMarket
    {
        private readonly IPaymentProvider _provider;
        private readonly List<Product> _products = new();

        // "Do'kon" hisobiga tushadigan mablag' shu kartaga tushadi deb hisoblaymiz
        private readonly IDebitCard _marketCard = new KapitalUzcard("0000-0000-0000-0000", 0);

        // Boshqa fayldagi (PrintTransactionHistory.cs) klass ham shu nomdan foydalanadi
        public const string TransactionsFile = "tranzaksiyalar.txt";

        public OnlineMarket(IPaymentProvider provider)
        {
            _provider = provider;
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Buy(string name, int number, IDebitCard card)
        {
            Product? product = _products.FirstOrDefault(p =>
                p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (product is null)
            {
                Console.WriteLine($"Xatolik: '{name}' nomli mahsulot topilmadi.");
                return;
            }

            if (number <= 0)
            {
                Console.WriteLine("Xatolik: mahsulot soni musbat bo'lishi kerak.");
                return;
            }

            decimal totalPrice = product.Price * number;

            try
            {
                _provider.Transfer(card, _marketCard, totalPrice);

                string line = string.Join('|',
                    DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                    product.Name,
                    number,
                    totalPrice.ToString("F2", CultureInfo.InvariantCulture),
                    card.CardNumber);

                File.AppendAllText(TransactionsFile, line + Environment.NewLine);

                Console.WriteLine($"Xarid muvaffaqiyatli: {number} x \"{product.Name}\" = {totalPrice:N2} so'm.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Xarid amalga oshmadi: {ex.Message}");
            }
        }
    }
}