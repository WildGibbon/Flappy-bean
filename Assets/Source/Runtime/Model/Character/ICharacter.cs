using FlappyBean.Runtime.Model.Score;

namespace FlappyBean.Runtime.Model.Character
{
	public interface ICharacter
	{
		IScore Score { get; }

		void Init(IScore score);
	}
}
