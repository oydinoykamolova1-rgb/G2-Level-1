List<string> students = new List<string>
{
    "Oydinoy", "Bonu", "Jasur","Anora", "Noila", "Nozanin","Zaxro"
};

List<string> result = await GetFilteredStudentsSAsync(students);

Console.WriteLine("Natijalar...");
foreach (var item  in result)
{
    Console.WriteLine($"- {item}");
}

static async Task<List<string>> GetFilteredStudentsSAsync (List<string> studentsList)
{
    Console.WriteLine("Malumotlar yuklandi...");
    await Task.Delay(5000);

    var filterd = studentsList
        .Where(s => s.Length > 4)
        .OrderBy(s => s)
        .ToList();

    return filterd;
}