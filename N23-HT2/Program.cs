// C# 12+ Collection expressions: massivni zamonaviy usulda e'lon qilish
int[] baholar = [0, 0, 0, 0, 0];
int yigindi = 0;

Console.WriteLine("5 ta fan bo'yicha baholarni kiriting (0 dan 100 gacha):");

for (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1}-fan bahosini kiriting: ");

    try
    {
        string? input = Console.ReadLine();
        int baho = int.Parse(input ?? throw new FormatException());

        // C# 9+ Relational patterns: oraliqni tekshirish
        if (baho is < 0 or > 100)
        {
            // Talabga binoan throw orqali istisno (exception) hosil qilish
            throw new Exception("Baho 0 dan 100 gacha bo'lishi kerak!");
        }

        baholar[i] = baho;
        yigindi += baho;
    }
    catch (FormatException)
    {
        Console.WriteLine("Xato: Son o'rniga matn kiritildi!");
        i--; // Xato bo'lsa, siklni qaytarib, qayta kiritishni so'raymiz
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Xato: {ex.Message}");
        i--;
    }
}

double ortacha = yigindi / 5.0;

// C# 8+ Switch expression with relational patterns: bahoni hisoblash
string yakuniyBaho = ortacha switch
{
    >= 86 and <= 100 => "A",
    >= 71 => "B",
    >= 56 => "C",
    _ => "F"
};

Console.WriteLine("\n--- Natija ---");
// C# 11+ Raw string literals yoki oddiy interpolation
Console.WriteLine($"O'rtacha baho: {ortacha:F2}");
Console.WriteLine($"Yakuniy baho: {yakuniyBaho}");