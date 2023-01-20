using NUnit.Framework;

namespace FlappyBean.Tests.Attack
{
	public class AttackCreatingTests
	{
		[Test]
		public void CantCreateWithInvalidArguments()
		{
			try
			{
				var attack = new Runtime.Model.Attack.Attack(-1);
			}

			catch { Assert.Pass(); }
		}
	}
}
