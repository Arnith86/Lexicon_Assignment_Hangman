using Assignment_Hangman.WordLoaders;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWordLoader<string> wordLoader = new WordLoader<string>();
            GameLoop gameLoop = new GameLoop();

            Initializer<string> initializer = new Initializer<string>(wordLoader, gameLoop);
        }
    }
}
