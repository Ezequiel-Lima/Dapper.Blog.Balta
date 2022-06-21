using Blog.Balta.Models;
using Blog.Balta.Repositories;

namespace Blog.Balta.Screens.TagScreens
{
    public class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Id: ");
            var id = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Nome: ");
            var name = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Update(new Tag { Id = id, Name = name, Slug = slug });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Conneciton);
                repository.Update(tag);
                Console.WriteLine("Tag Atualizada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível atualizar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
