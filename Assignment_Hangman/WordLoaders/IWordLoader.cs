namespace Assignment_Hangman.WordLoaders;

/// <summary>
/// Interface for loading words.
/// </summary>
internal interface IWordLoader<T> 
{
	/// <summary>
	/// Loads words from a source and returns a collection with the words. 
	/// </summary>
	/// <returns>A <see cref="IEnumerable{T}"/> </returns>
	IEnumerable<string> LoadWords();
}