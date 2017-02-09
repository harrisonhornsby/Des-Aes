using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DES;

namespace DESWF
{
	class AesCipher
	{
		public Plaintext PlaintextObject = new Plaintext();
		public void EncryptWithAes(string plaintext)
		{
			PlaintextObject.Value = plaintext;
		}
	}
}
