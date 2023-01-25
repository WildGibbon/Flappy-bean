using FlappyBean.Runtime.Model.Movement.Character.Jump;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Character.Jump
{
	public class CharacterJumpTestView : ICharacterJumpView
	{
		public bool IsVisualized { get; private set; } = false;

		public void Visualize(Vector2 movement)
		{
			IsVisualized = true;
		}
	}
}
