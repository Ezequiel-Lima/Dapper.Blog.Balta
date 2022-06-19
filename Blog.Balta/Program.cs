using Blog.Balta.Models;
using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;

const string CONNECTION_STRING = @"Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;Encrypt=false";

ReadUsers();
//ReadUser();
//CreateUser();
//UpdateUser();
//DeleteUser();

static void ReadUsers()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        //só com isso eu consigo consulta todos os meus usuarios
        var users = connection.GetAll<User>();

        foreach (var user in users)
        {
            Console.WriteLine(user.Name + " - " + user.Email);
        }
    }
}

static void ReadUser()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var user = connection.Get<User>(1);

        Console.WriteLine(user.Name + " - " + user.Email);
    }
}


static void CreateUser()
{
    var user = new User()
    {
        Bio = "Equipe balta.io",
        Email = "hello@balta.io",
        Image = "https://...",
        Name = "Equipe balta.io",
        PasswordHash = "HASH",
        Slug = "equipe balta"
    };

    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Insert<User>(user);
        Console.WriteLine("Cadastro Realizado com sucesso!");
    }
}

static void UpdateUser()
{
    var user = new User()
    {
        Id = 3,
        Bio = "Equipe | balta.io",
        Email = "hello@balta.io",
        Image = "https://...",
        Name = "Equipe de suporte balta.io",
        PasswordHash = "HASH",
        Slug = "equipe balta"
    };

    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        connection.Update<User>(user);
        Console.WriteLine("Atualização Realizado com sucesso!");
    }
}

static void DeleteUser()
{
    using (var connection = new SqlConnection(CONNECTION_STRING))
    {
        var user = connection.Get<User>(3);
        connection.Delete<User>(user);
        Console.WriteLine("Exclusão Realizado com sucesso!");
    }
}