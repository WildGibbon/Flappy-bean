using FlappyBean.Runtime.Model.Health;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.View.Health
{
	public class HealthTransformView : MonoBehaviour, IHealthTransformView
	{
		public int Value => _health.Value;
		public int MaxValue => _health.MaxValue;
		public bool IsDead => _health.IsDead;

		private IHealth _health;
		public void Init(IHealth health)
		{
			_health = health ?? throw new ArgumentNullException("Health can not be null");
		}

		public void Heal(int value)
		{
			_health.Heal(value);
		}

		public void TakeDamage(int value)
		{
			_health.TakeDamage(value);
		}
	}
}
