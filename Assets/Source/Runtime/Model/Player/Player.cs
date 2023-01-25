using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Model.Movement.Character.Jump;
using FlappyBean.Runtime.Model.Movement.Character.Rotation;
using FlappyBean.Runtime.Root.SystemUpdates;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Player
{
	public class Player : IUpdatable
	{
		private readonly ICharacterRotation _rotation;
		private readonly ICharacterJump _jump;
		private readonly IJumpInput _input;

		public Player(ICharacterRotation rotation, ICharacterJump jump, IJumpInput input)
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
