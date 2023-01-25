using FlappyBean.Runtime.Root.SystemUpdates;
using UnityEngine;
using System;

namespace FlappyBean.Runtime.Model.Spawn.Timer
{
	public class Timer : ITimer
	{
		public bool IsActive { get; private set; }

		private float _elapsedTime;
		private readonly float _timeBetweenActivation;

		public Timer(float timeBetweenActivation)
		{
			if(timeBetweenActivation< 0)
			{
				throw new ArgumentOutOfRangeException("TimeBetweenSpawn can not be less than 0");
			}

			_timeBetweenActivation = timeBetweenActivation;
		}

		public void Update()
		{
			IsActive = false;

			if (_elapsedTime >= _timeBetweenActivation)
			{
				IsActive = true;
				_elapsedTime = 0;
			}

			_elapsedTime += Time.deltaTime;
		}
	}
}
