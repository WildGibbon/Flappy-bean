using FlappyBean.Runtime.Factories;
using FlappyBean.Runtime.Root.SystemUpdates;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Spawn
{
	public class Spawner<T> : IUpdatable where T : MonoBehaviour
	{
		private readonly IFactory<T> _factory;
		private readonly float _timeBetweenSpawn;

		private float _elapsedTime;

		public Spawner(IFactory<T> factory, float timeBetweenSpawn)
		{
			_factory = factory ?? throw new ArgumentNullException(nameof(factory));
			_timeBetweenSpawn = timeBetweenSpawn;
		}

		public void Update()
		{
			if (_elapsedTime >= _timeBetweenSpawn)
			{
				_factory.Create();
				_elapsedTime = 0;
			}

			_elapsedTime += Time.deltaTime;
		}
	}
}
