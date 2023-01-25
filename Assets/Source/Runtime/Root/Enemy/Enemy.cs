using FlappyBean.Runtime.Model.Attack;
using FlappyBean.Runtime.Model.Movement.Enemy;
using FlappyBean.Runtime.Model.Score.Area;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Attack;
using FlappyBean.Runtime.View.Movement;
using UnityEngine;
using Sirenix.OdinInspector;
using FlappyBean.Runtime.Model.Score;

namespace FlappyBean.Runtime.Root.Enemy
{
	[RequireComponent(typeof(Collider2D))]
	public class Enemy : SerializedMonoBehaviour
	{
		[SerializeField] private float _movementSpeed;
		[SerializeField] private Vector2 _moveDirection;
		[SerializeField] private IDirectionalMovementView _movementView;
		[Space]
		[SerializeField] private int _damage;
		[SerializeField] private AttackTransformView _attackTransformView;
		[Space]
		[SerializeField] private ScoreIncreaseArea _scoreIncreaseArea;
		[SerializeField] private int _scoreUpValue;
	    
		private IScore _score;
		private ISystemUpdate _systemUpdate;

		public void Init(IScore score)
		{
			_score = score;
			_systemUpdate = new SystemUpdate();
			_scoreIncreaseArea.Init(_score);
			
			var movementData = new DirectionalMovementData(_movementSpeed, _moveDirection);
			var movement = new DirectionalMovement(_movementView, movementData, transform.position);

			_attackTransformView.Init(new DefaultAttack(_damage));
			_systemUpdate.Add(movement);
		}

		private void Update() => _systemUpdate.UpdateAll();
	}
}
