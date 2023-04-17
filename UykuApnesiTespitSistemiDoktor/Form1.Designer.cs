namespace UykuApnesiTespitSistemiDoktor
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.KayitOl = new System.Windows.Forms.Button();
            this.UyeGirisButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MailBox
            // 
            this.MailBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MailBox.Location = new System.Drawing.Point(250, 81);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(315, 23);
            this.MailBox.TabIndex = 0;
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.PasswordBox.Location = new System.Drawing.Point(250, 181);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(315, 23);
            this.PasswordBox.TabIndex = 1;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // KayitOl
            // 
            this.KayitOl.Location = new System.Drawing.Point(292, 257);
            this.KayitOl.Name = "KayitOl";
            this.KayitOl.Size = new System.Drawing.Size(229, 83);
            this.KayitOl.TabIndex = 2;
            this.KayitOl.Text = "Kayıt Ol";
            this.KayitOl.UseVisualStyleBackColor = true;
            this.KayitOl.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // UyeGirisButton
            // 
            this.UyeGirisButton.Location = new System.Drawing.Point(292, 379);
            this.UyeGirisButton.Name = "UyeGirisButton";
            this.UyeGirisButton.Size = new System.Drawing.Size(229, 23);
            this.UyeGirisButton.TabIndex = 3;
            this.UyeGirisButton.Text = "Zaten Üye Misiniz?";
            this.UyeGirisButton.UseVisualStyleBackColor = true;
            this.UyeGirisButton.Click += new System.EventHandler(this.UyeGirisButton_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UyeGirisButton);
            this.Controls.Add(this.KayitOl);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.MailBox);
            this.Name = "Register";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox MailBox;
        private TextBox PasswordBox;
        private Button KayitOl;
        private Button UyeGirisButton;
    }
}