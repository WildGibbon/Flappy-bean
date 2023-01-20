using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement
{
	public class DirectionalMovement : IDirectionalMovement, IUpdatable
	{
		public Vector2 CurrentPosition { get; private set; }

		private readonly DirectionalMovementData _data;
		private readonly IDirectionalMovementView _view;

		public DirectionalMovement(IDirectionalMovementView view, DirectionalMovementData data, Vector2 position)
		{
			CurrentPosition = position;
			_data = data;
			_view = view ?? throw new ArgumentNullException("View can not be null");
		}

		public void Update()
		{
			CurrentPosition += _data.Direction.normalized * _data.Speed * Time.deltaTime;
			_view.Visualize(this);
		}
	}
}
