using FlappyBean.Runtime.Model.Input;
using FlappyBean.Runtime.Root.SystemUpdates;
using FlappyBean.Runtime.View.Movement.Character;
using System;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Movement.Character.Jump
{
	public class CharacterJump : ICharacterJump
	{
		private readonly ICharacterJumpView _view;

		public Vector2 Direction { get; }

		public CharacterJump(ICharacterJumpView view, Vector2 jumpDirection)
		{
			_view = view ?? throw new ArgumentNullException("View cannot be null");
			Direction = jumpDirection;
		}

		public void Jump()
		{
			_view.Visualize(Direction);
		}
	}
}
