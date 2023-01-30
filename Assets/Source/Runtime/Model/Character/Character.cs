using FlappyBean.Runtime.Model.Score;
using System;
using FlappyBean.Runtime.Model.Character;
using UnityEngine;

namespace FlappyBean.Runtime
{
	public class Character : MonoBehaviour, ICharacter
	{
		public IScore Score { get; private set; }

		public void Init(IScore score)
		{
			Score = score;
		}
	}
}