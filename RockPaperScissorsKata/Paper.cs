using NUnit.Framework;
using System;
using FluentAssertions;

namespace RockPaperScissorsKata
{
	public class Paper : Gesture
	{
		public string against (Gesture gesture)
		{
			return gesture.againstPaper ();
		}

		public string againstRock ()
		{
			return Game.Paper;
		}

		public string againstPaper ()
		{
			return Game.Tie;
		}

		public string againstScissors ()
		{
			return Game.Scissors;
		}
	}	
}

