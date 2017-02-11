///
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DES
{
	internal class DesCipher
	{
		public static readonly int[] IpValues =
			{
				58,50,42,34,26,18,10,2,60,52,44,36,28,20,12,4,
				62,54,46,38,30,22,14,6,64,56,48,40,32,24,16,8,
				57,49,41,33,25,17,9,1,59,51,43,35,27,19,11,3,
				61,53,45,37,29,21,13,5,63,55,47,39,31,23,15,7
			};

		public static readonly int[] ExpansionValues =
		{
			32,1,2,3,4,5,4,5,6,7,8,9,8,9,10,11,12,13,12,13,14,15,16,17,16,17,18,19,20,21,20,21,22,23,24,25,24,25,26,27,28,29,28,29,30,31,32,1 //32nd moves to [0], 1st moves to[1] etc
		};

		public static readonly int[] NumberBitsShiftPerRound =
		{
			1, 1, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1
		};

		public BitArray Left32Bits = new BitArray(32);
		public Plaintext Message = new Plaintext();
		public BitArray MessageAfterInitialPermutation = new BitArray(64);
		public BitArray Right32Bits = new BitArray(32);
		private List<BitArray> _listOfBitBlocks;
		private BitArray _originalKey;
		private List<BitArray> _roundKeyList;

		public static BitArray ApplyInitialPermutation(BitArray messageBeforeIp)
		{
			var messageAfterIp = new BitArray(messageBeforeIp.Count);
			for (var i = 0; i < messageBeforeIp.Count; i++)
			{
				messageAfterIp[i] = messageBeforeIp[IpValues[i] - 1];
			}
			return messageAfterIp;
		}

		public List<BitArray> GetRoundKeyList()
		{
			//Drop parity bits then use that result in the below for loop, key should be 56 bits when entering for loop
			//_shortenedKey = DropParityBits(_originalKey);
			for (int i = 0; i < 16; i++)
			{
				//Bit shift the shortened key from before loop entry
				//_roundKeyList[i] = ShiftBits(NumberBitsShiftPerRound[i], _originalKey);
			}
			return new List<BitArray>();
		}

		/// <summary>
		/// Pass in the number of bits to shift as well as the original key. Original key is bit shifted to generate a round key.
		/// </summary>
		/// <param name="shiftSize"></param>
		/// <param name="originalKey"></param>
		/// <returns></returns>
		public BitArray ShiftBits(int shiftSize, BitArray originalKey)
		{
			var arraySize = originalKey.Count;
			for (int i = 0; i < arraySize; i++)
			{
				if (i - shiftSize < 0)
				{
					originalKey[originalKey.Count-1] = originalKey[i];
				}
					else originalKey[i - shiftSize] = originalKey[i];
			}
			var newRoundKey = originalKey;
			return newRoundKey;
		}

		public static string GetStringBitArray(BitArray bitArray)
		{
			var count = 0;
			string output = "";
			foreach (var bit in bitArray)
			{
				output += bit.Equals(true) ? "1" : "0";
				count++;
				if (count == 8)
				{
					output += "  ";
					count = 0;
				}
			}
			return output;
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

		public void DecryptWithDes()
		{
			//TODO: Pass in cipher text, update a plaintext property, display plaintext in text area of win form
		}

		/// <summary>
		/// Method creates a byte[] from plaintext string.
		/// Extracts 64 bits at a time until Message.Value is totally encrypted.
		/// Will set cipher text.
		/// </summary>
		/// <param name="plaintext"></param>
		/// <param name="key"></param>
		public void EncryptWithDes(string plaintext, BitArray key)
		{
			_originalKey = key;
			Message.Value = plaintext;
			Message.EncodedByteArray = Encoding.ASCII.GetBytes(Message.Value);
			Message.EncodedBitArray = ConvertToBitArray(Message.EncodedByteArray);//Message.Encoded bit array stores all bits from plain text conversion
			ConvertEncodedBitArrayToListOfBitBlocks();

			//encrypt each 64 bit block and append cipher text result to ciphertext member
			//then finally call method from mainform.cs to display the ciphertext property
			foreach (var block in _listOfBitBlocks)
			{
				MessageAfterInitialPermutation = ApplyInitialPermutation(block);
				SetLeft32Bits(MessageAfterInitialPermutation);
				SetRight32Bits(MessageAfterInitialPermutation);

				for (int round = 0; round < 16; round++)
				{
					Left32Bits = Right32Bits;

					//Right, Expand 32->48 bits
					Right32Bits = GetRight32Expanded();

					//Build the round keys
					_roundKeyList = GetRoundKeyList();

					//XOR R(expanded) with Round key(ith iteration)
					Right32Bits.Xor(_roundKeyList[round]);


					//Break the 48 bits down to eight 6 bit blocks, b1 to b8
					//Run each 6 bit block through it's respective s box
					//result should be C1 to C8 which are 4 bit outputs from the s box permutations
					//apply final substitution permutation
					//result of this final permutation is the output of the function
					//This output is then XOR'd with Left32, result of this becomes new R
					//once new L and R are set loop back through with new 32 bits
				}
				//Once through the 16 rounds, then do final permutation^-1 which results in cipher text.
			}
		}

		private BitArray GetRight32Expanded()
		{
			BitArray right32Expanded = new BitArray(48);
			for (int i = 0; i < 48; i++)
			{
				right32Expanded[i] = Right32Bits[ExpansionValues[i]-1];
			}
			return right32Expanded;
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
			for (int i = 0, j = 32; i < 32 && j < 64; i++, j++)
			{
				Right32Bits[i] = messageAfterIp[j];
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
	}
}