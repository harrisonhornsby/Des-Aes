using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DES;

namespace DESWF
{
	public partial class MainForm : Form
	{
		public string Plaintext;
		public string CiphertextString;
		public string ChosenCipherString;
		public Cipher ChosenCipher;
		public BitArray Key;

		DesCipher desCipher = new DesCipher();
		AesCipher aesCipher = new AesCipher();

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
			var numGen = RandomNumberGenerator.Create();
			var size = Int32.Parse(selectedKey);
			Byte[] ba = new byte[size/8];
			numGen.GetBytes(ba);
			Key = ConvertToBitArray(ba);
			tbKey.Text = BitConverter.ToString(ba).Replace("-", string.Empty);
			
		}
		
		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			SetCipherChoice();
			Plaintext = tbPlaintext.Text;
			CiphertextString = Plaintext;

			switch (ChosenCipher)
			{
					case Cipher.Aes:
					aesCipher.EncryptWithAes(Plaintext);
					break;

					case Cipher.Des:
					desCipher.EncryptWithDes(Plaintext, Key);
					break;
			}

			//Call next method here
		}
		
		private void SetCipherChoice()
		{
			ChosenCipherString = (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
			ChosenCipher = ChosenCipherString == "AES" ? Cipher.Aes : Cipher.Des;
		}
		
	}
}
