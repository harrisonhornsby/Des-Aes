﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DES
{
	class DesCipher
	{
		public BitArray Left32Bits = new BitArray(32);
		public BitArray Right32Bits = new BitArray(32);
		public Plaintext PlaintextObject = new Plaintext();

		public static readonly int[] IpValues = 
			{
				58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,
				62,54,46,38,30,22,14,6,64,56,48,40,32,24,16,8,
				57,49,41,33,25,17,9,1,59,51,43,35,27,19,11,3,
				61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7
			};

		public void EncryptWithDes(string plaintext)
		{
			PlaintextObject.Value = plaintext;
		}

		public void SetLeft32Bits(BitArray messageAfterIp)
		{
			for (int i = 0; i < 32; i++)
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

		public static BitArray ApplyInitialPermutation(BitArray messageBeforeIp)
		{
			var messageAfterIp = new BitArray(messageBeforeIp.Count);
			for (int i = 0; i < messageBeforeIp.Count; i++)
			{
				//Console.Write("\nMessageBeforeIp bit at position: " + i + " is being swapped with bit at position: " + DesCipher.IpValues[i]);
				messageAfterIp[i] = messageBeforeIp[DesCipher.IpValues[i] - 1];
			}
			return messageAfterIp;
		}
	}
}
