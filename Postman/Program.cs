using System.Net.Mail;
using System.Text.RegularExpressions;

StartApp();

void StartApp()
{
    string email;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите email: ");
        email = Console.ReadLine();
        if (!ValidateEmail(email))
        {
            Console.WriteLine("Email не корректен!!!");
            Thread.Sleep(2000);
            continue;
        }

        break;
    }

    SendEmail();

}

void SendEmail()
{
    SmtpClient client = new SmtpClient();
}

bool ValidateEmail(string email)
{
    if(email == null)
        return false;
    email = email.Trim();
    string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

    if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
        return true;
    
    return false;
}
