using FlappyBean.Runtime.Model.Attack;
using FlappyBean.Runtime.Model.Movement;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Attack;
using FlappyBean.Runtime.View.Movement;
using UnityEngine;

namespace FlappyBean.Runtime.Root.Enemy
{
	[RequireComponent(typeof(Collider2D))]
	public class EnemyRoot : CompositeRoot
	{
		[SerializeField] private float _movementSpeed;
		[SerializeField] private Vector2 _moveDirection;
		[SerializeField] private IDirectionalMovementView _movementView;
		[Space]
		[SerializeField] private int _damage;
		[SerializeField] private AttackTransformView _attackTransformView;

		private ISystemUpdate _systemUpdate;

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			var movementData = new DirectionalMovementData(_movementSpeed, _moveDirection);
			var movement = new DirectionalMovement(_movementView, movementData, transform.position);

			_attackTransformView.Init(new Attack(_damage));
			_systemUpdate.Add(movement);
		}

		private void Update() => _systemUpdate.UpdateAll();
	}
}
