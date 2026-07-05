using N24_T1;

List<Student> talabalar = new List<Student>
{
    new Student { Id = 1, Name = "Asilbek Olimov", Age = 20, Group = "911-22", GPA = 4.2, City = "Toshkent" },
    new Student { Id = 2, Name = "Madina Rustamova", Age = 19, Group = "911-22", GPA = 4.8, City = "Samarqand" },
    new Student { Id = 3, Name = "Javohir Toshpulatov", Age = 21, Group = "912-22", GPA = 3.9, City = "Buxoro" },
    new Student { Id = 4, Name = "Dilnoza Karimova", Age = 22, Group = "913-21", GPA = 4.5, City = "Andijon" },
    new Student { Id = 5, Name = "Sardor Azimov", Age = 20, Group = "911-22", GPA = 3.6, City = "Farg'ona" },
    new Student { Id = 6, Name = "Laylo Aliyeva", Age = 19, Group = "914-22", GPA = 5.0, City = "Namangan" },
    new Student { Id = 7, Name = "Bekzod Shukurov", Age = 23, Group = "901-20", GPA = 3.2, City = "Qarshi" },
    new Student { Id = 8, Name = "Shahzoda Isoqova", Age = 21, Group = "912-22", GPA = 4.7, City = "Xiva" },
    new Student { Id = 9, Name = "Diyorbek Ergashev", Age = 20, Group = "913-22", GPA = 4.1, City = "Navoiy" },
    new Student { Id = 10, Name = "Gulnoza Hasanova", Age = 22, Group = "913-21", GPA = 4.4, City = "Guliston" },
    new Student { Id = 11, Name = "Otabek Rahimov", Age = 20, Group = "911-22", GPA = 3.8, City = "Jizzax" },
    new Student { Id = 12, Name = "Zilola Yusupova", Age = 19, Group = "914-22", GPA = 4.9, City = "Toshkent" },
    new Student { Id = 13, Name = "Jasur Mansurov", Age = 21, Group = "912-22", GPA = 3.5, City = "Termiz" },
    new Student { Id = 14, Name = "Malika Sultonova", Age = 22, Group = "915-21", GPA = 4.6, City = "Nukus" },
    new Student { Id = 15, Name = "Abdurashid Karimov", Age = 20, Group = "913-22", GPA = 4.0, City = "Samarqand" }
};


//GPA qiymati 3 dan katta bolgan talabalarni filtirlash
var filteredStudents =talabalar.Where(Student => Student.GPA > 3).ToList();

foreach (var student in filteredStudents) 
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}" +
       $"Group: {student.Group}, GPA: {student.GPA}, Ctiy: {student.City}" );
}
Console.WriteLine("\n");

// har bir talabani ismini katta katta  harfga otkizish
var upperCaseNames = filteredStudents.Select(Student => Student.Name.ToUpper()).ToList();

foreach (var  name in upperCaseNames)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n");

//talabalarni yosh boyichaa osish tartibin saralash
var ageSorted = talabalar.OrderBy(Student => Student.Age).ToList();

foreach(var student in ageSorted)
{
    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}" +
       $"Group: {student.Group}, GPA: {student.GPA}, Ctiy: {student.City}");
}
Console.WriteLine("\n");

var groups = talabalar.GroupBy(Student => Student.Group).ToList();

foreach (var group in groups)
{
    Console.WriteLine($"Guruh: {group.Key}");
    foreach (var student in group) 
    {
        Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}" +
          $"Group: {student.Group}, GPA: {student.GPA}, Ctiy: {student.City}");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");