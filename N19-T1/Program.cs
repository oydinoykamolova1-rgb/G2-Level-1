const string CompaniyName = "The Travel Guru";
const string NameToken = "{{Name}}";
const string CompaniyNameTokenv = "{{CompaniyNameTokenv}}";
const string TokenDateToken = "{{TokenDateToken}}";


Dictionary<string, string> messages = new Dictionary<string, string>()
{
    {"UnderAge","uzur ,{{Name}} seni yoshin kichkina qatnashmaysan." },
    {"GoldenAge","uzur ,{{Name}} siz siliwkim kattasiz bu yowlar uchun."}
};


LinkedList <string> emails = new LinkedList<string>();
emails.AddLast("hello{{Name}}. welkom to onboard.{{CopaniyNmae}} Team");
emails.AddLast("your data is being processed and we will inform updates. {{CompaniyName}}");
emails.AddLast("Canfiragtitsion! you fligt ticekn is booked for {{TicketDate}}. {{ConpaniyName}} Tame");


List<string> registeredusers = new List<string>() { "Oydinoy" };


Dictionary<string, int> flight = new Dictionary<string, int>()
{
    {"2026-06-18 19:00" }

};

Console.WriteLine("===Royatdan otish==");
string myName = "";
while(true)
{
    Console.Write("ism kirit");
    myName = Console.ReadLine();


    if (HasDigit(myName))
    {
        Console.WriteLine("xato ism ");
        continue
    }
    break;
}

Console.WriteLine("yow kirit");
string ageInput = Console.ReadLine();
int myage;
bool isNumber = int.TryParse(ageInput, out myage);

if (isNumber)
{
    Console.WriteLine("xato");
    return;
}

if (myage < 18 )
{
    string
}