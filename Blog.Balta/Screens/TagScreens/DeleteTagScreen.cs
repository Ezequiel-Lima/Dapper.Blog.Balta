using Blog.Balta.Models;
using Blog.Balta.Repositories;

namespace Blog.Balta.Screens.TagScreens
{
    public class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir uma tag");
            Console.WriteLine("-------------");
            Console.WriteLine("Qual o id da Tag que deseja excluir: ");
            var id = int.Parse(Console.ReadLine()!);

            Delete(id);
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Conneciton);
                repository.Delete(id);
                Console.WriteLine("Tag excluida com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
