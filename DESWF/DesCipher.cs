///
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DESWF;

namespace DES
{
	class DesCipher
	{
		
		public BitArray Left32Bits = new BitArray(32);
		public BitArray Right32Bits = new BitArray(32);
		public Plaintext Message = new Plaintext();
		public BitArray MessageAfterInitialPermutation = new BitArray(64);
		
		public static readonly int[] IpValues = 
			{
				58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,
				62,54,46,38,30,22,14,6,64,56,48,40,32,24,16,8,
				57,49,41,33,25,17,9,1,59,51,43,35,27,19,11,3,
				61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7
			};

		private List<BitArray> _listOfBitBlocks;

		/// <summary>
		/// Method creates a byte[] from plaintext string.
		/// Extracts 64 bits at a time until Message.Value is totally encrypted.
		/// Will set cipher text.
		/// </summary>
		/// <param name="plaintext"></param>
		public void EncryptWithDes(string plaintext)
		{
			Message.Value = plaintext;
			Message.EncodedByteArray = Encoding.ASCII.GetBytes(Message.Value);
			Message.EncodedBitArray = ConvertToBitArray(Message.EncodedByteArray);//Message.Encoded bit array stores all bits from plain text conversion
			ConvertEncodedBitArrayToListOfBitBlocks();

			foreach (var block in _listOfBitBlocks)
			{
				//encrypt and append
			}
		}

		private void ConvertEncodedBitArrayToListOfBitBlocks()
		{
			_listOfBitBlocks = new List<BitArray>();
			_listOfBitBlocks.Capacity = (Message.EncodedBitArray.Length % 64 != 0)
				? (Message.EncodedBitArray.Count / 64) + 1
				: Message.EncodedBitArray.Count / 64;
			for (int i = 0; i < _listOfBitBlocks.Capacity; i++)
			{
				var temp = new BitArray(64);
				for (int j = i * 64, k = 0; j < (i * 64) + 64 && j < Message.EncodedBitArray.Count; j++, k++)
				{
					temp[k] = Message.EncodedBitArray[j];
				}
				_listOfBitBlocks.Add(temp);
			}
		}

		public void DecryptWithDes()
		{
			//TODO: Pass in cipher text, update a plaintext property, display plaintext in text area of win form
		}

		public void SetLeft32Bits(BitArray messageAfterIp)
		{
			for (var i = 0; i < 32; i++)
			{
				Left32Bits[i] = messageAfterIp[i];
			}
		}
		
	public void SetRight32Bits(BitArray messageAfterIp)
		{
			for (int i = 0, j = 32; i < 32 && j < 64; i++,j++)
			{
				Right32Bits[i] = messageAfterIp[j];
			}
		}

		public static void PrintBitArray(BitArray bitArray)
		{
			var count = 0;
			foreach (var bit in bitArray)
			{
				Console.Write(bit.Equals(true) ? 1 : 0);
				count++;
				if (count == 8)
				{
					Console.Write("  ");
					count = 0;
				}

			}
		}

		/// <summary>
		/// Accepts 8 bytes and converts to a bit array of 64 bits.
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		public BitArray ConvertToBitArray(byte[] input)
		{
			return new BitArray(input);
		}

		public static BitArray ApplyInitialPermutation(BitArray messageBeforeIp)
		{
			var messageAfterIp = new BitArray(messageBeforeIp.Count);
			for (var i = 0; i < messageBeforeIp.Count; i++)
			{
				messageAfterIp[i] = messageBeforeIp[DesCipher.IpValues[i] - 1];
			}
			return messageAfterIp;
		}
	}
}
