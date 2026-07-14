using N28_HT1.Models;
using N28_HT1.Services.Interfaces;
using System.Collections.Concurrent;

namespace N28_HT1.Services;

public class PerformanceService : IPerformanService
{
    private readonly IUserService _userService;

    // Har bir fayl uchun alohida semafor - ConcurrentDictionary orqali
    private static readonly ConcurrentDictionary<string, SemaphoreSlim> _fileLocks = new();

    public PerformanceService(IUserService userService)
    {
        _userService = userService;
    }

    public async Task ReportPerformanceAsync(int id)
    {
        User user = _userService.GetById(id);
        string filePath = EmployeeService.GetFilePath(user);

        SemaphoreSlim semaphore = _fileLocks.GetOrAdd(filePath, _ => new SemaphoreSlim(1, 1));

        await semaphore.WaitAsync();
        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException(
                    $"Fayl topilmadi: {filePath}. Avval CreatePerformanceRecordAsync chaqirilishi kerak.");
            }

            await File.AppendAllTextAsync(filePath, "All good :)" + Environment.NewLine);
            Console.WriteLine($"[PerformanceService] Faylga yozildi: {filePath}");
        }
        finally
        {
            semaphore.Release();
        }
    }
}