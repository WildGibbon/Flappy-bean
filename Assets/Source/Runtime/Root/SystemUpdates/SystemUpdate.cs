using System.Collections.Generic;

namespace FlappyBean.Runtime.Root.SystemUpdates
{
	public class SystemUpdate : ISystemUpdate
	{
		private readonly List<IUpdatable> _updatables;

		public SystemUpdate()
		{
			_updatables = new List<IUpdatable>();
		}

		public void Add(params IUpdatable[] updatables)
		{
			_updatables.AddRange(updatables);
		}

		public void UpdateAll()
		{
			_updatables.ForEach(updatable => updatable.Update());
		}
	}
}
