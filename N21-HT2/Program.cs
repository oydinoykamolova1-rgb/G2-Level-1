// List<IOvqatlanuvchi> — interfeys tipi orqali polimorfizm
using N21_HT2;
using System.Xml.Linq;

Console.OutputEncoding = System.Text.Encoding.UTF8;
List<IOvqatlanuvchi> royxat = new List<IOvqatlanuvchi>
        {
            new Mushuk("Messi"),
            new It("Ranaldo"),
            new Tovuq("jorjina"),
            new Robot("jorj"),   // hayvon emas, lekin xuddi shu interfeys!
        };

Console.WriteLine("======== Ovqatlanish vaqti! ========\n");

foreach (IOvqatlanuvchi element in royxat)
{
    element.Ovqatlan();
}

Console.WriteLine("\n====================================");
Console.WriteLine("Hammasi o'z usulida ovqatlandi ✔");