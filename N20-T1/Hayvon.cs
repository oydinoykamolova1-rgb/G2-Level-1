namespace N20_T1;

public class Hayvon
{
    public string Ism { get; set; }


    public Hayvon(string ism)
    {
        Ism = ism;
    }

    public virtual void OvozChiqar()
    {
        Console.WriteLine($"{Ism} qanqaydir ovoz chiqar");
    }

}


public class It : Hayvon
{
    public It(string Ism) : base(Ism) { }
    //

    public override void OvozChiqar()
    {
        Console.WriteLine($"{Ism}: vov-vov");
    }
}

public class Mushuk : Hayvon
{
    public Mushuk(string Ism) : base(Ism) { }


    public override void OvozChiqar()
    {
        Console.WriteLine($"{Ism} : Miyov - miyov");
    }
}