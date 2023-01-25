﻿using FlappyBean.Runtime.Root.Character;
using FlappyBean.Runtime.View.Score;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Score.Area
{
	public class ScoreIncreaseArea : MonoBehaviour
	{
		[SerializeField, Range(1, 1000)] private int _increaseValue;

		private IScore _score;

		public void Init(IScore score)
		{
			_score = score ?? throw new ArgumentNullException("Score can not be null");
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.TryGetComponent<CharacterRoot>(out CharacterRoot character))
			{
				_score.Increase(_increaseValue);
			}
		}
	}
}
