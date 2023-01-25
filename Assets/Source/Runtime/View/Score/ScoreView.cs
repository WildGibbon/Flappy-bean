using FlappyBean.Runtime.Model.Score;
using UnityEngine;
using TMPro;

namespace FlappyBean.Runtime.View.Score
{
	public class ScoreView : MonoBehaviour, IScoreView
	{
		[SerializeField] private TMP_Text _label;

		public void Visualize(int score)
		{
			_label.text = score.ToString();
		}
	}
}
