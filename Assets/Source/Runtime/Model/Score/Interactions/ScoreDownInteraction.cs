using FlappyBean.Runtime.View.Score;
using System;

namespace FlappyBean.Runtime.Model.Score.Interactions
{
	public class ScoreDownInteraction : IScoreInteraction
	{
		private readonly int _scoreDownValue;

		public ScoreDownInteraction(int scoreDownValue)
		{
			if(scoreDownValue < 0)
			{
				throw new ArgumentOutOfRangeException("scoreDownValue can not be less than 0");
			}

			_scoreDownValue = scoreDownValue;
		}

		public void Interact(IScoreTransformView score)
		{
			if(score.CanDown(_scoreDownValue)) 
			{ 
				score.Down(_scoreDownValue);
			}
		}
	}
}
