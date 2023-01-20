using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement
{
	public class DirectionalMovement : IDirectionalMovement, IUpdatable
	{
		public Vector2 Position { get; private set; }

		private readonly float _speed;
		private readonly Vector2 _direction;
		private readonly IDirectionalMovementView _view;

		public DirectionalMovement(IDirectionalMovementView view, DirectionalMovementData data)
		{
			Position = data.Position;
			_speed = data.Speed;
			_direction = data.Direction;
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Update()
		{
			Position += _direction.normalized * _speed * Time.deltaTime;
			_view.Visualize(this);
		}
	}
}
