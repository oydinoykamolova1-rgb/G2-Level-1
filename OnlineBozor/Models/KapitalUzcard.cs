using OnlineBozor.Interfaces;

namespace OnlineBozor.Models
{
    public class KapitalUzcard : IDebitCard
    {
        public string CardNumber { get; }
        public string BankName { get; init; }
        public decimal Balance { get; set; }

        public KapitalUzcard(string cardNumber, decimal balance)
        {
            CardNumber = cardNumber;
            BankName = "Kapitalbank (Uzcard)";
            Balance = balance;
        }
    }
}