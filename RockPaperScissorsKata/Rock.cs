using NUnit.Framework;
using System;
using FluentAssertions;

namespace RockPaperScissorsKata
{
	public class Rock : Gesture
	{	
		public string against (Gesture gesture)
		{
			return gesture.againstRock ();
		}

		public string againstPaper ()
		{
			return Game.Paper;
		}

		public string againstRock ()
		{
			return Game.Tie;
		}

		public string againstScissors ()
		{
			return Game.Rock;
		}
	}
}

