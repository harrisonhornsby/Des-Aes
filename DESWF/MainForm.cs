using MlkPwgen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DESWF
{
	public partial class MainForm : Form
	{
		public BitArray Plaintext;
		public string CiphertextString;
		public string ChosenCipherString;
		public Cipher ChosenCipher;
		public BitArray Key;

		private AesCipher aesCipher = new AesCipher();

		public enum Cipher
		{
			Des,
			Aes
		};

		public BitArray ConvertToBitArray(byte[] input)
		{
			return new BitArray(input);
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnGenerateKey_Click(object sender, EventArgs e)
		{
			var selectedKey = (groupBox4.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);

			var key = PasswordGenerator.Generate(length: 8, allowed: Sets.Alphanumerics);

			BitArray temp = new BitArray(Encoding.UTF8.GetBytes(key));
			Key = temp;
			tbKey.Text = DesCipher.ConvertBitArrayToString(Key); //BitConverter.ToString(ba).Replace("-", string.Empty);
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			SetCipherChoice();
			Plaintext = DesCipher.ConvertStringToBitArray(tbPlaintext.Text);

			switch (ChosenCipher)
			{
				case Cipher.Aes:
					AesCipher aesCipher = new AesCipher();
					//aesCipher.EncryptWithAes(Plaintext);
					break;

				case Cipher.Des:
					DesCipher desCipher = new DesCipher();
					desCipher.EncryptWithDes(Plaintext, true, Key);
					tbCiphertext.Text = desCipher.CipherTextString;
					break;
			}

			//Call next method here
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			SetCipherChoice();
			Plaintext = DesCipher.ConvertStringToBitArray(tbCiphertext.Text);

			switch (ChosenCipher)
			{
				case Cipher.Aes:
					AesCipher aesCipher = new AesCipher();
					//aesCipher.EncryptWithAes(Plaintext);
					break;

				case Cipher.Des:
					DesCipher desCipher = new DesCipher();
					desCipher.EncryptWithDes(Plaintext, false, Key);
					tbPlaintext.Text = desCipher.CipherTextString;
					break;
			}
		}
		private void btnBinaryToText_Click(object sender, EventArgs e)
		{
			var binary = tbBinary.Text;
			tbText.Text = BinaryToString(binary);
		}
		private void btnTextToBinary_Click(object sender, EventArgs e)
		{
			var text = tbText.Text;
			tbBinary.Text = StringToBinary(text);
		}

		private void SetCipherChoice()
		{
			ChosenCipherString = (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
			ChosenCipher = ChosenCipherString == "AES" ? Cipher.Aes : Cipher.Des;
		}

		public static string StringToBinary(string data)
		{
			StringBuilder sb = new StringBuilder();

			foreach (char c in data.ToCharArray())
			{
				sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
			}
			return sb.ToString();
		}

		public static string BinaryToString(string data)
		{
			List<Byte> byteList = new List<Byte>();

			for (int i = 0; i < data.Length; i += 8)
			{
				byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
			}
			return Encoding.ASCII.GetString(byteList.ToArray());
		}
	}
}