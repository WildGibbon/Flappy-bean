using FlappyBean.Runtime.Model.Movement.Player.Jump;

namespace FlappyBean.Runtime.View.Movement.Player.Jump
{
	public class PlayerJumpTestView : IPlayerJumpView
	{
		public bool IsVisualized { get; private set; } = false;

		public void Visualize(IPlayerJump movement)
		{
			IsVisualized = true;
		}
	}
}
