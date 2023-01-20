using FlappyBean.Runtime.Model.Movement.Player.Rotation;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Player.Rotation
{
	public class PlayerRotationView : MonoBehaviour, IPlayerRotationView
	{
		public void Visualize(IPlayerRotation rotation)
		{
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotation.Value));
		}
	}
}
