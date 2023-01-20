using FlappyBean.Runtime.Model.Movement;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement
{
	public class DirectionalMovementView : MonoBehaviour, IDirectionalMovementView
	{
		public void Visualize(IDirectionalMovement movement)
		{
			transform.position = movement.CurrentPosition;
		}
	}
}
