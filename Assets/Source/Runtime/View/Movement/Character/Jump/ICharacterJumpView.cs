using FlappyBean.Runtime.Model.Movement.Character.Jump;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Character
{
	public interface ICharacterJumpView
	{
		void Visualize(Vector2 jumpDirection);
	}
}
