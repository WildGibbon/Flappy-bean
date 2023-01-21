namespace FlappyBean.Runtime.Model.Wallet
{
	public interface IWallet
	{
		int Value { get; }
		void Deposit(int value);
	    void WriteOff(int value);
	}
}
