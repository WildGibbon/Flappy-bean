using FlappyBean.Runtime.Model.Movement.Player.Jump;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Player
{
	[RequireComponent(typeof(Rigidbody2D))]
	public class PlayerJumpView : MonoBehaviour, IPlayerJumpView
	{
		private Rigidbody2D _rigidbody;

		private void Awake()
		{
			_rigidbody = GetComponent<Rigidbody2D>();
		}

		public void Visualize(IPlayerJump jump)
		{
			_rigidbody.velocity = Vector2.zero;
			_rigidbody.AddForce(jump.Direction);
		}
	}
}
