using Assignment_Hangman.WordLoaders;

namespace Assignment_Hangman;

internal class GameLoop
{
	private List<string> _wordList;
	private readonly IWordLoader _wordLoader;
	
	public List<string> WordList { get; protected set; }

	public GameLoop(IWordLoader wordLoader)
	{
		_wordLoader = wordLoader;
		InitializeGameVariables();
		

		
	}

	private void InitializeGameVariables()
	{
		try
		{
			_wordList = _wordLoader.LoadWords();
		}
		catch (FileNotFoundException e)
		{

			throw new Exception();
		}
	}
}