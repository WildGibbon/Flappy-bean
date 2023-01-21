using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Player.Rotation;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public class PlayerRotation : IPlayerRotation
	{
		public float Value { get; private set; }

		private readonly PlayerRotationData _data;
		private readonly IPlayerRotationView _view;

		public PlayerRotation(IPlayerRotationView view, PlayerRotationData data)
		{
			_data = data;
			Value = data.MaxValue;
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Rotate()
		{
			Value = _data.MaxValue;
		}

		public void Update()
		{
			Value = Mathf.Lerp(Value, _data.MinValue, _data.Speed * Time.deltaTime);
			_view.Visualize(this);
		}
	}
}
