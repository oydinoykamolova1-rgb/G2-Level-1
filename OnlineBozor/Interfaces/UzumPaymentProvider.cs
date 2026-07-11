using System;

namespace OnlineBozor.Interfaces
{
    public class UzumPaymentProvider : IPaymentProvider
    {
        public decimal TransferInterest { get; init; }

        public UzumPaymentProvider(decimal transferInterest)
        {
            TransferInterest = transferInterest;
        }

        public void Transfer(IDebitCard sourceCard, IDebitCard destinationCard, decimal amount)
        {
            decimal totalAmount = amount + (amount * TransferInterest / 100);

            if (sourceCard.Balance < totalAmount)
                throw new InvalidOperationException(
                    $"[Uzum] Balansda mablag' yetarli emas. Kerak: {totalAmount:N2}, Mavjud: {sourceCard.Balance:N2}");

            sourceCard.Balance -= totalAmount;
            destinationCard.Balance += amount;

            Console.WriteLine($"[Uzum] {totalAmount:N2} so'm '{sourceCard.CardNumber}' kartasidan yechildi " +
                               $"(shu jumladan {TransferInterest}% komissiya).");
        }
    }
}