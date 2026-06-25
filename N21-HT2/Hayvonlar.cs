namespace N21_HT2;

class Mushuk : IOvqatlanuvchi
{
    public string Ism { get; set; }

    public Mushuk(string ism)
    {
        Ism = ism;
    }

    public void Ovqatlan()
    {
        Console.WriteLine($"{Ism} baliq yeyapti. 🐟");
    }
}

class It : IOvqatlanuvchi
{
    public string Ism { get; set; }

    public It(string ism)
    {
        Ism = ism;
    }

    public void Ovqatlan()
    {
        Console.WriteLine($"{Ism} suyak kemiriyapti. 🦴");
    }
}

class Tovuq : IOvqatlanuvchi
{
    public string Ism { get; set; }

    public Tovuq(string ism)
    {
        Ism = ism;
    }

    public void Ovqatlan()
    {
        Console.WriteLine($"{Ism} don choquyapti. 🌾");
    }
}

class Robot : IOvqatlanuvchi
{
    public string Ism { get; set; }

    public Robot(string ism)
    {
        Ism = ism;
    }

    public void Ovqatlan()
    {
        Console.WriteLine($"{Ism} energiya bilan to'ldirildi. ⚡");
    }
}
