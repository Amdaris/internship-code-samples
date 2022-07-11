using After.UserMgmt.Abstractions;

namespace After.UserMgmt.Models;

public class Administrator : User, IPasswordValidator, IWorkflowOperations
{
    public Administrator(string username, string password) : base(username, password)
    {
        
    }
    public bool CheckPasswordValid()
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
    
    public void ApproveWorkflow()
    {
        Console.WriteLine("Workflow approved");
    }
}