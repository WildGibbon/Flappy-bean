using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Character.Rotation
{
	public struct CharacterRotationData
	{
		public readonly float MaxValue;
		public readonly float MinValue;
		public readonly float Speed;

		public CharacterRotationData(float maxValue, float minValue, float speed)
		{
			MaxValue = maxValue;
			MinValue = minValue;
			Speed = speed;
		}
	}
}
