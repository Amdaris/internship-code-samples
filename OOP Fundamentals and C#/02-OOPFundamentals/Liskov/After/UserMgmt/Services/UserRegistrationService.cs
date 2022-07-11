using System.Data.SqlClient;
using System.Net.Mail;
using After.UserMgmt.Abstractions;
using After.UserMgmt.Models;
using After.UserMgmt.Repositories;

namespace After.UserMgmt.Services;

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
        var pwValidator = user as IPasswordValidator;
        if (!pwValidator!.CheckPasswordValid())
            throw new ArgumentException("Password is not valid");
        
        _userRepo.AddUserToDb();
        _email.SendEmail();
    }
}