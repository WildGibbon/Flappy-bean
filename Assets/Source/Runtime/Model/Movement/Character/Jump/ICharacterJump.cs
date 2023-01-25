using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Character.Jump
{
	public interface ICharacterJump
	{
		Vector2 Direction { get; }
		void Jump();
	}
}
