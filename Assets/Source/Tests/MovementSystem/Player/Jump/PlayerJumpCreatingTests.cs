using FlappyBean.Runtime.Model.Movement.Character.Jump;
using FlappyBean.Runtime.View.Movement.Character.Jump;
using FlappyBean.Tests.TestComponents.Input;
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
				var jump = new CharacterJump(null, new Vector2(0, 1));
			}

			catch { errors++; }

			Assert.AreEqual(errors, 1);
		}
	}
}
