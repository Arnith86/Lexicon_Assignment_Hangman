namespace Assignment_Hangman.WordLoaders;

/// <summary>
/// Interface for loading words.
/// </summary>
internal interface IWordLoader
{
	/// <summary>
	/// Loads words from a source and returns them as a list of strings. 
	/// </summary>
	/// <returns>A <see cref="List{string}"/> with words.</returns>
	List<string> LoadWords();
}