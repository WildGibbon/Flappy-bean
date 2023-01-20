using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement
{
	public struct DirectionalMovementData
	{
		public readonly float Speed;
		public readonly Vector2 Direction;
		public readonly Vector2 Position;

		public DirectionalMovementData(float speed, Vector2 direction, Vector2 position)
		{
			Speed = speed;
			Direction = direction;
			Position = position;
		}
	}
}
