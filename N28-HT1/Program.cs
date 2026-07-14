using N28_HT1.Services;
using N28_HT1.Services.Interfaces;

namespace N28_HT1;

class Program
{
    static async Task Main(string[] args)
    {
        IUserService userService = new UserService();
        IEmployeeService employeeService = new EmployeeService(userService);
        IPerformanService performanceService = new PerformanceService(userService);
        IAccountService accountService = new AccountService(userService, employeeService, performanceService);

        // Bir nechta userlar uchun bir vaqtda (parallel) report yaratish.
        // Mutex fayllarga xavfsiz kirishni ta'minlaydi.
        var tasks = new[]
        {
            accountService.CreateReportAsync(1),
            accountService.CreateReportAsync(2)
        };

        await Task.WhenAll(tasks);

        Console.WriteLine("Barcha reportlar tayyor!");
    }
}