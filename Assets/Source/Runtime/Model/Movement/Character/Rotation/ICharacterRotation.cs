using FlappyBean.Runtime.Root.SystemUpdates;

namespace FlappyBean.Runtime.Model.Movement.Character.Rotation
{
	public interface ICharacterRotation : IUpdatable
	{
		float Value { get; }
		void Rotate();
	}
}
