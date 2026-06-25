namespace N21_HT1;


abstract class Oqituvchi
{
    // --- Propertylar ---
    public string Ism { get; set; }
    public int Stajl { get; set; }   // ish staji (yillarda)

    // --- Konstruktor ---
    public Oqituvchi(string ism, int stajl)
    {
        Ism = ism;
        Stajl = stajl;
    }

    // --- Abstract metod (tana yo'q — har bir bola o'zi to'ldiradi) ---
    public abstract string FanniAytish();

    // --- Oddiy metod (polimorfizm: ichida abstract FanniAytish() chaqiriladi) ---
    public void Tanishtir()
    {
        string fan = FanniAytish();
        Console.WriteLine($"Salom, men {Ism}. Stajim {Stajl} yil. Men {fan} fanidan dars beraman.");
    }
}

// ============================================================
//  BOLA CLASSLAR
// ============================================================

// 1) Matematika o'qituvchisi
class MatematikaOqituvchi : Oqituvchi
{
    public MatematikaOqituvchi(string ism, int stajl)
        : base(ism, stajl) { }

    public override string FanniAytish() => "Matematika";
}

// 2) Ingliz tili o'qituvchisi
class IngilizTiliOqituvchi : Oqituvchi
{
    public IngilizTiliOqituvchi(string ism, int stajl)
        : base(ism, stajl) { }

    public override string FanniAytish() => "Ingliz tili";
}

// 3) Tarix o'qituvchisi
class TarixOqituvchi : Oqituvchi
{
    public TarixOqituvchi(string ism, int stajl)
        : base(ism, stajl) { }

    public override string FanniAytish() => "Tarix";
};
