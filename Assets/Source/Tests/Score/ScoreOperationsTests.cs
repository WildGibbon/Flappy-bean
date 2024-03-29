﻿using FlappyBean.Runtime.Model.Score;
using FlappyBean.Tests.TestsComponents;
using NUnit.Framework;

namespace FlappyBean.Tests.Score
{
	public class ScoreOperationsTests
	{
		private IScore _score;

		[SetUp]
		public void Setup()
		{
			_score = new Runtime.Model.Score.Score(0, new NullScoreView());
		}

		[Test]
		public void IsScoreUpWorksCorrectly() 
		{
		    try
			{
				_score.Increase(-1);
			}

			catch { Assert.Pass(); }
		}

		[Test]
		public void IsScoreDownWorksCorrectly()
		{
			var errors = 0;

			try
			{
				_score.Decrease(-1);
			}

			catch { errors++; }

			try
			{
				_score.Decrease(1);
			}

			catch { errors++; }

			Assert.AreEqual(2, errors);
		}

		[Test]
		public void IsScoreUpCalculatingCorrectly()
		{
			_score.Increase(1);

			Assert.AreEqual(_score.Value, 1);
		}

		[Test]
		public void IsScoreDownCalculatingCorrectly()
		{
			_score.Increase(1);
			_score.Decrease(1);

			Assert.AreEqual(_score.Value, 0);
		}
	}
}
