class Program
{
    // ================= EASY =================
    static async Task<string> GetWeatherAsync()
    {
        await Task.Delay(1500);
        return "Bugun ob-havo: Quyoshli";
    }

    // ================= MEDIUM =================
    static async Task<int> CalculateSumAsync(List<int> numbers)
    {
        await Task.Delay(1000);
        return numbers.Sum();
    }

    // ================= HARD =================
    static List<string> talabalar = new List<string>
    {
        "Ali",
        "Vali",
        "Sardor",
        "Malika",
        "Zulfiya"
    };

    static async Task<string> FindStudentAsync(string name)
    {
        Console.WriteLine("Qidirilmoqda...");
        await Task.Delay(1000);

        string? topilgan = talabalar.FirstOrDefault(
            t => t.Equals(name, StringComparison.OrdinalIgnoreCase));

        return topilgan ?? "Talaba topilmadi";
    }

    // ================= MAIN =================
    static async Task Main(string[] args)
    {
        // EASY
        Console.WriteLine("===== EASY LEVEL =====");
        Console.WriteLine("Ob-havo tekshirilmoqda...");
        string obHavo = await GetWeatherAsync();
        Console.WriteLine(obHavo);

        Console.WriteLine();

        // MEDIUM
        Console.WriteLine("===== MEDIUM LEVEL =====");
        List<int> sonlar = new List<int> { 10, 20, 30, 40, 50 };

        Console.WriteLine("Hisoblanmoqda...");
        int yigindi = await CalculateSumAsync(sonlar);
        Console.WriteLine($"Ro'yxat yig'indisi: {yigindi}");

        Console.WriteLine();

        // HARD
        Console.WriteLine("===== HARD LEVEL =====");

        Console.Write("1-qidiruv: ");
        string natija1 = await FindStudentAsync("Sardor");
        Console.WriteLine($"Natija: {natija1}");

        Console.WriteLine();

        Console.Write("2-qidiruv: ");
        string natija2 = await FindStudentAsync("Jasur");
        Console.WriteLine($"Natija: {natija2}");
    }
}