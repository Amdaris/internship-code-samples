using System.Net.Mail;

namespace Before.UserMgmt.Services;

public class EmailService
{
    public void SendEmail()
    {
        SmtpClient client = new SmtpClient("smtp.myhost.com");
        client.Send(new MailMessage());
    }
}