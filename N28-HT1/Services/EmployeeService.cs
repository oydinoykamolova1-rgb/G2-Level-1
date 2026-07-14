using N28_HT1.Models;
using N28_HT1.Services.Interfaces;

namespace N28_HT1.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IUserService _userService;
    private static readonly string ReportsFolder = "Reports";

    public EmployeeService(IUserService userService)
    {
        _userService = userService;

        if (!Directory.Exists(ReportsFolder))
            Directory.CreateDirectory(ReportsFolder);
    }

    // Boshqa servicelar ham shu yo'ldan foydalanadi (fayl nomi = user.FullName)
    public static string GetFilePath(User user)
    {
        return Path.Combine(ReportsFolder, $"{user.FullName}.txt");
    }

    // Berilgan userni FullName bilan fayl yaratadi
    public async Task CreatePerformanceRecordAsync(int id)
    {
        User user = _userService.GetById(id);
        string filePath = GetFilePath(user);

        // Fayl nomiga bog'liq mutex - PerformanceService bilan bir vaqtda
        // shu faylga murojaat qilinmasligi uchun
        string mutexName = $"PerfFile_{user.FullName.Replace(" ", "_")}";
        using (var mutex = new Mutex(false, mutexName))
        {
            mutex.WaitOne();
            try
            {
                if (!File.Exists(filePath))
                {
                    await File.WriteAllTextAsync(filePath, string.Empty);
                    Console.WriteLine($"[EmployeeService] Fayl yaratildi: {filePath}");
                }
                else
                {
                    Console.WriteLine($"[EmployeeService] Fayl allaqachon mavjud: {filePath}");
                }
            }
            finally
            {
                mutex.ReleaseMutex();
            }
        }
    }
}