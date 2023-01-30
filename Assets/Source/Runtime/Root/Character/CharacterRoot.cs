using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Model.Movement.Character.Rotation;
using FlappyBean.Runtime.Model.Movement.Character.Jump;
using FlappyBean.Runtime.Model.Score;
using FlappyBean.Runtime.View.Health;
using FlappyBean.Runtime.View.Movement.Character;
using FlappyBean.Runtime.View.Movement.Character.Rotation;
using FlappyBean.Runtime.View.Score;
using FlappyBean.Runtime.Root.SystemUpdates;
using UnityEngine;
using FlappyBean.Runtime.Model.Player;
using FlappyBean.Runtime.Model.Character;

namespace FlappyBean.Runtime.Root.Character
{
	[RequireComponent(typeof(Collider2D))]
	public class CharacterRoot : CompositeRoot
	{
		[SerializeField] private int _healthValue;
		[SerializeField] private IHealthTransformView _healthTransformView;
		[Space]
		[SerializeField] private Vector2 _jumpDirection;
		[SerializeField] private ICharacterJumpView _jumpView;
		[Space]
		[SerializeField] private int _maxRotation;
		[SerializeField] private int _minRotation;
		[SerializeField] private int _rotationSpeed;
		[SerializeField] private ICharacterRotationView _rotationView;
		[Space]
		[SerializeField] private int _scoreValue;
		[SerializeField] private IScoreView _scoreView;
		[Space]
		[SerializeField] private IJumpInput _input;
		[Space]
		[SerializeField] private ICharacter _character;

		private ISystemUpdate _systemUpdate;

		public IScore Score { get; private set; }

		public override void Compose()
		{
			_systemUpdate = new SystemUpdate();

			_healthTransformView.Init(new Model.Health.Health(_healthValue));

			var score = new Score(_scoreValue, _scoreView);
			_character.Init(score);

			var jump = new CharacterJump(_jumpView, _jumpDirection);
			var rotationData = new CharacterRotationData(_maxRotation, _minRotation, _rotationSpeed);
			var rotation = new CharacterRotation(_rotationView, rotationData);

			var player = new Player(rotation, jump, _input);

			_systemUpdate.Add(player);
		}

		private void Update() => _systemUpdate?.UpdateAll();
	}
}
