namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public interface IPlayerRotation
	{
		float Value { get; }
		void Rotate();
		void Update();
	}
}
