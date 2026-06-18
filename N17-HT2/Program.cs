using N17_HT2;
using System;

namespace BirthdayChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ismingizni kiriting: ");
            string name = Console.ReadLine();

            Console.Write("Tug'ilgan sanangizni kiriting (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Person person = new Person(name, birthDate);

            Console.WriteLine($"\nIsm: {person.Name}");
            Console.WriteLine($"Yoshi: {person.GetAge()}");

            if (person.IsBirthdayToday())
            {
                Console.WriteLine("🎉 Bugun tug'ilgan kuningiz!");
            }
            else
            {
                Console.WriteLine("Bugun tug'ilgan kuningiz emas.");
            }
        }
    }
}