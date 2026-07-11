namespace OnlineBozor.Models
{
    public class Product
    {
        public string Name { get; init; }
        public decimal Price { get; init; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}