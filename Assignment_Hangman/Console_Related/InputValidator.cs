using ConsoleAbstraction;
using System.Text.RegularExpressions;

namespace Assignment_Hangman.ConsoleRelated;

internal class InputValidator : IInputValidator
{
	private readonly Regex _onlyLettersRegex = new Regex(@"^[A-Za-z]+$");

	public string validateInput()
	{
		string input = string.Empty;
		bool isValid = false;

		do
		{
			input = ConsoleWritePrint.ReadLine();

			if (string.IsNullOrWhiteSpace(input))
			{
				DisplayErrorMessages.InvalidInputEmpty();
			}
			else if (!(_onlyLettersRegex.IsMatch(input)))
			{
				DisplayErrorMessages.InvalidInputNotLetter();
			}	  
			else if (input.Length > 1 && !(IsValidWord(input)))
			{
				DisplayErrorMessages.InvalidInputToLong();
			}
			else
				isValid = true;
		}
		while (!isValid);

		return input;
	}

	private bool IsValidWord(string value)
	{
		return value.Length <= 18;
	}
}
