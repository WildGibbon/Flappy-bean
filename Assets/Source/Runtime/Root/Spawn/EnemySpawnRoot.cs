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

		private SpawnCycle<Enemy.EnemyRoot> _spawnCycle;
		private SystemUpdate _systemUpdate;
		private ITimer _timer;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			_timer = new Timer(_timeBetweenSpawn);
			_spawnCycle = new SpawnCycle<Enemy.EnemyRoot>(_factory, _timer);
			
			_systemUpdate.Add(_spawnCycle);
		}

		private void Update() => _systemUpdate.UpdateAll();
	}
}
