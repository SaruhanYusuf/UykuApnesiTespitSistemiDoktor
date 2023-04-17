namespace UykuApnesiTespitSistemiDoktor
{
    partial class Login
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
            this.GirisYap = new System.Windows.Forms.Button();
            this.KayitOl = new System.Windows.Forms.Button();
            this.MailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // GirisYap
            // 
            this.GirisYap.Location = new System.Drawing.Point(288, 263);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(240, 56);
            this.GirisYap.TabIndex = 0;
            this.GirisYap.Text = "Giris Yap";
            this.GirisYap.UseVisualStyleBackColor = true;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // KayitOl
            // 
            this.KayitOl.Location = new System.Drawing.Point(288, 362);
            this.KayitOl.Name = "KayitOl";
            this.KayitOl.Size = new System.Drawing.Size(240, 23);
            this.KayitOl.TabIndex = 1;
            this.KayitOl.Text = "Hala Kayıt Olmadınız Mı?";
            this.KayitOl.UseVisualStyleBackColor = true;
            this.KayitOl.Click += new System.EventHandler(this.KayitOl_Click);
            // 
            // MailBox
            // 
            this.MailBox.Location = new System.Drawing.Point(288, 71);
            this.MailBox.Name = "MailBox";
            this.MailBox.Size = new System.Drawing.Size(240, 23);
            this.MailBox.TabIndex = 2;
            this.MailBox.TextChanged += new System.EventHandler(this.MailBox_TextChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(288, 135);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(240, 23);
            this.PasswordBox.TabIndex = 3;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.MailBox);
            this.Controls.Add(this.KayitOl);
            this.Controls.Add(this.GirisYap);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GirisYap;
        private Button KayitOl;
        private TextBox MailBox;
        private TextBox PasswordBox;
    }
}