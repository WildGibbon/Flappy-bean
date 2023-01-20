using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Enemy
{
	public interface IDirectionalMovement
	{
		Vector2 CurrentPosition { get; }
	}
}
