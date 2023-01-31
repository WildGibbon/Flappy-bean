using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace FlappyBean.Runtime.Root
{
	public class GameRestart : MonoBehaviour
	{
		[SerializeField] private Button _restartButton;

		private void Awake()
		{
			_restartButton.onClick.AddListener(OnRestartButtonClicked);
		}

		private void OnRestartButtonClicked()
		{
			Time.timeScale = 1;
			SceneManager.LoadScene(0);
		}
	}
}
