using Assignment_Hangman.ConsoleRelated;
using Assignment_Hangman.WordLoaders;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Assignment_Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWordLoader<string> wordLoader = new WordLoader<string>();
            StringBuilder stringBuilder = new StringBuilder();
            ConsoleUI consoleUI = new ConsoleUI();
            IInputValidator inputValidator = new InputValidator();

            GameLoop gameLoop = new GameLoop(consoleUI, stringBuilder, inputValidator);

            consoleUI.PrintWelcomeMessage();

            Initializer<string> initializer = new Initializer<string>(wordLoader, gameLoop);
        }
    }
}
