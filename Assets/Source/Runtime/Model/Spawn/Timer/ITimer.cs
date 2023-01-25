using FlappyBean.Runtime.Root.SystemUpdates;

namespace FlappyBean.Runtime.Model.Spawn.Timer
{
	public interface ITimer : IUpdatable
	{
		bool IsActive { get; }
	}
}
