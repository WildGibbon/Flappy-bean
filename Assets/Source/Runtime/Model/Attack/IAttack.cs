using UnityEngine;

namespace FlappyBean.Runtime.Model.Attack
{
	public interface IAttack
	{
		void Collide(Collider2D collider);
	}
}
