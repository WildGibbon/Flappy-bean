using FlappyBean.Runtime.Model.Score.Interactions;
using UnityEngine;
using System;

namespace FlappyBean.Runtime.View.Score.Interactions
{
	[RequireComponent(typeof(BoxCollider2D))]
	public class ScoreInteractionTransformView : MonoBehaviour
	{
		private IScoreInteraction _scoreInteraction;

		public void Init(IScoreInteraction scoreInteraction)
		{
			_scoreInteraction = scoreInteraction ?? throw new ArgumentNullException("scoreInteraction can not be null");
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.TryGetComponent<IScoreTransformView>(out IScoreTransformView score))
			{
				_scoreInteraction.Interact(score);
			}
		}
	}
}
