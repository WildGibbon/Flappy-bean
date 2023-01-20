using FlappyBean.Runtime.Model.Movement.Enemy;
using FlappyBean.Runtime.View.Movement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBean.Tests.TestsComponents
{
	public class NullDirectionalMovementView : IDirectionalMovementView
	{
		public void Visualize(IDirectionalMovement movement) { }
	}
}
