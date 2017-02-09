using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

		DesCipher desCipher = new DesCipher();
		AesCipher aesCipher = new AesCipher();

		public enum Cipher
		{
			Des,
			Aes
		};

		public MainForm()
		{
			InitializeComponent();
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
					desCipher.EncryptWithDes(Plaintext);
					break;
			}
		}

		private void SetCipherChoice()
		{
			ChosenCipherString = (groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
			ChosenCipher = ChosenCipherString == "AES" ? Cipher.Aes : Cipher.Des;
		}
		
	}
}
