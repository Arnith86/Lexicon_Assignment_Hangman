using System.ComponentModel;
using System.Numerics;

namespace ConsoleAbstraction
{
	/// <summary>
	/// This static class supplies generic error messages that can be used throughout the application.
	/// </summary>
	public static class DisplayErrorMessages
	{
		/// <summary>
		/// Used to inform that input supplied was not letter(s).
		/// </summary>
		public static void InvalidInputNotLetter() =>
			DisplayErrorMessage("You supplied an invalid input. \n Input must contain only letters! Please try again.");

		/// <summary>
		/// Used to inform that input supplied cannot be a negative value.
		/// </summary>
		public static void InvalidInputEmpty() =>
			DisplayErrorMessage("Input cannot be empty! Please try again.");

		/// <summary>
		/// Used to inform that input supplied cannot be longer than 18 characters.
		/// </summary>
		public static void InvalidInputToLong() =>
			DisplayErrorMessage("Words in this game are no longer then 18 characters. Try again!");

		/// <summary>
		/// Displays the supplied error message in red text on the console.
		/// </summary>
		/// <param name="message">The string message to display.</param>
		public static void DisplayErrorMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			ConsoleWritePrint.WriteLine($"{message}\n");
			Console.ResetColor();
		}
	}
}