using NUnit.Framework;
using FlappyBean.Tests.TestsComponents;

namespace FlappyBean.Tests.Score
{
	public class ScoreCreatingTests
	{
		[Test]
		public void CantCreateWithInvalidArguments()
		{
			try
			{
				var score = new Runtime.Model.Score.Score(-1, new NullScoreView());
			}

			catch { Assert.Pass(); }
		}
	}
}
