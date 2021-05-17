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
            this.plainText.Location = new System.Drawing.Point(40, 129);
            this.plainText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(167, 26);
            this.plainText.TabIndex = 1;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(40, 192);
            this.Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Key.MaxLength = 10;
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(167, 26);
            this.Key.TabIndex = 2;
            this.Key.TextChanged += new System.EventHandler(this.Key_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plain text";
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(669, 162);
            this.cipherText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(167, 26);
            this.cipherText.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cipher text";
            // 
            // cipherText2
            // 
            this.cipherText2.Location = new System.Drawing.Point(669, 364);
            this.cipherText2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cipherText2.Name = "cipherText2";
            this.cipherText2.Size = new System.Drawing.Size(167, 26);
            this.cipherText2.TabIndex = 7;
            // 
            // plainText2
            // 
            this.plainText2.Location = new System.Drawing.Point(40, 364);
            this.plainText2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.plainText2.Name = "plainText2";
            this.plainText2.Size = new System.Drawing.Size(167, 26);
            this.plainText2.TabIndex = 8;
            // 
            // decryptBtn
            // 
            this.decryptBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decryptBtn.Location = new System.Drawing.Point(349, 344);
            this.decryptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(168, 68);
            this.decryptBtn.TabIndex = 9;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = false;
            this.decryptBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(666, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cipher text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Plain text";
            // 
            // encryptBtn
            // 
            this.encryptBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.encryptBtn.Location = new System.Drawing.Point(349, 162);
            this.encryptBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(168, 68);
            this.encryptBtn.TabIndex = 12;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = false;
            this.encryptBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // generateKey
            // 
            this.generateKey.Location = new System.Drawing.Point(73, 241);
            this.generateKey.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.generateKey.Name = "generateKey";
            this.generateKey.Size = new System.Drawing.Size(111, 52);
            this.generateKey.TabIndex = 13;
            this.generateKey.Text = "Generate Key";
            this.generateKey.UseVisualStyleBackColor = true;
            this.generateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(931, 589);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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

