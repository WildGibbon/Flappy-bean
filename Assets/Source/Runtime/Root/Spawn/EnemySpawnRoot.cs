using FlappyBean.Runtime.Factories;
using FlappyBean.Runtime.Model.Spawn;
using FlappyBean.Runtime.Model.Spawn.Timer;
using FlappyBean.Runtime.Root.SystemUpdates;
using UnityEngine;

namespace FlappyBean.Runtime.Root
{
	public class EnemySpawnRoot : CompositeRoot
	{
		[SerializeField] private EnemyFactory _factory;
		[SerializeField] private float _timeBetweenSpawn;

		private SystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var timer = new Timer(_timeBetweenSpawn);
			var spawnCycle = new SpawnCycle<Enemy.EnemyRoot>(_factory, timer);
			
			_systemUpdate.Add(spawnCycle);
		}

		private void Update() => _systemUpdate.UpdateAll();
	}
}
