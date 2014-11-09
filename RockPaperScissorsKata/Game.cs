using System;

namespace RockPaperScissorsKata
{
	public class Game
	{
		public const string Rock = "Rock";
		public const string  Paper = "Paper";
		public const string  Scissors = "Scissors";
		public const string  Tie = "Tie";

		public string Hand (Gesture gesture1, Gesture gesture2)
		{
			return gesture1.against (gesture2);
		}
	}
}

