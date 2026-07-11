using System;
using OnlineBozor.Interfaces;
using OnlineBozor.Models;
using OnlineBozor.Services;

// 1) Payment provider tanlaymiz (Uzum, 1.5% komissiya bilan)
IPaymentProvider provider = new UzumPaymentProvider(1.5m);

// 2) OnlineMarket servisini shu provider bilan yaratamiz
var market = new OnlineMarket(provider);

// 3) Mahsulotlar qo'shamiz
market.Add(new Product("Noutbuk", 8_500_000));
market.Add(new Product("Sichqoncha", 150_000));
market.Add(new Product("Klaviatura", 250_000));
market.Add(new Product("Naushnik", 400_000));

// 4) Karta yaratamiz
IDebitCard myCard = new KapitalUzcard("8600-1234-5678-9012", 10_000_000);

Console.WriteLine("===== Xaridlar =====");
Console.WriteLine($"Boshlang'ich balans: {myCard.Balance:N2} so'm ({myCard.BankName})");
Console.WriteLine();

// 5) Bir nechta xarid amalga oshiramiz
market.Buy("Noutbuk", 1, myCard);
market.Buy("Sichqoncha", 2, myCard);
market.Buy("Klaviatura", 1, myCard);

// Yetarli mablag' bo'lmagan holatni sinash uchun
market.Buy("Noutbuk", 5, myCard);

// Mavjud bo'lmagan mahsulotni sinash uchun
market.Buy("Monitor", 1, myCard);

// 6) Kartada qolgan summani chiqaramiz
Console.WriteLine();
Console.WriteLine($"Kartada qolgan balans: {myCard.Balance:N2} so'm");

// 7) Tranzaksiyalar tarixini fayldan o'qib chiqaramiz
PrintTransactionHistory.Show();