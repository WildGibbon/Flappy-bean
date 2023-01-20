using UnityEngine;

namespace FlappyBean.Runtime.Model.Input
{
	public class Input : MonoBehaviour, IInput
	{
		public bool IsJumpKeyPressed => UnityEngine.Input.GetKeyDown(KeyCode.Mouse0);
	}
}
