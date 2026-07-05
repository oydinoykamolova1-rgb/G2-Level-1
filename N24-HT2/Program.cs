using N24_HT2;

// Test uchun mahsulotlar ro'yxati
List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 8500000, Quantity = 10, Brand = "HP" },
            new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 4500000, Quantity = 25, Brand = "Samsung" },
            new Product { Id = 3, Name = "Shirt", Category = "Clothing", Price = 250000, Quantity = 50, Brand = "Nike" },
            new Product { Id = 4, Name = "Shoes", Category = "Footwear", Price = 600000, Quantity = 30, Brand = "Adidas" },
            new Product { Id = 5, Name = "Tablet", Category = "Electronics", Price = 3200000, Quantity = 15, Brand = "Apple" },
            new Product { Id = 6, Name = "Watch", Category = "Accessories", Price = 1200000, Quantity = 20, Brand = "Casio" },
            new Product { Id = 7, Name = "Bag", Category = "Accessories", Price = 350000, Quantity = 40, Brand = "Puma" }
        };

// 1. Narxi 500000 so'mdan yuqori bo'lgan mahsulotlarni chiqaring
Console.WriteLine("=== Narxi > 500,000 so'm bo'lgan mahsulotlar ===");
var expensiveProducts = products.Where(p => p.Price > 500000);
foreach (var product in expensiveProducts)
{
    Console.WriteLine($"{product.Name} - {product.Price:N0} so'm");
}

// 2. Faqat mahsulot nomlarini chiqaring
Console.WriteLine("\n=== Barcha mahsulot nomlari ===");
var productNames = products.Select(p => p.Name);
foreach (var name in productNames)
{
    Console.WriteLine(name);
}

// 3. Mahsulotlarni narxi bo'yicha o'sish tartibida saralang
Console.WriteLine("\n=== Narx bo'yicha o'sish tartibi ===");
var sortedByPrice = products.OrderBy(p => p.Price);
foreach (var product in sortedByPrice)
{
    Console.WriteLine($"{product.Name} - {product.Price:N0} so'm");
}

// 4. Mahsulotlarni soni (Quantity) bo'yicha kamayish tartibida saralang
Console.WriteLine("\n=== Soni bo'yicha kamayish tartibi ===");
var sortedByQuantity = products.OrderByDescending(p => p.Quantity);
foreach (var product in sortedByQuantity)
{
    Console.WriteLine($"{product.Name} - Quantity: {product.Quantity}");
}

// 5. Birinchi va oxirgi mahsulotni toping
Console.WriteLine("\n=== Birinchi va oxirgi mahsulot ===");
var firstProduct = products.First();
var lastProduct = products.Last();
Console.WriteLine($"Birinchi: {firstProduct.Name}");
Console.WriteLine($"Oxirgi: {lastProduct.Name}");

// 6. Narxi 1000000 so'mdan yuqori mahsulot mavjudligini tekshiring
Console.WriteLine("\n=== Narxi > 1,000,000 so'm bo'lgan mahsulot mavjudmi? ===");
bool hasExpensiveProduct = products.Any(p => p.Price > 1000000);
Console.WriteLine(hasExpensiveProduct ? "Ha, mavjud" : "Yo'q, mavjud emas");

// 7. Barcha mahsulotlarning soni (Quantity) 0 dan katta ekanligini tekshiring
Console.WriteLine("\n=== Barcha mahsulotlar soni > 0? ===");
bool allHaveStock = products.All(p => p.Quantity > 0);
Console.WriteLine(allHaveStock ? "Ha, barchasida bor" : "Yo'q, ba'zilarida yo'q");

// 8. Mahsulotlar sonini hisoblang
Console.WriteLine($"\n=== Jami mahsulotlar soni: {products.Count()} ===");

// 9. O'rtacha narxni hisoblang
Console.WriteLine($"=== O'rtacha narx: {products.Average(p => p.Price):N0} so'm ===");

// 10. Eng qimmat va eng arzon mahsulotni toping
Console.WriteLine($"=== Eng qimmat mahsulot: {products.Max(p => p.Price):N0} so'm ===");
Console.WriteLine($"=== Eng arzon mahsulot: {products.Min(p => p.Price):N0} so'm ===");

// 11. Takrorlanmaydigan brendlarni chiqaring
Console.WriteLine("\n=== Takrorlanmaydigan brendlar ===");
var distinctBrands = products.Select(p => p.Brand).Distinct();
foreach (var brand in distinctBrands)
{
    Console.WriteLine(brand);
}

// 12. Birinchi 4 ta mahsulotni chiqaring
Console.WriteLine("\n=== Birinchi 4 ta mahsulot ===");
var firstFour = products.Take(4);
foreach (var product in firstFour)
{
    Console.WriteLine(product.Name);
}

// 13. Dastlabki 2 tasini tashlab qolganlarini chiqaring
Console.WriteLine("\n=== Dastlabki 2 tasidan keyingi mahsulotlar ===");
var skipTwo = products.Skip(2);
foreach (var product in skipTwo)
{
    Console.WriteLine(product.Name);
}

// 14. Mahsulotlarni kategoriyalar bo'yicha guruhlang
Console.WriteLine("\n=== Kategoriyalar bo'yicha mahsulotlar ===");
var groupedByCategory = products.GroupBy(p => p.Category);
foreach (var category in groupedByCategory)
{
    Console.WriteLine($"\nKategoriya: {category.Key}");
    foreach (var product in category)
    {
        Console.WriteLine($"  - {product.Name}");
    }
}

// 15. Id -> Name ko'rinishida Dictionary yarating
Console.WriteLine("\n=== Id -> Name Dictionary ===");
var idNameDict = products.ToDictionary(p => p.Id, p => p.Name);
foreach (var kvp in idNameDict)
{
    Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
}

// 16. Eng qimmat mahsulotni MaxBy() yordamida toping
Console.WriteLine("\n=== Eng qimmat mahsulot (MaxBy) ===");
var mostExpensive = products.MaxBy(p => p.Price);
Console.WriteLine($"{mostExpensive.Name} - {mostExpensive.Price:N0} so'm");

// 17. Eng arzon mahsulotni MinBy() yordamida toping
Console.WriteLine("\n=== Eng arzon mahsulot (MinBy) ===");
var cheapest = products.MinBy(p => p.Price);
Console.WriteLine($"{cheapest.Name} - {cheapest.Price:N0} so'm");
