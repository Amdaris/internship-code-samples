
using After.UserMgmt.Models;
using After.UserMgmt.Services;

namespace After;

public class Consumer
{
    private readonly UserRegistrationService _userService = new();
    
    public void Run()
    {
        var user = new RegularUser("dan", "Password");
        _userService.RegisterUser(user);

        var admin = new Administrator("admin", "Password");
        _userService.RegisterUser(admin);
    }
}