using System.Runtime.InteropServices;

namespace GA_Pokemon.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            var GameInstance = new Game();
            

            Console.WriteLine("Welcome to the Pokemon Console World!");

            GameInstance.PlayGame();
        }
    }
}
