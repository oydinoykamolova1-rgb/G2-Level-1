
double son1, son2;
string amal;

// 1. Birinchi sonni qabul qilish
Console.Write("Birinchi sonni kiriting: ");
try
{
    son1 = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Xato: Birinchi son o'rniga matn yoki noto'g'ri qiymat kiritildi!");
    return; // Dasturni to'xtatish
}

// 2. Ikkinchi sonni qabul qilish
Console.Write("Ikkinchi sonni kiriting: ");
try
{
    son2 = Convert.ToDouble(Console.ReadLine());
}
catch (FormatException)
{
    Console.WriteLine("Xato: Ikkinchi son o'rniga matn yoki noto'g'ri qiymat kiritildi!");
    return; // Dasturni to'xtatish
}

// 3. Amalni qabul qilish
Console.Write("Amalni kiriting (+, -, *, /): ");
amal = Console.ReadLine();

// Mavjud bo'lmagan amal tekshiruvi
if (amal != "+" && amal != "-" && amal != "*" && amal != "/")
{
    Console.WriteLine("Noto'g'ri amal kiritildi!");
    return;
}

// 4. Hisoblash va natijani chiqarish
double natija = 0;

// Bo'luvchi 0 bo'lishini oldindan tekshirish
if (amal == "/" && son2 == 0)
{
    Console.WriteLine("Xato: Bo'luvchi 0 bo'lishi mumkin emas!");
    return;
}

try
{
    switch (amal)
    {
        case "+": natija = son1 + son2; break;
        case "-": natija = son1 - son2; break;
        case "*": natija = son1 * son2; break;
        case "/": natija = son1 / son2; break;
    }

    Console.WriteLine($"Natija: {son1} {amal} {son2} = {natija}");
}
catch (Exception ex)
{
    Console.WriteLine("Hisoblashda xatolik yuz berdi: " + ex.Message);
}
