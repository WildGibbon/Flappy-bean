using FlappyBean.Runtime.View.Health;
using Sirenix.OdinInspector;
using System.Collections;
using UnityEngine;

namespace FlappyBean.Runtime.Root
{
	public class GameEnd : SerializedMonoBehaviour
	{
		[SerializeField] private GameObject _gameOverMenu;
		[SerializeField] private IHealthTransformView _playerHealth;

		private float _playerDeathCheckDelay = 0.1f;

		private void Awake()
		{
			_gameOverMenu?.SetActive(false);
			StartCoroutine(PlayerDeathCheckCycle());
		}

		private IEnumerator PlayerDeathCheckCycle()
		{
			while (true)
			{
				yield return new WaitForSeconds(_playerDeathCheckDelay);

				if (_playerHealth.Health.IsDead)
				{
					StopGame();
				}
			}
		}

		private void StopGame()
		{
			_gameOverMenu?.SetActive(true);
			Time.timeScale = 0f;

			StopCoroutine(PlayerDeathCheckCycle());
		}
	}
}
