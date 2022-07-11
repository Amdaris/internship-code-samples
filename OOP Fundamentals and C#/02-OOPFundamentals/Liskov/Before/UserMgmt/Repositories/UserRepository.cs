using System.Data.SqlClient;

namespace Before.UserMgmt.Repositories;

public class UserRepository
{
    public void AddUserToDb()
    {
        SqlConnection connection = new SqlConnection();
        connection.Open();
        SqlCommand command = new SqlCommand("INSERT INTO [...]"); //Insert user into db
    }
}