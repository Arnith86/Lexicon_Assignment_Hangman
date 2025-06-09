using ConsoleAbstraction;
using System.Text.RegularExpressions;

namespace Assignment_Hangman.Console;

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
				DisplayErrorMessages.InvalidInputEmpty();
			else if (!(_onlyLettersRegex.IsMatch(input)))
				DisplayErrorMessages.InvalidInputNotLetter();
			else if (input.Length > 1)
			{ 
				if (!(IsValidSingleWord(input)))
				{
					DisplayErrorMessages.DisplayErrorMessage(
						"Words in this game are no longer then 18 characters. Try again!"
					);
				}
			}
			else
				isValid = true;
		}
		while (!isValid);

		return input;
	}

	private bool IsValidSingleWord(string value)
	{
		return 
	}
}
