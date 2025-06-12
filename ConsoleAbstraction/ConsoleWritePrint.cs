namespace ConsoleAbstraction
{
	/// <summary>
	/// A static class that abstracts console input and output operations.
	/// </summary>
	public static class ConsoleWritePrint //: IConsoleWritePrint
	{
		/// <summary>
		/// Writes a message to the console with a new line at the end.
		/// </summary>
		/// <param name="message">The message to write to the console.</param>
		public static void WriteLine(string message) => Console.WriteLine(message);

		/// <summary>
		/// Writes a message to the console without a new line at the end.
		/// </summary>
		/// <param name="message">The message to write to the console.</param>
		public static void Write(string message) => Console.Write(message);


		/// <summary>
		/// Reads a line of input from the console. If the input is null, returns an empty string.
		/// </summary>
		/// <returns>Registered string, or empty string if null was registered.</returns>
		public static string ReadLine() => Console.ReadLine() ?? string.Empty;

		/// <summary>
		/// Changes the console foreground color.
		/// </summary>
		/// <param name="color">The chosen <see cref="ConsoleColor"/>.</param>
		public static void ForegroundColor(ConsoleColor color) =>
			Console.ForegroundColor = color;

		/// <summary>
		/// Resets the console color to its default value.
		/// </summary>
		public static void ResetConsoleColor() => Console.ResetColor();

		/// <summary>
		/// Clears the console.
		/// </summary>
		public static void Clear() => Console.Clear();
	}
}
