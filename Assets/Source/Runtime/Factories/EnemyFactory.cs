using FlappyBean.Runtime.Model.Character;
using FlappyBean.Runtime.Root.Character;
using FlappyBean.Runtime.Root.Enemy;
using Sirenix.OdinInspector;
using UnityEngine;

namespace FlappyBean.Runtime.Factories
{
	public class EnemyFactory : SerializedMonoBehaviour, IFactory<EnemyRoot>
	{
		[SerializeField] private EnemyRoot _enemyRoot;
		[SerializeField] private Transform _spawnPoint;
		[SerializeField] private float _spawnSpread;
		[SerializeField] private ICharacter _character;

		public EnemyRoot Create()
		{
			var spread = UnityEngine.Random.Range(-_spawnSpread, _spawnSpread);
			var spawnPoint = _spawnPoint.position + Vector3.up * spread;

			var enemy = Instantiate(_enemyRoot, spawnPoint, Quaternion.identity, _spawnPoint);
			enemy.Init(_character.Score);
			enemy.Compose();

			return enemy;
		}
	}
}
