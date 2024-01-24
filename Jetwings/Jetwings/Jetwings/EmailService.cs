using MimeKit;
using MailKit.Net.Smtp;

public class EmailService
{
    public static void SendEmail(string to, string subject, string body)
    {
        string smtpServer = "smtp.gmail.com";
        int smtpPort = 587;
        string smtpUsername = "info.jetwingshotels@gmail.com"; // Your Gmail email address
        string smtpPassword = "GADCOURSEWORK12345";

        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Jetwings Hotels", smtpUsername)); // Your name and email
        message.To.Add(new MailboxAddress("", to)); // Recipient's email address
        message.Subject = subject;
        message.Body = new TextPart("plain") { Text = body };

        using (var client = new SmtpClient())
        {
            client.Connect(smtpServer, smtpPort, false);
            client.Authenticate(smtpUsername, smtpPassword);
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
