

using ConsoleAbstraction;
using System.Text;

namespace Assignment_Hangman
{
	internal class GameLoop
	{
		private readonly ConsoleUI _consoleUI;
		private string _secretWord = string.Empty;
		private const int _c_MAX_LIVES = 10;

		private int _remainingLives;
		private char[]? _secretWordGuessVersion;
		private char[]? _guessedLetters = new char[26]; // inject trough constructor? if other language?

		public string SecretWord 
		{ 
			get => _secretWord;
			private set 
			{
				if (IsValidWord(value))
					_secretWord = value;
			} 
		}

		public int RemainingLives 
		{ 
			get => _remainingLives;
			private set
			{
				if (IsLivesValid(value))
					_remainingLives = value;
			}
		}

		public GameLoop(ConsoleUI consoleUI)
		{
			_consoleUI = consoleUI;
			RemainingLives = _c_MAX_LIVES;
		}


		// ToDo: move validation logic to seperate class 
		private bool IsLivesValid(int value)
		{
			if (value > _c_MAX_LIVES || value < 0)
			{
				throw new ArgumentOutOfRangeException(
					nameof(value),
					"Remaining lives cannot exceed maximum lives of 10 or be lower then 0."
				);
			}

			return true;
		}

		// ToDo: move validation logic to seperate class 
		private bool IsValidWord(string value)
		{
			if (string.IsNullOrWhiteSpace(value))
			{
				// ToDo: Handle this exception.
				throw new ArgumentNullException(nameof(value), "Secret word cannot be null or empty.");
			}
			else if (value.Length > 18) 
			{
				throw new ArgumentOutOfRangeException(nameof(value), "Secret word cannot be longer then 18 characters.");
			}

			return true;
		}

		internal void PrepareNewSecretWord(string secretWord)
		{
			SecretWord = secretWord;
			_secretWordGuessVersion = new char[secretWord.Length];
			
			SetInitialValuesOfSecretWordGuessVersion(_secretWordGuessVersion);
		}

		private void SetInitialValuesOfSecretWordGuessVersion(char[] secretWordGuessVersion)
		{
			for (int i = 0; i < secretWordGuessVersion.Count(); i++)
			{
				secretWordGuessVersion[i] = '_';
			}
		}

		
		public void GuessingLoop()
		{
			bool gameWon = false;
			bool gameLost = false;

			int tempTestValue = 10;

			do
			{
				_consoleUI.PrintGameUi(
					secretWordGuessVersion: BuildString(_secretWordGuessVersion),
					guessedLetters: BuildString(_guessedLetters),
					RemainingLives
				);

				RemainingLives--;
				Console.ReadKey();
			} while (!gameWon || !gameLost);
			
		}

		private string BuildString(char[]? charArray)
		{
			StringBuilder sb = new StringBuilder();

			for (int i = 0; i < charArray.Length; i++)
			{
				sb.Append(charArray[i]);
			}

			return sb.ToString();
		}
	}
}