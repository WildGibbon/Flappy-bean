using FlappyBean.Runtime.Model.Movement.Enemy;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement
{
	public class DirectionalMovementView : MonoBehaviour, IDirectionalMovementView
	{
		public void Visualize(Vector2 position)
		{
			transform.position = position;
		}
	}
}
