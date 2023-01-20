using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Player;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player.Jump
{
	public class PlayerJump : IPlayerJump, IUpdatable
	{
		private readonly IPlayerJumpView _view;
		private readonly IInput _jumpInput;

		public Vector2 Direction { get; }

		public PlayerJump(IPlayerJumpView view, IInput jumpInput, Vector2 jumpDirection)
		{
			_view = view ?? throw new ArgumentNullException("View cannot be null");
			_jumpInput = jumpInput ?? throw new ArgumentNullException("Input cannot be null");
			Direction = jumpDirection;
		}

		public void Update()
		{
			if (_jumpInput.IsJumpKeyPressed)
			{
				_view.Visualize(this);
			}
		}
	}
}
