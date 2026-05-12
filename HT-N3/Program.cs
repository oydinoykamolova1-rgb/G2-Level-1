
#region 8 task

Console.WriteLine("Oy raqmini kiriting: ");
int month = int.Parse(Console.ReadLine());


if (month == 12 || month == 1 || month == 2)
{
    Console.WriteLine("qish");
}
else if (month == 3 || month == 4 || month == 5 )
{

    Console.WriteLine("baxor");
}
else if (month == 6 || month == 7 || month == 8 )
{
    Console.WriteLine("yoz");
}
else if (month == 9 || month == 10 || month == 11)
{
    Console.WriteLine("kuz");
}
else
{
    Console.WriteLine("notog`ri oy raqmi kiritildi. ");
}



#endregion