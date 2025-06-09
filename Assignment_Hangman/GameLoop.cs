

namespace Assignment_Hangman
{
	internal class GameLoop
	{
		
		private string _secretWord = string.Empty;
		private char[]? _secretWordGuessVersion;


		public string SecretWord 
		{ 
			get => _secretWord;
			private set 
			{
				if (IsValidWord(value))
					_secretWord = value;
			} 
		}


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

		internal void StartGameRound()
		{
			
		}
	}
}