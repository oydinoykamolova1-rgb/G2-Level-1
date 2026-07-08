using Kutubxona;

var service = new BookService();
bool running = true;

while (running) // true o'rniga running qo'yildi
{
    Console.WriteLine("\n=== KUTUBXONA TIZIMI ===");
    Console.WriteLine("1. Kitob qo'shish");
    Console.WriteLine("2. Barcha kitoblarni ko'rish");
    Console.WriteLine("3. Kitobni ID bo'yicha izlash");
    Console.WriteLine("4. Kitobni tahrirlash");
    Console.WriteLine("5. Kitobni o'chirish");
    Console.WriteLine("0. Chiqish");
    Console.Write("Tanlov: ");

    switch (Console.ReadLine())
    {
        case "1":
            Console.Write("Kitob nomi: ");
            var title = Console.ReadLine() ?? "";
            Console.Write("Muallif: ");
            var author = Console.ReadLine() ?? "";
            Console.Write("Yil: ");
            int.TryParse(Console.ReadLine(), out int year);
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine() ?? "";

            var newBook = new Book
            {
                Title = title,
                Author = author,
                Year = year,
                Isbn = isbn,
                IsAvailable = true
            };
            service.AddBook(newBook);
            Console.WriteLine("Kitob qo'shildi!");
            break;

        case "2":
            var books = service.GetAllBooks();
            if (books.Count == 0)
                Console.WriteLine("Kutubxona bo'sh");
            foreach (var b in books)
                Console.WriteLine($"[{b.Id}] {b.Title} - {b.Author} ({b.Year}) | Mavjud: {(b.IsAvailable ? "Ha" : "Yo'q")}");
            break;

        case "3":
            Console.Write("Izlash uchun ID kiriting: ");
            int.TryParse(Console.ReadLine(), out int searchId);
            var found = service.GetById(searchId);
            Console.WriteLine(found is null ? "Kitob topilmadi" : $"[{found.Id}] {found.Title} - {found.Author} ({found.Year}) " +
                $"| Mavjud: {(found.IsAvailable ? "Ha" : "Yo'q")}");
            break;

        case "4":
            Console.Write("Tahrirlash uchun ID kiriting: ");
            int.TryParse(Console.ReadLine(), out int editId);

            // Avval eski ma'lumotlarni yuklab olamiz
            var oldBook = service.GetById(editId);
            if (oldBook == null)
            {
                Console.WriteLine("Kitob topilmadi!");
                break;
            }

            Console.Write($"Yangi kitob nomi ({oldBook.Title}): ");
            var newTitle = Console.ReadLine();
            Console.Write($"Yangi muallif ({oldBook.Author}): ");
            var newAuthor = Console.ReadLine();

            bool updated = service.UpdateBook(editId, new Book
            {
                Title = string.IsNullOrWhiteSpace(newTitle) ? oldBook.Title : newTitle,
                Author = string.IsNullOrWhiteSpace(newAuthor) ? oldBook.Author : newAuthor,
                Year = oldBook.Year,
                Isbn = oldBook.Isbn,
                IsAvailable = oldBook.IsAvailable
            });
            Console.WriteLine(updated ? "Kitob tahrirlandi!" : "Kitob tahrirlanmadi");
            break;

        case "5":
            Console.Write("O'chirish uchun ID kiriting: ");
            int.TryParse(Console.ReadLine(), out int deleteId);
            bool deleted = service.DeleteBook(deleteId);
            Console.WriteLine(deleted ? "Kitob o'chirildi!" : "Kitob topilmadi");
            break;

        case "0": // Menyudagi 0 ga moslandi
            running = false;
            Console.WriteLine("Dastur tugatildi.");
            break;

        default:
            Console.WriteLine("Noto'g'ri tanlov, qayta urinib ko'ring.");
            break;
    }
}
