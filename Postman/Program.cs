using Postman;

StartApp();

void StartApp()
{
    EmailService service = new();
    string email;
    string subject;
    string body;
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Введите email: ");
        email = Console.ReadLine();
        if (!service.ValidateEmail(email))
        {
            Console.WriteLine("Email не корректен!!!");
            Thread.Sleep(2000);
            continue;
        }
        Console.WriteLine("Введите тему сообщения: ");
        subject = Console.ReadLine();

        Console.WriteLine("Введите сообщение для отправки: ");
        body = Console.ReadLine();

        service.SendEmail(email, subject, body);

        break;
    }
}
