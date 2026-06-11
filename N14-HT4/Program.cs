using N14_HT4;

Futbolchi oydinoy = new Futbolchi("Oydinoy", "Real", 17, 17);
Futbolchi jasur = new Futbolchi("Jasur");

oydinoy.MalumotChiqar();
jasur.MalumotChiqar();

oydinoy.GolUrish(9);
jasur.GolUrish(10);

Console.WriteLine($"Oydinoyning darajasi: {oydinoy.DarajaAniqla()}");
Console.WriteLine($"Jasurning darajasi: {jasur.DarajaAniqla()}");
