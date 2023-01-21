using FlappyBean.Runtime.Model.Score;
using FlappyBean.Runtime.View.Score;

namespace FlappyBean.Tests.TestsComponents
{
	public class NullScoreView : IScoreView
	{
		public void Visualize(IScore score) { }
	}
}
