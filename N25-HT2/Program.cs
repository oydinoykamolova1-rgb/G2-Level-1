class Program
{
    static async Task<string> GetNameAsync()
    {
        await Task.Delay(1000); // 1 soniya kutish
        return "Aziz";
    }

    static async Task<int> GetAgeAsync()
    {
        await Task.Delay(800);
        return 25;
    }

    static async Task<string> GetCityAsync()
    {
        await Task.Delay(1200);
        return "Toshkent";
    }

    static async Task<List<string>> GetLongCityNamesAsync(List<string> cities)
    {
        await Task.Delay(1000); // ma'lumot yuklanishini kutish

        // LINQ orqali nomi 5 harfdan uzun shaharlarni tanlaymiz
        List<string> longNames = cities
            .Where(city => city.Length > 5)
            .ToList();

        return longNames;
    }

    static async Task Main(string[] args)
    {
        // First demo
        Console.WriteLine("Ma'lumotlar yuklanmoqda...");

        string name = await GetNameAsync();
        Console.WriteLine($"Ism: {name}");

        int age = await GetAgeAsync();
        Console.WriteLine($"Yosh: {age}");

        string city = await GetCityAsync();
        Console.WriteLine($"Shahar: {city}");

        Console.WriteLine("Barcha ma'lumotlar yuklandi!");

        // Second demo
        List<string> cities = new List<string>
        {
            "Toshkent", "Buxoro", "Xiva", "Namangan",
            "Andijon", "Nukus", "Termiz", "Samarqand"
        };

        Console.WriteLine("Shaharlar ro'yxati yuklanmoqda...");

        List<string> longCityNames = await GetLongCityNamesAsync(cities);

        Console.WriteLine("Nomi 5 harfdan uzun shaharlar:");
        foreach (var c in longCityNames)
        {
            Console.WriteLine($"- {c}");
        }
    }
}
