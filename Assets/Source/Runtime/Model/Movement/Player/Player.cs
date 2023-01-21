using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Model.Movement.Player.Jump;
using FlappyBean.Runtime.Model.Movement.Player.Rotation;
using FlappyBean.Runtime.Root.SystemUpdates;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Player
{
	public class Player : IUpdatable
	{
		private readonly IPlayerRotation _rotation;
		private readonly IPlayerJump _jump;
		private readonly IInput _input;

		public Player(IPlayerRotation rotation, IPlayerJump jump, IInput input)
		{
			_rotation = rotation ?? throw new ArgumentNullException("Rotaion can not be null");
			_jump = jump ?? throw new ArgumentNullException("Jump can not be null");
			_input = input ?? throw new ArgumentNullException("Input can not be null");
		}

		public void Update()
		{
			if (_input.IsJumpKeyPressed)
			{
				_rotation.Rotate();
				_jump.Jump();
			}

			_rotation.Update();
		}
	}
}
