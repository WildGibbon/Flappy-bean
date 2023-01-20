using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlappyBean.Runtime.Model.Wallet
{
	public interface IWallet
	{
		int Value { get; }
		void Deposit(int value);
	    void WriteOff(int value);
	}
}
