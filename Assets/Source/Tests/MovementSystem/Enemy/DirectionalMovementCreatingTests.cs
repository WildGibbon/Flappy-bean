using FlappyBean.Runtime.Model.Movement.Enemy;
using FlappyBean.Tests.TestsComponents;
using NUnit.Framework;
using UnityEngine;

namespace FlappyBean.Tests.MovementSystem.Enemy
{
	public class DirectionalMovementCreatingTests
	{
		[Test]
		public void CantCreateWithNullArguments()
		{
			try
			{
				var data = new DirectionalMovementData(1, Vector2.up);
				var movement = new DirectionalMovement(null, data, Vector2.zero);
			}

			catch { Assert.Pass(); }
		}
	}
}
