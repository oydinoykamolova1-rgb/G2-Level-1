using N17_T2;

AuthSerice auth = new AuthSerice();

Console.WriteLine(auth.IsValidEmail("oydinoykamolova1@gmail.com"));
Console.WriteLine(auth.IsValidEmail("@gmail.com"));
Console.WriteLine(auth.IsValidEmail("oydinoykamolova1gmail.com"));