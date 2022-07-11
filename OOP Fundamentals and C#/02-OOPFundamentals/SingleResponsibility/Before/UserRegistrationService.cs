using System.Data.SqlClient;
using System.Net.Mail;

namespace Before;

public class UserRegistrationService
{
    public void RegisterUser()
    {
        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand command = new SqlCommand("INSERT INTO [...]"); //Insert user into db

        SmtpClient client = new SmtpClient("smtp.myhost.com");
        client.Send(new MailMessage());
    }
}