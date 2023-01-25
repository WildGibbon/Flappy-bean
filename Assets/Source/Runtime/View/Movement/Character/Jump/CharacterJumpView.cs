using FlappyBean.Runtime.Model.Movement.Character.Jump;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Character
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class CharacterJumpView : MonoBehaviour, ICharacterJumpView
	{
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Visualize(Vector2 jumpDirection)
		{
			_rigidbody.velocity = Vector2.zero;
			_rigidbody.AddForce(jumpDirection);
		}
	}
}
