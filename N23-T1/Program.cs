using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Random random = new Random();
int secretNumber = random.Next(1, 11);

Console.WriteLine("🎮 1 va 10 orasidagi sonni toping!");

while (true)
{
    Console.Write("Son kiriting: ");
    string input = Console.ReadLine();

    try
    {
        int guess = int.Parse(input);
        if (guess < 1 || guess > 10)
        {
            throw new ArgumentOutOfRangeException("Son 1 va 10 orasida bo'lishi kerak.");
        }
        if (guess == secretNumber)
        {
            Console.WriteLine("🎉 To'g'ri topdingiz!");
            break;
        }
        else
        {
            Console.WriteLine("❌ Noto'g'ri, qayta urinib ko'ring.");
        }

    }
    catch (FormatException)
    {
        Console.WriteLine("❌ Iltimos, faqat son kiriting.");
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine($"❌ {ex.Message}"); Console.WriteLine(ex.Message);
    }
}