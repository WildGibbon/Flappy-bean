namespace FlappyBean.Runtime.Root.SystemUpdates
{
	public interface ISystemUpdate
	{
		void Add(params IUpdatable[] updatables);
		void UpdateAll();
	}
}
