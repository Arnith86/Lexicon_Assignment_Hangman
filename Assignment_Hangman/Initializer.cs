using Assignment_Hangman.WordLoaders;
using ConsoleAbstraction;

namespace Assignment_Hangman;

internal class Initializer<T>
{
	private string[]? _wordArray;
	private readonly IWordLoader<T> _wordLoader;
	private GameLoop _gameLoop;

	public string[] WordList { get; protected set; } = new string[] { };

	public Initializer(IWordLoader<T> wordLoader, GameLoop gameLoop)
	{
		_wordLoader = wordLoader;
		_gameLoop = gameLoop;
		InitializeGameVariables();
		StartNewGame();
	}

	private void StartNewGame()
	{
		Random random = new Random(); 
		int WordAmount = _wordArray.Length;
		int randomWordIndex = random.Next(0, WordAmount);

		// ToDo: how should i handle thrown exception here?
		_gameLoop.PrepareNewSecretWord( _wordArray[randomWordIndex]);

		_gameLoop.GuessingLoop();
	}

	private void InitializeGameVariables()
	{
		try
		{
			_wordArray = _wordLoader.LoadWords().ToArray();
		}
		catch (FileNotFoundException)
		{
			DisplayErrorMessages.DisplayErrorMessage("Warning: Word file not found. Loading fallback word list.");
						
			_wordArray = new string[] { "default", "backup", "words" };
		}
	}
}