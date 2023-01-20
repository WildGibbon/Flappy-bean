using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Model.Movement.Player.Jump;
using FlappyBean.Runtime.View.Movement.Player.Jump;
using NUnit.Framework;
using UnityEngine;

namespace FlappyBean.Tests.MovementSystem.Player.Jump
{
	public class PlayerJumpCreatingTests
	{
		[Test]
		public void CantCreateWithInvalidArguments()
		{
			var errors = 0;

			try
			{
				var jump = new PlayerJump(null, new TestInput(), new Vector2(0, 1));
			}

			catch { errors++; }

			try
			{
				var jump = new PlayerJump(new PlayerJumpTestView(), null, new Vector2(0, 1));
			}

			catch { errors++; }

			Assert.AreEqual(errors, 2);
		}
	}
}
