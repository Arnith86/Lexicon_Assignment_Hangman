namespace ConsoleAbstraction
{
	/// <summary>
	/// This static class supplies generic error messages that can be used throughout the application.
	/// </summary>
	public static class DisplayErrorMessages
	{
		/// <summary>
		/// Used to inform that input supplied was either not a number or outside the expected range.
		/// </summary>
		public static void InvalidMenuInput() =>
			DisplayErrorMessage("You supplied an invalid input! \nOnly integers within the menus range are allowed, try again!");

		/// <summary>
		/// Used to inform that input supplied cannot be a negative value.
		/// </summary>
		public static void InvalidInputEmpty() =>
			DisplayErrorMessage("Input cannot be empty! Please try again.");

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