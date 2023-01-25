using FlappyBean.Runtime.Factories;
using FlappyBean.Runtime.Model.Spawn.Timer;
using FlappyBean.Runtime.Root.SystemUpdates;
using System;

namespace FlappyBean.Runtime.Model.Spawn
{
	public class SpawnCycle<T> : IUpdatable
	{
		private readonly IFactory<T> _factory;
		private readonly ITimer _timer;

		public SpawnCycle(IFactory<T> factory, ITimer timer)
		{
			_factory = factory ?? throw new ArgumentNullException("Factory can not be null");
			_timer = timer ?? throw new ArgumentNullException("Timer can not be null");
		}

		public void Update()
		{
			_timer.Update();

			if (_timer.IsActive)
			{
				_factory.Create();
			}
		}
	}
}
