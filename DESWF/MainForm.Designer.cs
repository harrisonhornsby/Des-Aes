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
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
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
			this.groupBox2.Location = new System.Drawing.Point(20, 114);
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
			this.groupBox3.Location = new System.Drawing.Point(20, 353);
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
			this.label4.Location = new System.Drawing.Point(188, 584);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(242, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "ECE419 - Harrison Hornsby - © 2017";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 609);
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
	}
}

