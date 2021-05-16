namespace Gui
{
    partial class Form1
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
            this.plainText = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cipherText2 = new System.Windows.Forms.TextBox();
            this.plainText2 = new System.Windows.Forms.TextBox();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.generateKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(36, 103);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(149, 22);
            this.plainText.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(36, 154);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(149, 22);
            this.Key.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plain text";
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(595, 130);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(149, 22);
            this.cipherText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cipher text";
            // 
            // cipherText2
            // 
            this.cipherText2.Location = new System.Drawing.Point(595, 291);
            this.cipherText2.Name = "cipherText2";
            this.cipherText2.Size = new System.Drawing.Size(149, 22);
            this.cipherText2.TabIndex = 7;
            // 
            // plainText2
            // 
            this.plainText2.Location = new System.Drawing.Point(36, 291);
            this.plainText2.Name = "plainText2";
            this.plainText2.Size = new System.Drawing.Size(149, 22);
            this.plainText2.TabIndex = 8;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decryptBtn.Location = new System.Drawing.Point(310, 275);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(149, 54);
            this.decryptBtn.TabIndex = 9;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cipher text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Plain text";
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.encryptBtn.Location = new System.Drawing.Point(310, 130);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(149, 54);
            this.encryptBtn.TabIndex = 12;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // generateKey
            // 
            this.generateKey.Location = new System.Drawing.Point(65, 193);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(99, 42);
            this.generateKey.TabIndex = 13;
            this.generateKey.Text = "Generate Key";
            this.generateKey.UseVisualStyleBackColor = true;
            this.generateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(846, 471);
            this.Controls.Add(this.generateKey);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.plainText2);
            this.Controls.Add(this.cipherText2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.plainText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cipherText2;
        private System.Windows.Forms.TextBox plainText2;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button generateKey;
    }
}

