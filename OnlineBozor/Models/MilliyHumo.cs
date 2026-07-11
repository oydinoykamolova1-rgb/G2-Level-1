using OnlineBozor.Interfaces;

namespace OnlineBozor.Models
{
    public class MilliyHumo : IDebitCard
    {
        public string CardNumber { get; }
        public string BankName { get; init; }
        public decimal Balance { get; set; }

        public MilliyHumo(string cardNumber, decimal balance)
        {
            CardNumber = cardNumber;
            BankName = "Milliy Bank (Humo)";
            Balance = balance;
        }
    }
}