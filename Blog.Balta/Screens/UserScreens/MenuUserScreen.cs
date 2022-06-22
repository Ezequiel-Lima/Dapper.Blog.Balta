namespace Blog.Balta.Screens.UserScreens
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de users");
            Console.WriteLine("--------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar users");
            Console.WriteLine("2 - Cadastrar user");
            Console.WriteLine("3 - Atualizar user");
            Console.WriteLine("4 - Excluir user");
            Console.WriteLine();
            Console.WriteLine();
            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
