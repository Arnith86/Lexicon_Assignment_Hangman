using Assignment_Hangman.WordLoaders;

namespace Assignment_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWordLoader wordLoader = new WordLoader();

            GameLoop gameLoop = new GameLoop(wordLoader);
        }
    }
}
