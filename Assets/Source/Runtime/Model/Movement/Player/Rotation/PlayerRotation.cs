using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Player.Rotation;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public class PlayerRotation : IPlayerRotation, IUpdatable
	{
		public float Value { get; private set; }

		private readonly float _maxValue;
		private readonly float _minValue;
		private readonly float _speed;

		private readonly IInput _input;
		private readonly IPlayerRotationView _view;

		public PlayerRotation(IInput input, IPlayerRotationView view, PlayerRotationData data)
		{
			Value = data.MaxValue;
			_maxValue = data.MaxValue;
			_minValue = data.MinValue;
			_speed = data.Speed;

			_input = input ?? throw new ArgumentNullException("Input can not be null");
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Update()
		{
			if (_input.IsJumpKeyPressed)
			{
				Value = _maxValue;
			}

			Value = Mathf.Lerp(Value, _minValue, _speed * Time.deltaTime);

			_view.Visualize(this);
		}
	}
}
