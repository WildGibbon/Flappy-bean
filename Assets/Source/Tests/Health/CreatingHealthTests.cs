using NUnit.Framework;

namespace FlappyBean.Tests.Health
{
	public class CreatingHealthTests
	{
		[Test]
		public void CantCreateHealthWithInvalidArguments()
		{
			var errors = 0;

			try
			{
				var healthWithNegativeCount = new FlappyBean.Runtime.Model.Health.Health(-1);
			}

			catch { errors++; }

			Assert.AreEqual(errors, 1);
		}
	}
}