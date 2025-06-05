namespace Assignment_Hangman.WordLoaders;

/// <summary>
/// Concrete implementation of <see cref="IWordLoader"/> that loads words from a text file.
/// </summary>
internal class WordLoader : IWordLoader
{
	/// <inheritdoc />
	public List<string> LoadWords()
	{
		string filePath = @"Words\Hangman_Word_List.txt";

		if (!File.Exists(filePath))
			throw new FileNotFoundException();

		return File.ReadAllText(filePath)
			.Trim()
			.Split(',')
			.ToList();
	}
}