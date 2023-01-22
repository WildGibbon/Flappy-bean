using FlappyBean.Runtime.View.Health;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Attack
{
	public class Attack : IAttack
	{
		private readonly int _damage;

		public Attack(int damage)
		{
			if (damage < 0)
			{
				throw new ArgumentOutOfRangeException("Damage can not be less than 0");
			}

			_damage = damage;
		}

		public void Collide(Collider2D collider)
		{
			if (!collider.TryGetComponent<IHealthTransformView>(out IHealthTransformView view))
			{
				throw new ArgumentException("Collision dont have HealthTransformView component");
		    }

		    view.TakeDamage(_damage);
		}
	}
}
