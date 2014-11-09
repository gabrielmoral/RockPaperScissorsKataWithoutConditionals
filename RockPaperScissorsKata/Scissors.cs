using NUnit.Framework;
using System;
using FluentAssertions;

namespace RockPaperScissorsKata
{
	public class Scissors : Gesture
	{
		public string against (Gesture gesture)
		{
			return gesture.againstScissors ();
		}

		public string againstPaper ()
		{
			return Game.Scissors;
		}

		public string againstRock ()
		{
			return Game.Rock;
		}

		public string againstScissors ()
		{
			return Game.Tie;
		}
	}

}

