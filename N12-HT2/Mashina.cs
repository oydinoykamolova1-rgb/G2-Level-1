namespace N12_HT2;

public class Mashina
{
    public string Rusumi;
    public string Rangi;
    public double YoqilgiLitr;

    public void MalumotChiqar()
    {
        Console.WriteLine($"Rusumi: {Rusumi}");
        Console.WriteLine($"Rangi: {Rangi}");
        Console.WriteLine($"Yoqilg'i litri: {YoqilgiLitr}");
    }

    public void YoqilgiQuyish(double litr)
    {
        YoqilgiLitr += litr;
        MalumotChiqar();
    }
}
