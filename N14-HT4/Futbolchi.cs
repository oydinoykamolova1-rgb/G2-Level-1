namespace N14_HT4;

public class Futbolchi
{
    string Ismi;
    string JamoaNomi;
    int GollarSoni;
    int Yosh;


    public Futbolchi(string Ismi, string JamoaNomi, int GollarSoni, int Yosh)
    {
        this.Ismi = Ismi;
        this.JamoaNomi = JamoaNomi;
        this.GollarSoni = GollarSoni;
        this.Yosh = Yosh;
    }
    public Futbolchi(string ism)
    {
        this.JamoaNomi = "Erkin";
        this.Ismi = ism;
        this.Yosh = 0;
        this.GollarSoni = 10;
    }

    public void MalumotChiqar()
    {
        Console.WriteLine($"Ismi:{Ismi}\nJamoaNomi:{JamoaNomi}\nYosh:{Yosh}\nGollarSoni:{GollarSoni}");
    }

    public void GolUrish(int soni)
    {
        GollarSoni += soni;
        Console.WriteLine($"{soni} ta gol qo'shildi. Jami gollar soni {GollarSoni} ta bo'ldi");
    }

    public string DarajaAniqla()
    {
        if (GollarSoni > 20) return "Dunyo darajasi!";
        else if (GollarSoni > 10) return "Professional!";
        else return "Rivojlanmoqda!";
    }
}