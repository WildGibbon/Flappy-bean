using FlappyBean.Runtime.Root.SystemUpdates;

namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public interface IPlayerRotation : IUpdatable
	{
		float Value { get; }
		void Rotate();
		void Update();
	}
}
