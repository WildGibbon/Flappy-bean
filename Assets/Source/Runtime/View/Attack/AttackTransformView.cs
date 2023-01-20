using FlappyBean.Runtime.Model.Attack;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.View.Attack
{
	public class AttackTransformView : MonoBehaviour
	{
		private IAttack _attack;

		public void Init(IAttack attack)
		{
			_attack = attack ?? throw new ArgumentNullException("Attack can not be null");
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			_attack.Collide(collision);
		}
	}
}
