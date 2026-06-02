#region 1masala
//void AlamshtirSonlarni(ref int a, ref int b)
//{
//    int c = 0;
//    c = a;
//    a = b;
//    b = c;

//}

//int x = 112 ; int y = 17;
//Console.WriteLine($"x:{x}, y:{y}");
//AlamshtirSonlarni(ref x, ref y);
//Console.WriteLine($"x: {x}, y: {y}");
#endregion

#region 2 masala
//void KaraliSon(ref int o)
//{
//    o = o * o;
//}

//Console.Write("Son kirt: ");
//int a = int.Parse(Console.ReadLine());
//KaraliSon(ref a);
//Console.WriteLine($"Soni kvadrati: {a}");


#endregion

#region 3 masala

//int Maximum(params int[] sonlar)
//{
//    //int max = sonlar[0];
//    //for (int i = 0; i < sonlar.Length; i++)
//    //{
//    //    if (sonlar[i] > max)
//    //        max = sonlar[i];
//    //}
//    int max = sonlar.Max();

//    return max;
//}

//Console.WriteLine(Maximum(12, 17, 3, 31, 5, 555, 0, -22));
#endregion

#region 4 masala
//static void OrtachaHisoblash(params int[] numbers)
//{
//    int min = numbers.Min();
//    int max = numbers.Max();
//    double ortacha = numbers.Average();

//    Console.WriteLine($"Min: {min} | Max: {max} | O'rtacha: {ortacha:F2}");
//}

//OrtachaHisoblash(60, 85, 72, 90, 10, 20, 30);
#endregion
