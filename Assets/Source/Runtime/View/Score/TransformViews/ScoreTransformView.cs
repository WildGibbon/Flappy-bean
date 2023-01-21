using FlappyBean.Runtime.Model.Score;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.View.Score
{
	public class ScoreTransformView : MonoBehaviour, IScoreTransformView
	{
		private IScore _score;
		
		public void Init(IScore score)
		{
			_score = score ?? throw new ArgumentNullException("score can not be null");
		}

		public bool CanDown(int value)
		{
			return _score.CanDown(value);
		}

		public void Down(int value)
		{
			_score.Down(value);
		}

		public void Up(int value)
		{
			_score.Up(value);
		}
	}
}
