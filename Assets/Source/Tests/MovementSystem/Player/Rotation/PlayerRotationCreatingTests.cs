using FlappyBean.Runtime.Model.Movement.Character.Rotation;
using FlappyBean.Runtime.View.Movement.Character.Rotation;
using FlappyBean.Tests.TestComponents.Input;
using NUnit.Framework;

namespace FlappyBean.Tests.MovementSystem.Player.Rotation
{
	public class PlayerRotationCreatingTests
	{
		[Test]
		public void CantCreateWithInvalidArguments()
		{
			var errors = 0;
			var rotationData = new CharacterRotationData(90, -90, 1);

			try
			{
				var rotation = new CharacterRotation(null, rotationData);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 1);
		}
	}
}
