namespace FlappyBean.Runtime.Model.Score
{
	public interface IScore
	{
		int Value { get; }
		void Up(int value);
		void Down(int value);
		bool CanDown(int value);
	}
}
