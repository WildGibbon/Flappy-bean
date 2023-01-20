using FlappyBean.Runtime.Model.Movement.Player.Rotation;
using FlappyBean.Runtime.View.Movement.Player.Rotation;
using FlappyBean.TestComponents.Input;
using NUnit.Framework;

namespace FlappyBean.Tests.MovementSystem.Player.Rotation
{
	public class PlayerRotationCreatingTests
	{
		[Test]
		public void CantCreateWithInvalidArguments()
		{
			var errors = 0;
			var rotationData = new PlayerRotationData(90, -90, 1);

			try
			{
				var rotation = new PlayerRotation(null, new NullPlayerRotationView(), rotationData);
			}

			catch { errors++; }

			try
			{
				var rotation = new PlayerRotation(new TestInput(), null, rotationData);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 2);
		}
	}
}
