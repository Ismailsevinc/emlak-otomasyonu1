namespace ödev2._0
{
    partial class YeniEvEkleme
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
            textBoxsatis = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            radioButtonsatilik = new RadioButton();
            radioButtonkiralik = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            numericUpDown1 = new NumericUpDown();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            textBoxkira = new TextBox();
            textBoxkiradepoz = new TextBox();
            textBox4 = new TextBox();
            label12 = new Label();
            label13 = new Label();
            textBox1 = new TextBox();
            numericUpDownalan = new NumericUpDown();
            label14 = new Label();
            numericUpDownkatnumarasi = new NumericUpDown();
            comboBoxturu = new ComboBox();
            textBoxemlaknumara = new TextBox();
            label15 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxsatis
            // 
            textBoxsatis.Location = new Point(183, 224);
            textBoxsatis.Name = "textBoxsatis";
            textBoxsatis.Size = new Size(125, 27);
            textBoxsatis.TabIndex = 0;
            textBoxsatis.TextChanged += textBoxsatis_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.Font = new Font("Segoe UI", 15F);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(435, 490);
            button1.Name = "button1";
            button1.Size = new Size(136, 81);
            button1.TabIndex = 1;
            button1.Text = "Ev Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(65, 173);
            label1.Name = "label1";
            label1.Size = new Size(117, 28);
            label1.TabIndex = 3;
            label1.Text = "Oda Sayısı=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gold;
            label2.Font = new Font("Segoe UI", 25F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(391, 23);
            label2.Name = "label2";
            label2.Size = new Size(297, 57);
            label2.TabIndex = 4;
            label2.Text = "Yeni Ev Ekleme";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(65, 119);
            label3.Name = "label3";
            label3.Size = new Size(192, 28);
            label3.TabIndex = 5;
            label3.Text = "Satılık mı Kiralık mı=";
            // 
            // radioButtonsatilik
            // 
            radioButtonsatilik.Font = new Font("Segoe UI", 13F);
            radioButtonsatilik.Location = new Point(263, 119);
            radioButtonsatilik.Name = "radioButtonsatilik";
            radioButtonsatilik.Size = new Size(101, 34);
            radioButtonsatilik.TabIndex = 6;
            radioButtonsatilik.TabStop = true;
            radioButtonsatilik.Text = "Satılık";
            radioButtonsatilik.UseVisualStyleBackColor = true;
            radioButtonsatilik.CheckedChanged += radioButtonsatilik_CheckedChanged;
            // 
            // radioButtonkiralik
            // 
            radioButtonkiralik.Font = new Font("Segoe UI", 13F);
            radioButtonkiralik.Location = new Point(358, 119);
            radioButtonkiralik.Name = "radioButtonkiralik";
            radioButtonkiralik.Size = new Size(93, 34);
            radioButtonkiralik.TabIndex = 7;
            radioButtonkiralik.TabStop = true;
            radioButtonkiralik.Text = "Kiralık";
            radioButtonkiralik.UseVisualStyleBackColor = true;
            radioButtonkiralik.CheckedChanged += radioButtonkiralik_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(572, 173);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 8;
            label4.Text = "İl=";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(65, 223);
            label5.Name = "label5";
            label5.Size = new Size(119, 28);
            label5.TabIndex = 9;
            label5.Text = "Satış Fiyatı=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(65, 274);
            label6.Name = "label6";
            label6.Size = new Size(112, 28);
            label6.TabIndex = 10;
            label6.Text = "Kira Fiyatı=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(14, 328);
            label7.Name = "label7";
            label7.Size = new Size(165, 28);
            label7.TabIndex = 11;
            label7.Text = "Kira Depozitosu=";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(498, 331);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 12;
            label8.Text = "Yapım Yılı=";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(183, 174);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(74, 27);
            numericUpDown1.TabIndex = 13;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(538, 384);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 14;
            label9.Text = "Türü=";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(614, 177);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 15;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(614, 227);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(119, 28);
            comboBox2.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(562, 227);
            label10.Name = "label10";
            label10.Size = new Size(55, 28);
            label10.TabIndex = 17;
            label10.Text = "İlçe=";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(490, 271);
            label11.Name = "label11";
            label11.Size = new Size(118, 28);
            label11.TabIndex = 18;
            label11.Text = "Açık Adres=";
            // 
            // textBoxkira
            // 
            textBoxkira.Location = new Point(183, 275);
            textBoxkira.Name = "textBoxkira";
            textBoxkira.Size = new Size(125, 27);
            textBoxkira.TabIndex = 19;
            // 
            // textBoxkiradepoz
            // 
            textBoxkiradepoz.Location = new Point(183, 332);
            textBoxkiradepoz.Name = "textBoxkiradepoz";
            textBoxkiradepoz.Size = new Size(125, 27);
            textBoxkiradepoz.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(614, 332);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(107, 383);
            label12.Name = "label12";
            label12.Size = new Size(70, 28);
            label12.TabIndex = 27;
            label12.Text = "Alanı=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(567, 119);
            label13.Name = "label13";
            label13.Size = new Size(166, 28);
            label13.TabIndex = 28;
            label13.Text = "Emlak Numarası=";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(614, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 29;
            // 
            // numericUpDownalan
            // 
            numericUpDownalan.Location = new Point(183, 384);
            numericUpDownalan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownalan.Name = "numericUpDownalan";
            numericUpDownalan.Size = new Size(74, 27);
            numericUpDownalan.TabIndex = 31;
            numericUpDownalan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(25, 430);
            label14.Name = "label14";
            label14.Size = new Size(143, 28);
            label14.TabIndex = 32;
            label14.Text = "Kat Numarası=";
            // 
            // numericUpDownkatnumarasi
            // 
            numericUpDownkatnumarasi.Location = new Point(183, 435);
            numericUpDownkatnumarasi.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownkatnumarasi.Name = "numericUpDownkatnumarasi";
            numericUpDownkatnumarasi.Size = new Size(74, 27);
            numericUpDownkatnumarasi.TabIndex = 33;
            numericUpDownkatnumarasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // comboBoxturu
            // 
            comboBoxturu.FormattingEnabled = true;
            comboBoxturu.Location = new Point(609, 388);
            comboBoxturu.Name = "comboBoxturu";
            comboBoxturu.Size = new Size(130, 28);
            comboBoxturu.TabIndex = 34;
            // 
            // textBoxemlaknumara
            // 
            textBoxemlaknumara.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBoxemlaknumara.Location = new Point(739, 119);
            textBoxemlaknumara.Name = "textBoxemlaknumara";
            textBoxemlaknumara.Size = new Size(90, 38);
            textBoxemlaknumara.TabIndex = 35;
            textBoxemlaknumara.TextAlign = HorizontalAlignment.Center;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F);
            label15.Location = new Point(263, 382);
            label15.Name = "label15";
            label15.Size = new Size(44, 30);
            label15.TabIndex = 36;
            label15.Text = "m2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.geridön;
            pictureBox1.Location = new Point(930, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // YeniEvEkleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1015, 592);
            Controls.Add(pictureBox1);
            Controls.Add(label15);
            Controls.Add(textBoxemlaknumara);
            Controls.Add(comboBoxturu);
            Controls.Add(numericUpDownkatnumarasi);
            Controls.Add(label14);
            Controls.Add(numericUpDownalan);
            Controls.Add(textBox1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(textBoxkiradepoz);
            Controls.Add(textBoxkira);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(numericUpDown1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(radioButtonkiralik);
            Controls.Add(radioButtonsatilik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxsatis);
            Name = "YeniEvEkleme";
            Text = "YeniEvEkleme";
            Load += YeniEvEkleme_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxsatis;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radioButtonsatilik;
        private RadioButton radioButtonkiralik;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpDown1;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label10;
        private Label label11;
        private TextBox textBoxkira;
        private TextBox textBoxkiradepoz;
        private TextBox textBox4;
        private Label label12;
        private Label label13;
        private TextBox textBox1;
        private NumericUpDown numericUpDownalan;
        private Label label14;
        private NumericUpDown numericUpDownkatnumarasi;
        private ComboBox comboBoxturu;
        private TextBox textBoxemlaknumara;
        private Label label15;
        private PictureBox pictureBox1;
    }
}