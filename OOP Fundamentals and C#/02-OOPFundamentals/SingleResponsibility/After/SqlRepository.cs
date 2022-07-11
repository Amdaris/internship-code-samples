using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After
{
    internal class SqlRepository
    {
        public void AddUserToDb()
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]"); //Insert user into db
        }
    }
}
