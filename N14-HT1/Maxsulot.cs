namespace N14_HT1;

public class Maxsulot
{
    string Nomi;
    double Narxi;
    int Miqdori;

    public Maxsulot(string nomi, double narxi, int miqdori)
    {
        this.Nomi = nomi;
        this.Narxi = narxi;
        this.Miqdori = miqdori;
    }

    public void MalumotChiqar()
    {
        Console.WriteLine($"Nomi: {Nomi}\nNarxi: {Narxi}\nMiqdori: {Miqdori}");
    }
}

