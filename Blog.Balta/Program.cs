using Blog.Balta.Models;
using Blog.Balta.Repositories;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=false";

var connection = new SqlConnection(CONNECTION_STRING);

connection.Open();
ReadUsers(connection);
ReadRoles(connection);
ReadTags(connection);
ReadUsersWithRoles(connection);
connection.Close();

static void ReadUsers(SqlConnection connection)
{
    var repository = new Repository<User>(connection);
    var users = repository.GetAll();

    foreach (var user in users)
        Console.WriteLine($"{user.Name} - {user.Roles}"); 
}

static void ReadRoles(SqlConnection connection)
{
    var repository = new Repository<Role>(connection);
    var roles = repository.GetAll();

    foreach (var role in roles)
        Console.WriteLine($"{role.Name} - {role.Slug}");
}

static void ReadTags(SqlConnection connection)
{
    var repository = new Repository<Tag>(connection);
    var tags = repository.GetAll();

    foreach (var item in tags)
        Console.WriteLine($"{item.Name} - {item.Slug}"); 
}

static void ReadUsersWithRoles(SqlConnection connection)
{
    var repository = new UserRepository(connection);
    var items = repository.GetWithRoles();

    foreach (var user in items)
    {
        Console.WriteLine(user.Name);
        foreach (var role in user.Roles)
        {
            Console.WriteLine($" - {role.Name}");
        }
    }
}