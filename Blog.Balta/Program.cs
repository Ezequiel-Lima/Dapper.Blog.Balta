using Blog.Balta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=false";

ReadUser();

static void ReadUser()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        //só com isso eu consigo consulta todos os meus usuarios
        var users = connection.GetAll<User>();

        foreach (var user in users)
        {
            Console.WriteLine(user.Name);
        }
    }
}