using FlappyBean.Runtime.Model.Health;
using UnityEngine;

namespace FlappyBean.Runtime.Model.Attack
{
	public interface IAttack
	{
		void Attack(IHealth health);
	}
}
