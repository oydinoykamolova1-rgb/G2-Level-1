using N24_HT1;
namespace StudentManagementSystem;

class Program
{
    static void Main(string[] args)
    {
        // Test uchun talabalar ro'yxati
        List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ali", Age = 20, Group = "A1", GPA = 3.8, City = "Tashkent" },
            new Student { Id = 2, Name = "Vali", Age = 19, Group = "A2", GPA = 4.0, City = "Samarkand" },
            new Student { Id = 3, Name = "Hasan", Age = 21, Group = "A1", GPA = 3.2, City = "Tashkent" },
            new Student { Id = 4, Name = "Husan", Age = 18, Group = "B1", GPA = 3.6, City = "Bukhara" },
            new Student { Id = 5, Name = "Zarina", Age = 22, Group = "B2", GPA = 4.2, City = "Khiva" }
        };

        // 1. GPA 3.5 dan yuqori bo'lgan talabalarni chiqaring
        Console.WriteLine("=== GPA > 3.5 bo'lgan talabalar ===");
        var highGpaStudents = students.Where(s => s.GPA > 3.5);
        foreach (var student in highGpaStudents)
        {
            Console.WriteLine($"{student.Name} - GPA: {student.GPA}");
        }

        // 2. Faqat talabalarning ismlarini chiqaring
        Console.WriteLine("\n=== Barcha talabalar ismlari ===");
        var names = students.Select(s => s.Name);
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        // 3. Talabalarni yosh bo'yicha o'sish tartibida saralang
        Console.WriteLine("\n=== Yosh bo'yicha o'sish tartibi ===");
        var sortedByAge = students.OrderBy(s => s.Age);
        foreach (var student in sortedByAge)
        {
            Console.WriteLine($"{student.Name} - Age: {student.Age}");
        }

        // 4. Talabalarni GPA bo'yicha kamayish tartibida saralang
        Console.WriteLine("\n=== GPA bo'yicha kamayish tartibi ===");
        var sortedByGpa = students.OrderByDescending(s => s.GPA);
        foreach (var student in sortedByGpa)
        {
            Console.WriteLine($"{student.Name} - GPA: {student.GPA}");
        }

        // 5. Birinchi va oxirgi talabani toping
        Console.WriteLine("\n=== Birinchi va oxirgi talaba ===");
        var firstStudent = students.First();
        var lastStudent = students.Last();
        Console.WriteLine($"Birinchi: {firstStudent.Name}");
        Console.WriteLine($"Oxirgi: {lastStudent.Name}");

        // 6. GPA 4 ga teng talaba mavjudligini tekshiring
        Console.WriteLine("\n=== GPA = 4 bo'lgan talaba mavjudmi? ===");
        bool hasGpa4 = students.Any(s => s.GPA == 4.0);
        Console.WriteLine(hasGpa4 ? "Ha, mavjud" : "Yo'q, mavjud emas");

        // 7. Barcha talabalarning yoshi 18 dan katta ekanligini tekshiring
        Console.WriteLine("\n=== Barcha talabalar yoshi > 18? ===");
        bool allAbove18 = students.All(s => s.Age > 18);
        Console.WriteLine(allAbove18 ? "Ha, barchasi 18 dan katta" : "Yo'q, hamma 18 dan katta emas");

        // 8. Jami talabalar sonini toping
        Console.WriteLine($"\n=== Jami talabalar soni: {students.Count()} ===");

        // 9. O'rtacha GPA ni hisoblang
        Console.WriteLine($"=== O'rtacha GPA: {students.Average(s => s.GPA):F2} ===");

        // 10. Eng katta va eng kichik GPA ni toping
        Console.WriteLine($"=== Eng katta GPA: {students.Max(s => s.GPA)} ===");
        Console.WriteLine($"=== Eng kichik GPA: {students.Min(s => s.GPA)} ===");

        // 11. Takrorlanmaydigan shaharlar ro'yxatini chiqaring
        Console.WriteLine("\n=== Takrorlanmaydigan shaharlar ===");
        var distinctCities = students.Select(s => s.City).Distinct();
        foreach (var city in distinctCities)
        {
            Console.WriteLine(city);
        }

        // 12. Birinchi 5 ta talabani chiqaring
        Console.WriteLine("\n=== Birinchi 5 ta talaba ===");
        var firstFive = students.Take(5);
        foreach (var student in firstFive)
        {
            Console.WriteLine(student.Name);
        }

        // 13. Dastlabki 3 tasini tashlab qolganlarini chiqaring
        Console.WriteLine("\n=== Dastlabki 3 tasidan keyingi talabalar ===");
        var skipThree = students.Skip(3);
        foreach (var student in skipThree)
        {
            Console.WriteLine(student.Name);
        }

        // 14. Talabalarni guruhlar bo'yicha ajrating
        Console.WriteLine("\n=== Guruhlar bo'yicha talabalar ===");
        var groupedByGroup = students.GroupBy(s => s.Group);
        foreach (var group in groupedByGroup)
        {
            Console.WriteLine($"\nGuruh: {group.Key}");
            foreach (var student in group)
            {
                Console.WriteLine($"  - {student.Name}");
            }
        }

        // 15. Id -> Name ko'rinishida Dictionary yarating
        Console.WriteLine("\n=== Id -> Name Dictionary ===");
        var idNameDict = students.ToDictionary(s => s.Id, s => s.Name);
        foreach (var kvp in idNameDict)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }

        // 16. Eng yuqori GPA ga ega talabani toping
        Console.WriteLine("\n=== Eng yuqori GPA li talaba ===");
        var highestGpaStudent = students.OrderByDescending(s => s.GPA).First();
        Console.WriteLine($"{highestGpaStudent.Name} - GPA: {highestGpaStudent.GPA}");

        // 17. Eng past GPA ga ega talabani toping
        Console.WriteLine("\n=== Eng past GPA li talaba ===");
        var lowestGpaStudent = students.OrderBy(s => s.GPA).First();
        Console.WriteLine($"{lowestGpaStudent.Name} - GPA: {lowestGpaStudent.GPA}");
    }
}