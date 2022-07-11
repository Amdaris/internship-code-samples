namespace Before.UserMgmt.Models;

public class Administrator : User
{
    public Administrator(string username, string password) : base(username, password)
    {
        
    }
    public override bool CheckPasswordValid()
    {
        return Password.Length > 8 && ContainsDigit(Password);
    }

    private bool ContainsDigit(string stringToCheck)
    {
        foreach (var ch in stringToCheck)
        {
            if (Char.IsNumber(ch)) return true;
        }

        return false;
    }
    
    public override void ApproveWorkflow()
    {
        Console.WriteLine("Workflow approved");
    }
}