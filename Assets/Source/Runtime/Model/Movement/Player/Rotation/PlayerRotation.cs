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

		private readonly IInput _input;
		private readonly PlayerRotationData _data;
		private readonly IPlayerRotationView _view;

		public PlayerRotation(IInput input, IPlayerRotationView view, PlayerRotationData data)
		{
			_data = data;
			Value = data.MaxValue;
			_input = input ?? throw new ArgumentNullException("Input can not be null");
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Update()
		{
			if (_input.IsJumpKeyPressed)
			{
				Value = _data.MaxValue;
			}

			Value = Mathf.Lerp(Value, _data.MinValue, _data.Speed * Time.deltaTime);

			_view.Visualize(this);
		}
	}
}
