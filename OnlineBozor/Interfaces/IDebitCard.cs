namespace OnlineBozor.Interfaces
{
    public interface IDebitCard
    {
        string CardNumber { get; }
        string BankName { get; init; }
        decimal Balance { get; set; }
    }
}