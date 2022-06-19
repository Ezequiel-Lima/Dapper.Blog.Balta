using Blog.Balta.Models;
using Blog.Balta.Repositories;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=false";

var connection = new SqlConnection(CONNECTION_STRING);

connection.Open();
ReadUsers(connection);
connection.Close();
//ReadUser();
//CreateUser();
//UpdateUser();
//DeleteUser();

static void ReadUsers(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var users = repository.GetAll();

    foreach (var user in users)
        Console.WriteLine($"{user.Name} - {user.Email}"); 
}