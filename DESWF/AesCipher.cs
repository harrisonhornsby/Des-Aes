using DES;

namespace DESWF
{
	internal class AesCipher
	{
		public Plaintext PlaintextObject = new Plaintext();

		public void EncryptWithAes(string plaintext)
		{
			PlaintextObject.Value = plaintext;
		}
	}
}