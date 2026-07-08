using System.Text.Json;

namespace Kutubxona;

public class BookService
{
    // Fayl kengaytmasini .json qilish tavsiya etiladi
    private readonly string _filePath = "D:\\IT beck end\\backend\\G2-Level-1\\Kutubxona\\Kutubxona.json";
    private List<Book> _books;

    public BookService()
    {
        _books = LoadFromFile();
    }

    public void AddBook(Book book)
    {
        book.Id = _books.Count == 0 ? 1 : _books.Max(b => b.Id) + 1;
        _books.Add(book);
        SaveToFile();
    }

    public List<Book> GetAllBooks() => _books;

    public Book? GetById(int id) => _books.FirstOrDefault(b => b.Id == id);

    public bool UpdateBook(int id, Book updateBook)
    {
        var book = GetById(id);
        if (book == null) return false;

        book.Title = updateBook.Title;
        book.Author = updateBook.Author;
        book.Year = updateBook.Year;
        book.Isbn = updateBook.Isbn;
        book.IsAvailable = updateBook.IsAvailable;

        SaveToFile();
        return true;
    }

    public bool DeleteBook(int id)
    {
        var book = GetById(id);
        if (book is null) return false;

        _books.Remove(book);
        SaveToFile();
        return true;
    }

    private void SaveToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var json = JsonSerializer.Serialize(_books, options);
        File.WriteAllText(_filePath, json);
    }

    private List<Book> LoadFromFile()
    {
        // 1. Fayl mavjud bo'lmasa, yangi list qaytaramiz
        if (!File.Exists(_filePath))
        {
            return new List<Book>();
        }

        var json = File.ReadAllText(_filePath);

        // 2. Fayl mavjud bo'lsa-yu, lekin ichi bo'sh bo'lsa ham xato bermasligi uchun tekshiramiz
        if (string.IsNullOrWhiteSpace(json))
        {
            return new List<Book>();
        }

        try
        {
            return JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
        }
        catch (JsonException)
        {
            // Agar fayldagi JSON struktura buzilgan bo'lsa, xato bermasdan bo'sh ro'yxat ochadi
            return new List<Book>();
        }
    }
}
