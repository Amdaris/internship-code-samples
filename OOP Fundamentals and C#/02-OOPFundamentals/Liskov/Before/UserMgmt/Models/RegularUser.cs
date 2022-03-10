namespace Before.UserMgmt.Models;

public class RegularUser : User
{
    public RegularUser(string username, string password) : base(username, password)
    {
        
    }

    public override void ApproveWorkflow()
    {
        throw new ApplicationException("Regular user cannot approve workflows");
    }
}