using Blog.Balta.Models;
using Blog.Balta.Repositories;

namespace Blog.Balta.Screens.TagScreens
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de tags");
            Console.WriteLine("-------------");
            List();
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        private static void List()
        {
            var repository = new Repository<Tag>(Database.Conneciton);
            var tags = repository.GetAll();

            foreach (var item in tags)   
                Console.WriteLine($"{item.Id} - {item.Name} ({item.Slug})");  
        }
    }
}
