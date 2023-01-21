using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public struct PlayerRotationData
	{
		public readonly float MaxValue;
		public readonly float MinValue;
		public readonly float Speed;

		public PlayerRotationData(float maxValue, float minValue, float speed)
		{
			MaxValue = maxValue;
			MinValue = minValue;
			Speed = speed;
		}
	}
}
