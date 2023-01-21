using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Player;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player.Jump
{
	public class PlayerJump : IPlayerJump
	{
		private readonly IPlayerJumpView _view;

		public Vector2 Direction { get; }

		public PlayerJump(IPlayerJumpView view, Vector2 jumpDirection)
		{
			_view = view ?? throw new ArgumentNullException("View cannot be null");
			Direction = jumpDirection;
		}

		public void Jump()
		{
			_view.Visualize(this);
		}
	}
}
