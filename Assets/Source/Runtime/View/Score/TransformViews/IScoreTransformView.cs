using FlappyBean.Runtime.Model.Score;

namespace FlappyBean.Runtime.View.Score
{
	public interface IScoreTransformView
	{
		void Init(IScore score);
		void Up(int value);
		void Down(int value);
		bool CanDown(int value);
	}
}
