using FlappyBean.Runtime.Model.Movement.Character.Rotation;
using UnityEngine;

namespace FlappyBean.Runtime.View.Movement.Character.Rotation
{
	public class CharacterRotationView : MonoBehaviour, ICharacterRotationView
	{
		public void Visualize(float rotation)
		{
			transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotation));
		}
	}
}
