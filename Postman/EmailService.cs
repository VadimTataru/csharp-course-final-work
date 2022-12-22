using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace Postman
{
    public class EmailService
    {
        /// <summary>
        /// Метод отправки электронного сообщения
        /// </summary>
        /// <param name="email">Почта получателя</param>
        /// <param name="subject">Тема сообщения</param>
        /// <param name="text">Сообщение</param>
        public void SendEmail(string email, string subject, string text)
        {
            MailAddress fromAddress = new("v4gum@yandex.ru", "Inoske");
            MailAddress toAddress = new(email, "gost'");
            MailMessage message = new(fromAddress, toAddress);
            message.Body = text;
            message.Subject = subject;

            SmtpClient smtpClient = new("smtp.yandex.ru", 25);
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAddress.Address, "eaatxjehyjyzvgzd");
            
            smtpClient.Send(message);
            Console.ReadKey();
        }

        /// <summary>
        /// Метод, проверяющий валидность почты
        /// </summary>
        /// <param name="email">Проверяющаяся почта</param>
        /// <returns>Является ли почта валидной?</returns>
        public bool ValidateEmail(string email)
        {
            if (email == null)
                return false;
            email = email.Trim();
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                        @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";

            if (Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase))
                return true;

            return false;
        }


    }
}
