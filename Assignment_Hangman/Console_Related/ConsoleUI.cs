using ConsoleAbstraction;

namespace Assignment_Hangman.ConsoleRelated
{
	/// <summary>
	/// This class is responsible for handling the console user interface for the Hangman game. 
	/// </summary>
	internal class ConsoleUI
	{
		private readonly HangedManArt _hangedManArt;
		
		public ConsoleUI()
		{
			_hangedManArt = new HangedManArt();
		}

		public void PrintWelcomeMessage()
		{
			ConsoleWritePrint.Clear();
			ConsoleWritePrint.ForegroundColor(ConsoleColor.DarkYellow);

			ConsoleWritePrint.WriteLine("Welcome to Hangman!");
			ConsoleWritePrint.WriteLine("The rules are simple: \n" +
				"1. You will be given a secret word to guess.\n" +
				"2. You can guess one letter at a time, or the entire word at once.\n" +
				"3. If you guess a letter correctly, it will be revealed in the word.\n" +
				"4. If you guess an incorrect letter or word, you will lose a life.\n" +
				"5. The game ends when you either guess the word or run out of lives.\n");
			ConsoleWritePrint.ResetConsoleColor();
			
			ConsoleWritePrint.WriteLine("Press any key to start the game...\n");
			
			ConsoleWritePrint.ReadLine();
		}


		public void PrintGameUi(
			string secretWordGuessVersion, 
			string guessedLetters, 
			int remainingLives)
		{
			// ToDo: fix text positioning, place after hangman
			ConsoleWritePrint.Clear();
			ConsoleWritePrint.ForegroundColor(ConsoleColor.DarkCyan);
			PrintHangedMan(remainingLives);
			ConsoleWritePrint.ResetConsoleColor();
			ConsoleWritePrint.WriteLine("");
			ConsoleWritePrint.WriteLine($"Secret Word: {secretWordGuessVersion} \n\n");
			ConsoleWritePrint.WriteLine($"Guessed Letters: {guessedLetters} \n\n");
			
			ConsoleWritePrint.Write($"Guess a letter or Word: ");
		}

		private void PrintHangedMan(int remainingLives)
		{
			_hangedManArt.PrintHangedManArt(remainingLives);
		}
	}
}