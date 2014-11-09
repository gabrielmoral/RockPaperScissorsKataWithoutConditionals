using NUnit.Framework;
using System;
using FluentAssertions;

namespace RockPaperScissorsKata
{
	[TestFixture ()]
	public class GameTest
	{
		private Game game;

		[SetUp()]
		public void Setup()
		{
			game = new Game ();
		}

		[Test ()]
		public void Paper_Vs_Paper ()
		{
			game.Hand (new Paper (), new Paper ()).Should ().Be (Game.Tie);
		}

		[Test ()]
		public void Rock_Vs_Rock ()
		{
			game.Hand (new Rock (), new Rock ()).Should ().Be (Game.Tie);
		}

		[Test ()]
		public void Scissors_Vs_Scissors ()
		{
			game.Hand (new Scissors (), new Scissors ()).Should ().Be (Game.Tie);
		}

		[Test ()]
		public void Rock_Vs_Paper ()
		{
			game.Hand (new Rock (), new Paper ()).Should ().Be (Game.Paper);
		}

		[Test ()]
		public void Paper_Vs_Scissors ()
		{
			game.Hand (new Paper (), new Scissors ()).Should ().Be (Game.Scissors);
		}

		[Test ()]
		public void Scissors_Vs_Rock ()
		{
			game.Hand (new Scissors (), new Rock ()).Should ().Be (Game.Rock);
		}

	}
}

