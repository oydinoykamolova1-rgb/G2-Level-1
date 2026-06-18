namespace N17_T1;

public class Tortburcak : Wakl
{
    public string Rang {  get; set; }


    public int Boy { get; set; }

    public int Eni { get; set; }

    public Tortburcak(string Rang, int Boyi, int Eni)
        :base(Rang)
    {
        this.Boy = Boyi;
        this.Eni = Eni;
    }

    public void Yuzasi(int a, int b)
    {
        Console.WriteLine($"Rangi: {Rang}, Yuzasi:{Yuzasi}");
    }
}
