namespace N16_T1;

 abstract class TolovTizimi
{
    public string Nomi {  get; set; }

    public TolovTizimi(string nomi)
    {
        this.Nomi = nomi;
    }

    public abstract bool TolovQil(decimal summa, string kimga);


    public void NatijaYoz(decimal summa, bool natija)
    {
        string holat = natija ? "Muofaqiyatli !" : "XATO";
        Console.WriteLine($"[{Nomi} {summa:(} --> {holat}]");

    }
}
