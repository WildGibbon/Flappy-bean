using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Model.Movement.Player.Jump;
using FlappyBean.Runtime.View.Movement.Player.Jump;
using NUnit.Framework;
using UnityEngine;

namespace FlappyBean.Tests.MovementSystem.Player.Jump
{
	public class PlayerJumpWorkingTests
	{
		[Test]
		public void IsCorrectWorking()
		{
			var testView = new PlayerJumpTestView();
			var jump = new PlayerJump(testView, new TestInput(), new Vector2(0, 1));

			jump.Update();

			if (testView.IsVisualized)
			{
				Assert.Pass();
			}
		}
	}
}
