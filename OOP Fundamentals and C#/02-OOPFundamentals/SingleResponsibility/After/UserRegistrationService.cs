using System.Data.SqlClient;
using System.Net.Mail;

namespace After;

public class UserRegistrationService
{
    private readonly SqlRepository _sql;
    private readonly EmailService _email;

    public UserRegistrationService()
    {
        _sql = new SqlRepository();
        _email = new EmailService();
    }
    
    public void RegisterUser()
    {
        _sql.AddUserToDb();
        _email.SendEmail();
    }
}