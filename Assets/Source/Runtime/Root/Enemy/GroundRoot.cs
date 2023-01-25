using FlappyBean.Runtime.Model.Attack;
using FlappyBean.Runtime.View.Attack;
using UnityEngine;

namespace FlappyBean.Runtime.Root.Enemy
{
	[RequireComponent(typeof(BoxCollider2D))]
	public class GroundRoot : CompositeRoot
	{
		[SerializeField] private int _damage;
		[SerializeField] private AttackTransformView _attackTransformView;

		public override void Compose()
		{
			_attackTransformView.Init(new DefaultAttack(_damage));
		}
	}
}
