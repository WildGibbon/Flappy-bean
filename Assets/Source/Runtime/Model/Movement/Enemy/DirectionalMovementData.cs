﻿using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Enemy
{
	public struct DirectionalMovementData
	{
		public readonly float Speed;
		public readonly Vector2 Direction;

		public DirectionalMovementData(float speed, Vector2 direction)
		{
			Speed = speed;
			Direction = direction;
		}
	}
}
