namespace N21_T1;
public abstract class Wakl
{
    public string Nomi {  get; set; }

    public Wakl(string nomi)
    {
        Nomi = nomi;
    }


    public abstract double YuzasiniHisobla();


    public void Malumot()
    {
        Console.WriteLine($"{Nomi} ning yuzasi: {YuzasiniHisobla():F2}");
    }
}


public class Doira : Wakl
{
    public double Radiusi {  get; set; }

    public Doira(string nomi, double radiusi) : base(nomi)
    {
        Radiusi = radiusi;
    }

    public override double YuzasiniHisobla()
    {
        return Math.PI * Radiusi * Radiusi;
    }
}

public class Tortburcak : Wakl
{
    public double Eni {  get; set; }
    public double Boy { get; set; }

    public Tortburcak(string nomi, double eni, double boy) : base(nomi)
    {
        Eni = eni;
        Boy = boy;
    }

    public override double YuzasiniHisobla()
    {
        return Eni * Boy;
    }
}