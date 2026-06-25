using N21_T1;

List<Wakl> Waklar = new List<Wakl>()
{
    new Doira("Doira", 5),
    new Tortburcak("Tortburcak", 4, 6)
};

foreach (var s in Waklar)
{
    s.Malumot();
}
