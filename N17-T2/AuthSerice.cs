using System.Text.RegularExpressions;

namespace N17_T2;

public class AuthSerice
{

    private static readonly string _emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";



    public bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        { 
            return false;
        }

        return Regex.IsMatch(email, _emailPattern);
    }

}
