namespace FlappyBean.Runtime.Model.Health
{
	public interface IHealth
	{
		int Value { get; }
		int MaxValue { get; }
		bool IsDead { get; }

		void TakeDamage(int value);
		void Heal(int value);
	}
}
