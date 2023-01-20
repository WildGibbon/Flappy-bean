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
			MaxValue = Mathf.Clamp(maxValue, 0, 360);
			MinValue = Mathf.Clamp(minValue, 0, MaxValue);
			Speed = speed;
		}
	}
}
