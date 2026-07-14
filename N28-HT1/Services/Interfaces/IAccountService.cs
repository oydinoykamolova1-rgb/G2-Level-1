namespace N28_HT1.Services.Interfaces;

public interface IAccountService
{
    // Berilgan user uchun report fayl yaratadi va ichini to'ldiradi
    Task CreateReportAsync(int id);
}