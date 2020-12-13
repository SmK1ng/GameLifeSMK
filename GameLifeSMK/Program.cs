using System.IO;

namespace GameLifeSMK
{
    class Program
    {
        static void Main()
        {
            if (File.Exists("figures_list"))
                GameFigures.GetFiguresFromFile("figures_list");
            GameEngine.Run();
        }
    }
}
