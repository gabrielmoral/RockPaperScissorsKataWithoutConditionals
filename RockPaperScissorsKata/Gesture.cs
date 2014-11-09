using System;

namespace RockPaperScissorsKata
{
	public interface Gesture
	{
		string against (Gesture gesture);

		string againstPaper ();

		string againstRock ();

		string againstScissors ();
	}
}

