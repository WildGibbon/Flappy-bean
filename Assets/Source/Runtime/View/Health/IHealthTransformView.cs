using FlappyBean.Runtime.Model.Health;
namespace FlappyBean.Runtime.View.Health
{
	public interface IHealthTransformView
	{
		int Value { get; }
		int MaxValue { get; }
		bool IsDead { get; }

		void Init(IHealth health);
		void TakeDamage(int value);
		void Heal(int value);
	}
}