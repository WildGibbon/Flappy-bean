using UnityEngine;

namespace FlappyBean.Runtime.Model.Input
{
	public class JumpInput : MonoBehaviour, IJumpInput
	{
		public bool IsJumpKeyPressed => UnityEngine.Input.GetKeyDown(KeyCode.Mouse0);
	}
}
