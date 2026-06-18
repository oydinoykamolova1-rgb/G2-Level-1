using System.Text.RegularExpressions;

namespace N17_HT1;

public class ValidatorApp
{
    // nomer uchun 
    public bool IsPhoneValid(string phone)
    {
        return Regex.IsMatch(phone, @"^\+998\d{9}$");
    }

    //Email
    public bool IsEmailValid(string email)
    {
        return Regex.IsMatch(email,
                 @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }

    //Parol
    public bool IsPasswordValid(string password)
    {
        return Regex.IsMatch(password,
               @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
    }
}
