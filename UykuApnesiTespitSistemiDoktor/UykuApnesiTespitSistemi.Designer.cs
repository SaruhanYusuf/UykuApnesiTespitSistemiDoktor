namespace UykuApnesiTespitSistemiDoktor
{
    partial class UykuApnesiTespitSistemi
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HastaAdıTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HastaSoyAdıTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.HastaYasi = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HastaEkleButton = new System.Windows.Forms.Button();
            this.HastaSilButton = new System.Windows.Forms.Button();
            this.HastaRaporListesiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(969, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(540, 402);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta Listesi";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 47);
            this.panel1.TabIndex = 3;
            // 
            // HastaAdıTextBox
            // 
            this.HastaAdıTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HastaAdıTextBox.Location = new System.Drawing.Point(597, 61);
            this.HastaAdıTextBox.Name = "HastaAdıTextBox";
            this.HastaAdıTextBox.Size = new System.Drawing.Size(245, 16);
            this.HastaAdıTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(597, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hastanın Adı";
            // 
            // HastaSoyAdıTextBox
            // 
            this.HastaSoyAdıTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HastaSoyAdıTextBox.Location = new System.Drawing.Point(597, 123);
            this.HastaSoyAdıTextBox.Name = "HastaSoyAdıTextBox";
            this.HastaSoyAdıTextBox.Size = new System.Drawing.Size(245, 16);
            this.HastaSoyAdıTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(597, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hastanın Soyadı";
            // 
            // HastaYasi
            // 
            this.HastaYasi.Location = new System.Drawing.Point(597, 185);
            this.HastaYasi.Name = "HastaYasi";
            this.HastaYasi.Size = new System.Drawing.Size(245, 23);
            this.HastaYasi.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(597, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hastanın Yaşı";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox1.Location = new System.Drawing.Point(51, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(57, 21);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Erkek";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBox2.Location = new System.Drawing.Point(159, 17);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 21);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Kadın";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(597, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Hastanın Cinsiyeti";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Location = new System.Drawing.Point(539, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(467, 56);
            this.panel2.TabIndex = 13;
            // 
            // HastaEkleButton
            // 
            this.HastaEkleButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaEkleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaEkleButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HastaEkleButton.ForeColor = System.Drawing.Color.White;
            this.HastaEkleButton.Location = new System.Drawing.Point(798, 310);
            this.HastaEkleButton.Name = "HastaEkleButton";
            this.HastaEkleButton.Size = new System.Drawing.Size(168, 53);
            this.HastaEkleButton.TabIndex = 14;
            this.HastaEkleButton.Text = "Yeni Hastayı Ekle";
            this.HastaEkleButton.UseVisualStyleBackColor = false;
            // 
            // HastaSilButton
            // 
            this.HastaSilButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaSilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaSilButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HastaSilButton.ForeColor = System.Drawing.Color.White;
            this.HastaSilButton.Location = new System.Drawing.Point(568, 310);
            this.HastaSilButton.Name = "HastaSilButton";
            this.HastaSilButton.Size = new System.Drawing.Size(169, 53);
            this.HastaSilButton.TabIndex = 15;
            this.HastaSilButton.Text = "Mevcut Hastayı Sil";
            this.HastaSilButton.UseVisualStyleBackColor = false;
            // 
            // HastaRaporListesiButton
            // 
            this.HastaRaporListesiButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.HastaRaporListesiButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HastaRaporListesiButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HastaRaporListesiButton.ForeColor = System.Drawing.Color.White;
            this.HastaRaporListesiButton.Location = new System.Drawing.Point(684, 385);
            this.HastaRaporListesiButton.Name = "HastaRaporListesiButton";
            this.HastaRaporListesiButton.Size = new System.Drawing.Size(168, 53);
            this.HastaRaporListesiButton.TabIndex = 16;
            this.HastaRaporListesiButton.Text = "Hasta Raporu Göster";
            this.HastaRaporListesiButton.UseVisualStyleBackColor = false;
            // 
            // UykuApnesiTespitSistemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.ControlBox = false;
            this.Controls.Add(this.HastaRaporListesiButton);
            this.Controls.Add(this.HastaSilButton);
            this.Controls.Add(this.HastaEkleButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HastaYasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HastaSoyAdıTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastaAdıTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UykuApnesiTespitSistemi";
            this.Text = "UykuApnesiTespitSistemi";
            this.Load += new System.EventHandler(this.UykuApnesiTespitSistemi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Label label1;
        private Panel panel1;
        private TextBox HastaAdıTextBox;
        private Label label2;
        private TextBox HastaSoyAdıTextBox;
        private Label label3;
        private DateTimePicker HastaYasi;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label5;
        private Panel panel2;
        private Button HastaEkleButton;
        private Button HastaSilButton;
        private Button HastaRaporListesiButton;
    }
}