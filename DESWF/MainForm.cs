using MlkPwgen;
using System;
using System.Collections;
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
			tbKey.Text = ConversionService.BitArrayToString(Key);
		}

		private void btnEncrypt_Click(object sender, EventArgs e)
		{
			SetCipherChoice();
			Plaintext = ConversionService.StringToBitArray(tbPlaintext.Text);

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
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			SetCipherChoice();
			Plaintext = ConversionService.StringToBitArray(tbCiphertext.Text);

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
			tbText.Text = ConversionService.BinaryStringToText(binary);
		}

		private void btnTextToBinary_Click(object sender, EventArgs e)
		{
			var text = tbText.Text;
			tbBinary.Text = ConversionService.TextToBinaryString(text);
		}

		private void SetCipherChoice()
		{
			ChosenCipherString = (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
			ChosenCipher = ChosenCipherString == "AES" ? Cipher.Aes : Cipher.Des;
		}
	}
}