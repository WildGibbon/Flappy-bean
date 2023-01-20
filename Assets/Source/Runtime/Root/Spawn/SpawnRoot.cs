using FlappyBean.Runtime.Factories;
using FlappyBean.Runtime.Model.Spawn;
using FlappyBean.Runtime.Root.Enemy;
using FlappyBean.Runtime.Root.SystemUpdates;
using UnityEngine;

namespace FlappyBean.Runtime.Root
{
	public class SpawnRoot : CompositeRoot
	{
		[SerializeField] private EnemyFactory _factory;
		[SerializeField] private float _timeBetweenSpawn;

		private SystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var spawner = new Spawner<EnemyRoot>(_factory, _timeBetweenSpawn);
			_systemUpdate.Add(spawner);
		}

		private void Update() => _systemUpdate.UpdateAll();
	}
}
