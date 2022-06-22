using Blog.Balta.Models;
using Blog.Balta.Repositories;

namespace Blog.Balta.Screens.UserScreens
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de users");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<User>(Database.Conneciton);
            var users = repository.GetAll();

            foreach (var user in users)
                Console.WriteLine($"{user.Id} - {user.Name} ({user.Email})\n{user.Bio}");                
        }
    }
}
