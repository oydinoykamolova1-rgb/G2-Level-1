// Collections - kollektsiyalar C# da


 // Array
int[] numbers = new int[20];

// Kamshiligi - resize qilib bo'lmaydi
// Element qo'shish va o'chirish qiyin.

// Collection turlari - List, Dictionary, HashSet, Queue, Stack
// List bu eng ko'p ishlatilinadigan kolleksiya.


 // List elon qilish
List<string> students = new List<string>();

//// Element qo'shish
students.Add("Ali");
students.Add("Vali");
students.Add("Sherbek");

////// Listga qo'lda element kiritib chiqish
for (int i = 0; i < 5; i++)
{
    Console.Write($"{i + 1} - ismni kiriting: ");
    students.Add(Console.ReadLine());
}

////// Ularni ekranga chiqarish
foreach (string student in students)
{
    Console.WriteLine(student);
}

//// elementlar sonini olish
Console.WriteLine(students.Count);      // 3

//// o'chirish
students.Remove("Sherbek");
students.Remove("Vali");
students.Add("Iqbol");
students.Add("Oydinoy");
students.Add("Jasur");
Console.WriteLine(students.Count);      // 4

students.Remove(students[3]);       // Jasur ketti

//// insert - hohlagan joyimizga hohlagan ismni qo'shih
students.Insert(1, "Olimjon");
students.Insert(1, "Sher");

// clear - tozalash
students.Clear();


 // Dictionary
Dictionary<int, string> talabalar = new Dictionary<int, string>();

talabalar.Add(1, "Oydinoy");
talabalar.Add(2, "Iqbol");
talabalar.Add(3, "Alijon");
talabalar.Add(4, "Sherbek");
talabalar.Add(5, "Jasur");

////// key boyicha valueni ekranga chiqarish
Console.WriteLine(talabalar[4]);

//// hammasini ekranga chiqarish forda
foreach (var item in talabalar)
{
    Console.WriteLine($"{item.Key} {item.Value}");
}


//// Hashset - takroriy qiymatlarga ruhsat bermaydi
//HashSet<int> sonlar = new HashSet<int>();

//sonlar.Add(10);
//sonlar.Add(11);
//sonlar.Add(12);
//sonlar.Add(10);



//foreach (var item in sonlar)
//{
//    Console.WriteLine(item);
//}

// Qachon ishlatilinadi
// 1. Unikal malumotlar saqlaydi
// 2. Loginlar
// 3. Email manzillar
// 4. Id lar


 //Queue - FIFO
 //FIFO - First In First Out
 //elon qlish
Queue<string> names = new Queue<string>();

//// element qoshish
names.Enqueue("Jasur");
names.Enqueue("Sherbek");
names.Enqueue("Oydinoy");
names.Enqueue("Iqbol");

//// element olib tashlash
names.Dequeue();   // Jasur ketti

foreach (var name in names)
{
    Console.WriteLine(name);
}


//Stack - LIFO
// Last In First Out
//// elon qilish
Stack<int> sonlar = new Stack<int>();

// Ichiga joylash
sonlar.Push(10);
sonlar.Push(23);
sonlar.Push(33);

//// Oxiridan elementlarni olib chiqish
Console.WriteLine(sonlar.Pop());    // 33
Console.WriteLine(sonlar.Pop());    // 23
 
Console.WriteLine(sonlar.Peek());


// Umumiy holatda
// List - Eng universal
// Dictionary - kalit va qiymat saqlanadi
// HashSet - Takrorlanmas
// Queue - FIFO
// Stack - LIFO