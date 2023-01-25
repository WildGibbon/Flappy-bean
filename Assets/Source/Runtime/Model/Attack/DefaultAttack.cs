using FlappyBean.Runtime.Model.Health;
using FlappyBean.Runtime.View.Health;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Attack
{
	public class DefaultAttack : IAttack
	{
		private readonly int _damage;

		public DefaultAttack(int damage)
		{
			if (damage < 0)
			{
				throw new ArgumentOutOfRangeException("Damage can not be less than 0");
			}

			_damage = damage;
		}

		public void Attack(IHealth health)
		{
		    health.TakeDamage(_damage);
		}
	}
}
