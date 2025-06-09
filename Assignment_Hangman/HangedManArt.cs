using ConsoleAbstraction;

namespace Assignment_Hangman
{ 
	/// <summary>
	/// This class is used to visualize the remaining number of guesses in the Hangman game.
	/// </summary>
	internal class HangedManArt
	{
		public void PrintHangedManArt(int remainingLives)
		{
			switch (remainingLives)
			{
				case 10:
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					ConsoleWritePrint.WriteLine("           ");
					break;
				case 9:
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"	         ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 8:
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 7:
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"           ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;

				case 6:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 5:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 4:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 3:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++ /|   ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 2:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++ /|\  ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 1:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++ /|\  ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++ /    ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				case 0:
					ConsoleWritePrint.WriteLine(@"   +++++   ");
					ConsoleWritePrint.WriteLine(@"   ++  0   ");
					ConsoleWritePrint.WriteLine(@"   ++ /|\  ");
					ConsoleWritePrint.WriteLine(@"   ++  |   ");
					ConsoleWritePrint.WriteLine(@"   ++ / \  ");
					ConsoleWritePrint.WriteLine(@"   ++      ");
					ConsoleWritePrint.WriteLine(@"	 ++      ");
					ConsoleWritePrint.WriteLine(@"  +---+    ");
					break;
				default:
					break;
			}
		}
	}
}