using After.UserMgmt.Abstractions;

namespace After.UserMgmt.Models;

public class RegularUser : User, IPasswordValidator
{
    public RegularUser(string username, string password) : base(username, password)
    {
        
    }

    public bool CheckPasswordValid()
    {
        return Password.Length > 8;
    }
}