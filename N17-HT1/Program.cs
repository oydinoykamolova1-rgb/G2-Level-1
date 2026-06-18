using N17_HT1;

ValidatorApp validator = new ValidatorApp();

Console.Write("Telefon raqam kiriting: ");
string phone = Console.ReadLine();

Console.Write("Email kiriting: ");
string email = Console.ReadLine();

Console.Write("Parol kiriting: ");
string password = Console.ReadLine();

Console.WriteLine();

Console.WriteLine(
    validator.IsPhoneValid(phone)
    ? "Telefon raqam to'g'ri"
    : "Telefon raqam noto'g'ri");

Console.WriteLine(
    validator.IsEmailValid(email)
    ? "Email to'g'ri"
    : "Email noto'g'ri");

Console.WriteLine(
    validator.IsPasswordValid(password)
    ? "Parol to'g'ri"
    : "Parol noto'g'ri");