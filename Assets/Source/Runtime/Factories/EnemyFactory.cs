﻿using FlappyBean.Runtime.Root.Character;
using FlappyBean.Runtime.Root.Enemy;
using UnityEngine;

namespace FlappyBean.Runtime.Factories
{
	public class EnemyFactory : MonoBehaviour, IFactory<EnemyRoot>
	{
		[SerializeField] private EnemyRoot _enemyRoot;
		[SerializeField] private CharacterRoot _characterRoot;
		[SerializeField] private Transform _spawnPoint;
		[SerializeField] private float _spawnSpread;

		public EnemyRoot Create()
		{
			var spread = UnityEngine.Random.Range(-_spawnSpread, _spawnSpread);
			var spawnPoint = _spawnPoint.position + Vector3.up * spread;

			var enemy = Instantiate(_enemyRoot, spawnPoint, Quaternion.identity, _spawnPoint);
			enemy.Init(_characterRoot.Score);
			enemy.Compose();

			return enemy;
		}
	}
}
