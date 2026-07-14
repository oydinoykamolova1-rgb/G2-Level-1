using N28_HT1.Models;
using N28_HT1.Services.Interfaces;

namespace N28_HT1.Services;

public class AccountService : IAccountService
{
    private readonly IUserService _userService;
    private readonly IEmployeeService _employeeService;
    private readonly IPerformanService _performanceService;

    public AccountService(
        IUserService userService,
        IEmployeeService employeeService,
        IPerformanService performanceService)
    {
        _userService = userService;
        _employeeService = employeeService;
        _performanceService = performanceService;
    }

    // Berilgan user uchun report fayl yaratadi va uni to'ldiradi.
    // EmployeeService fayl yaratgach, ContinueWith orqali darhol
    // PerformanceService ishga tushadi - ishni tezroq va oqimli bajarish uchun.
    public Task CreateReportAsync(int id)
    {
        User user = _userService.GetById(id);
        Console.WriteLine($"[AccountService] Report jarayoni boshlandi: {user.FullName}");

        return _employeeService.CreatePerformanceRecordAsync(id)
            .ContinueWith(async createTask =>
            {
                if (createTask.IsFaulted)
                {
                    Console.WriteLine(
                        $"[AccountService] Xatolik: {createTask.Exception?.InnerException?.Message}");
                    return;
                }

                await _performanceService.ReportPerformanceAsync(id);
                Console.WriteLine($"[AccountService] Report jarayoni tugadi: {user.FullName}");
            })
            .Unwrap();
    }
}