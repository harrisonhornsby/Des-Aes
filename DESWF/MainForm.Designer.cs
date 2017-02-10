using System;
using System.Linq;
using System.Windows.Forms;

namespace DESWF
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbPlaintext = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.rbSelectAes = new System.Windows.Forms.RadioButton();
			this.rbSelectDes = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbCiphertext = new System.Windows.Forms.TextBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.rb56BitKey = new System.Windows.Forms.RadioButton();
			this.tbKey = new System.Windows.Forms.TextBox();
			this.btnGenerateKey = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbPlaintext
			// 
			this.tbPlaintext.Location = new System.Drawing.Point(17, 43);
			this.tbPlaintext.Multiline = true;
			this.tbPlaintext.Name = "tbPlaintext";
			this.tbPlaintext.Size = new System.Drawing.Size(540, 98);
			this.tbPlaintext.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(222, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 22);
			this.label1.TabIndex = 1;
			this.label1.Text = "Plaintext";
			// 
			// rbSelectAes
			// 
			this.rbSelectAes.AutoSize = true;
			this.rbSelectAes.Location = new System.Drawing.Point(112, 46);
			this.rbSelectAes.Name = "rbSelectAes";
			this.rbSelectAes.Size = new System.Drawing.Size(56, 21);
			this.rbSelectAes.TabIndex = 3;
			this.rbSelectAes.TabStop = true;
			this.rbSelectAes.Text = "AES";
			this.rbSelectAes.UseVisualStyleBackColor = true;
			// 
			// rbSelectDes
			// 
			this.rbSelectDes.AutoSize = true;
			this.rbSelectDes.Location = new System.Drawing.Point(32, 46);
			this.rbSelectDes.Name = "rbSelectDes";
			this.rbSelectDes.Size = new System.Drawing.Size(57, 21);
			this.rbSelectDes.TabIndex = 2;
			this.rbSelectDes.TabStop = true;
			this.rbSelectDes.Text = "DES";
			this.rbSelectDes.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(60, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Cipher";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEncrypt.Location = new System.Drawing.Point(200, 148);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(174, 51);
			this.btnEncrypt.TabIndex = 7;
			this.btnEncrypt.Text = "Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.rbSelectAes);
			this.groupBox1.Controls.Add(this.rbSelectDes);
			this.groupBox1.Location = new System.Drawing.Point(206, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(202, 74);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.tbPlaintext);
			this.groupBox2.Controls.Add(this.btnEncrypt);
			this.groupBox2.Location = new System.Drawing.Point(20, 242);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(575, 220);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.tbCiphertext);
			this.groupBox3.Controls.Add(this.btnDecrypt);
			this.groupBox3.Location = new System.Drawing.Point(20, 481);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(575, 224);
			this.groupBox3.TabIndex = 11;
			this.groupBox3.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(210, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 22);
			this.label3.TabIndex = 1;
			this.label3.Text = "Cipher Text:";
			// 
			// tbCiphertext
			// 
			this.tbCiphertext.Location = new System.Drawing.Point(17, 43);
			this.tbCiphertext.Multiline = true;
			this.tbCiphertext.Name = "tbCiphertext";
			this.tbCiphertext.Size = new System.Drawing.Size(540, 98);
			this.tbCiphertext.TabIndex = 0;
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDecrypt.Location = new System.Drawing.Point(200, 148);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(174, 51);
			this.btnDecrypt.TabIndex = 7;
			this.btnDecrypt.Text = "Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(188, 712);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "ECE419 - Harrison Hornsby - © 2017";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.rb56BitKey);
			this.groupBox4.Controls.Add(this.tbKey);
			this.groupBox4.Controls.Add(this.btnGenerateKey);
			this.groupBox4.Location = new System.Drawing.Point(20, 100);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(575, 132);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			// 
			// rb56BitKey
			// 
			this.rb56BitKey.AutoSize = true;
			this.rb56BitKey.Location = new System.Drawing.Point(198, 36);
			this.rb56BitKey.Name = "rb56BitKey";
			this.rb56BitKey.Size = new System.Drawing.Size(45, 21);
			this.rb56BitKey.TabIndex = 5;
			this.rb56BitKey.TabStop = true;
			this.rb56BitKey.Text = "56";
			this.rb56BitKey.UseVisualStyleBackColor = true;
			this.rb56BitKey.Checked = true;
			// 
			// tbKey
			// 
			this.tbKey.Location = new System.Drawing.Point(17, 76);
			this.tbKey.Multiline = true;
			this.tbKey.Name = "tbKey";
			this.tbKey.Size = new System.Drawing.Size(540, 40);
			this.tbKey.TabIndex = 0;
			// 
			// btnGenerateKey
			// 
			this.btnGenerateKey.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenerateKey.Location = new System.Drawing.Point(16, 28);
			this.btnGenerateKey.Name = "btnGenerateKey";
			this.btnGenerateKey.Size = new System.Drawing.Size(174, 40);
			this.btnGenerateKey.TabIndex = 7;
			this.btnGenerateKey.Text = "Generate Key";
			this.btnGenerateKey.UseVisualStyleBackColor = true;
			this.btnGenerateKey.Click += new System.EventHandler(this.btnGenerateKey_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 736);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "Harrison Hornsby - DES Cipher";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		
		#endregion

		private System.Windows.Forms.TextBox tbPlaintext;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbSelectAes;
		private System.Windows.Forms.RadioButton rbSelectDes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCiphertext;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Label label4;
		private GroupBox groupBox4;
		private RadioButton rb56BitKey;
		private TextBox tbKey;
		private Button btnGenerateKey;
	}
}

