using System.Data.SqlClient;
using System.Net.Mail;
using Before.UserMgmt.Models;
using Before.UserMgmt.Repositories;

namespace Before.UserMgmt.Services;

public class UserRegistrationService
{
    private readonly EmailService _email;
    private readonly UserRepository _userRepo;

    public UserRegistrationService()
    {
        _email = new EmailService();
        _userRepo = new UserRepository();
    }
    
    public void RegisterUser(User user)
    {
        if (!user.CheckPasswordValid())
            throw new ArgumentException("Password is not valid");
        
        _userRepo.AddUserToDb();
        _email.SendEmail();
    }
}