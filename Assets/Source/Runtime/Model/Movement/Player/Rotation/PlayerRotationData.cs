namespace FlappyBean.Runtime.Model.Movement.Player.Rotation
{
	public struct PlayerRotationData
	{
		public readonly float MaxValue;
		public readonly float MinValue;
		public readonly float Speed;

		public PlayerRotationData(float maxValue, float minValue, float Speed)
		{
			MaxValue = maxValue;
			MinValue = minValue;
			this.Speed = Speed;
		}
	}
}
