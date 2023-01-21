using FlappyBean.Runtime.View.Score;
using System;

namespace FlappyBean.Runtime.Model.Score.Interactions
{
	public class ScoreUpInteraction : IScoreInteraction
	{
		private readonly int _scoreUpValue;

		public ScoreUpInteraction(int scoreDownValue)
		{
			if (scoreDownValue < 0)
			{
				throw new ArgumentOutOfRangeException("scoreUpValue can not be less than 0");
			}

			_scoreUpValue = scoreDownValue;
		}

		public void Interact(IScoreTransformView score)
		{
			score.Up(_scoreUpValue);
		}
	}
}
