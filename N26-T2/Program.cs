string filePath = "D:\\IT beck end\\backend\\G2-Level-1\\N26-T2\\Kitoblar.txt";


File.AppendAllText(filePath, "Kecha va Kunduz" + Environment.NewLine);
Console.WriteLine("yangi kitob qowildi\n");

string[] hammasi = File.ReadAllLines(filePath);
foreach (var qator in hammasi)
{
    Console.WriteLine("-" + qator);
}