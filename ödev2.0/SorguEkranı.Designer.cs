namespace ödev2._0
{
    partial class SorguEkranı
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
            listView1 = new ListView();
            radioButtonkiralik = new RadioButton();
            radioButtonsatilik = new RadioButton();
            label5 = new Label();
            comboBoxaktifmi = new ComboBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            comboBoxturu = new ComboBox();
            numericUpDownkatnumarasi = new NumericUpDown();
            label14 = new Label();
            numericUpDownalan = new NumericUpDown();
            textBox1 = new TextBox();
            label12 = new Label();
            textBox4 = new TextBox();
            textBoxkiradepoz = new TextBox();
            textBoxkira = new TextBox();
            label11 = new Label();
            label10 = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label9 = new Label();
            numericUpDown2 = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label13 = new Label();
            textBoxsatis = new TextBox();
            numericUpDown1 = new NumericUpDown();
            label6 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(59, 446);
            listView1.Name = "listView1";
            listView1.Size = new Size(1196, 346);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // radioButtonkiralik
            // 
            radioButtonkiralik.Font = new Font("Segoe UI", 13F);
            radioButtonkiralik.Location = new Point(808, 92);
            radioButtonkiralik.Name = "radioButtonkiralik";
            radioButtonkiralik.Size = new Size(93, 34);
            radioButtonkiralik.TabIndex = 19;
            radioButtonkiralik.TabStop = true;
            radioButtonkiralik.Text = "Kiralık";
            radioButtonkiralik.UseVisualStyleBackColor = true;
            radioButtonkiralik.CheckedChanged += radioButtonkiralik_CheckedChanged_1;
            // 
            // radioButtonsatilik
            // 
            radioButtonsatilik.Font = new Font("Segoe UI", 13F);
            radioButtonsatilik.Location = new Point(713, 92);
            radioButtonsatilik.Name = "radioButtonsatilik";
            radioButtonsatilik.Size = new Size(101, 34);
            radioButtonsatilik.TabIndex = 18;
            radioButtonsatilik.TabStop = true;
            radioButtonsatilik.Text = "Satılık";
            radioButtonsatilik.UseVisualStyleBackColor = true;
            radioButtonsatilik.CheckedChanged += radioButtonsatilik_CheckedChanged_1;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(515, 92);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 17;
            label5.Text = "Satılık mı Kiralık mı=";
            // 
            // comboBoxaktifmi
            // 
            comboBoxaktifmi.FormattingEnabled = true;
            comboBoxaktifmi.Items.AddRange(new object[] { "", "True", "False" });
            comboBoxaktifmi.Location = new Point(269, 141);
            comboBoxaktifmi.Name = "comboBoxaktifmi";
            comboBoxaktifmi.Size = new Size(125, 28);
            comboBoxaktifmi.TabIndex = 122;
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(165, 137);
            label17.Name = "label17";
            label17.Size = new Size(100, 28);
            label17.TabIndex = 121;
            label17.Text = "Aktif Mi=";
            // 
            // label16
            // 
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.ForeColor = Color.Red;
            label16.Location = new Point(72, 9);
            label16.Name = "label16";
            label16.Size = new Size(1279, 69);
            label16.TabIndex = 120;
            label16.Text = "Sorgulamak İstediğiniz Evin Bilgilerini Doldurunuz (Tüm Kayıtları Görüntülemek İçin Kiralık Veya Satılık Tuşunu İşaretleyiniz)";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F);
            label15.Location = new Point(349, 345);
            label15.Name = "label15";
            label15.Size = new Size(44, 30);
            label15.TabIndex = 119;
            label15.Text = "m2";
            // 
            // comboBoxturu
            // 
            comboBoxturu.FormattingEnabled = true;
            comboBoxturu.Location = new Point(667, 393);
            comboBoxturu.Name = "comboBoxturu";
            comboBoxturu.Size = new Size(130, 28);
            comboBoxturu.TabIndex = 118;
            // 
            // numericUpDownkatnumarasi
            // 
            numericUpDownkatnumarasi.Location = new Point(269, 398);
            numericUpDownkatnumarasi.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownkatnumarasi.Name = "numericUpDownkatnumarasi";
            numericUpDownkatnumarasi.Size = new Size(74, 27);
            numericUpDownkatnumarasi.TabIndex = 117;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(111, 393);
            label14.Name = "label14";
            label14.Size = new Size(143, 28);
            label14.TabIndex = 116;
            label14.Text = "Kat Numarası=";
            // 
            // numericUpDownalan
            // 
            numericUpDownalan.Location = new Point(269, 347);
            numericUpDownalan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownalan.Name = "numericUpDownalan";
            numericUpDownalan.Size = new Size(74, 27);
            numericUpDownalan.TabIndex = 115;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(672, 279);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 114;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(193, 346);
            label12.Name = "label12";
            label12.Size = new Size(70, 28);
            label12.TabIndex = 113;
            label12.Text = "Alanı=";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(672, 337);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 112;
            // 
            // textBoxkiradepoz
            // 
            textBoxkiradepoz.Location = new Point(269, 295);
            textBoxkiradepoz.Name = "textBoxkiradepoz";
            textBoxkiradepoz.Size = new Size(125, 27);
            textBoxkiradepoz.TabIndex = 111;
            // 
            // textBoxkira
            // 
            textBoxkira.Location = new Point(269, 238);
            textBoxkira.Name = "textBoxkira";
            textBoxkira.Size = new Size(125, 27);
            textBoxkira.TabIndex = 110;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(548, 276);
            label11.Name = "label11";
            label11.Size = new Size(118, 28);
            label11.TabIndex = 109;
            label11.Text = "Açık Adres=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(611, 232);
            label10.Name = "label10";
            label10.Size = new Size(55, 28);
            label10.TabIndex = 108;
            label10.Text = "İlçe=";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "" });
            comboBox2.Location = new Point(672, 232);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(119, 28);
            comboBox2.TabIndex = 107;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "" });
            comboBox1.Location = new Point(672, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 106;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(596, 389);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 105;
            label9.Text = "Türü=";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(674, 142);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(74, 27);
            numericUpDown2.TabIndex = 104;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(556, 336);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 103;
            label8.Text = "Yapım Yılı=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(100, 291);
            label7.Name = "label7";
            label7.Size = new Size(165, 28);
            label7.TabIndex = 102;
            label7.Text = "Kira Depozitosu=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(151, 237);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 101;
            label2.Text = "Kira Fiyatı=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(144, 186);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 100;
            label3.Text = "Satış Fiyatı=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(630, 178);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 99;
            label4.Text = "İl=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(556, 141);
            label13.Name = "label13";
            label13.Size = new Size(117, 28);
            label13.TabIndex = 98;
            label13.Text = "Oda Sayısı=";
            // 
            // textBoxsatis
            // 
            textBoxsatis.Location = new Point(269, 187);
            textBoxsatis.Name = "textBoxsatis";
            textBoxsatis.Size = new Size(125, 27);
            textBoxsatis.TabIndex = 97;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(269, 99);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(102, 27);
            numericUpDown1.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(59, 95);
            label6.Name = "label6";
            label6.Size = new Size(204, 31);
            label6.TabIndex = 92;
            label6.Text = "Emlak Numarası=";
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Segoe UI", 13F);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1274, 682);
            button3.Name = "button3";
            button3.Size = new Size(164, 73);
            button3.TabIndex = 125;
            button3.Text = "Evi Düzenleme Ekranına Geç";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 13F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1274, 589);
            button2.Name = "button2";
            button2.Size = new Size(164, 73);
            button2.TabIndex = 124;
            button2.Text = "Evi Silme Ekranına Geç";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1004, 142);
            button1.Name = "button1";
            button1.Size = new Size(181, 124);
            button1.TabIndex = 123;
            button1.Text = "Evleri Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.geridön;
            pictureBox1.Location = new Point(1274, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 126;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkViolet;
            button4.Font = new Font("Segoe UI", 13F);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(1041, 279);
            button4.Name = "button4";
            button4.Size = new Size(104, 73);
            button4.TabIndex = 127;
            button4.Text = "Arşivle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Lime;
            button5.Font = new Font("Segoe UI", 13F);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(1274, 498);
            button5.Name = "button5";
            button5.Size = new Size(164, 73);
            button5.TabIndex = 128;
            button5.Text = "Ev Ekleme Ekranına Geç";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // SorguEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1464, 804);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBoxaktifmi);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(comboBoxturu);
            Controls.Add(numericUpDownkatnumarasi);
            Controls.Add(label14);
            Controls.Add(numericUpDownalan);
            Controls.Add(textBox1);
            Controls.Add(label12);
            Controls.Add(textBox4);
            Controls.Add(textBoxkiradepoz);
            Controls.Add(textBoxkira);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(numericUpDown2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label13);
            Controls.Add(textBoxsatis);
            Controls.Add(numericUpDown1);
            Controls.Add(label6);
            Controls.Add(radioButtonkiralik);
            Controls.Add(radioButtonsatilik);
            Controls.Add(label5);
            Controls.Add(listView1);
            Name = "SorguEkranı";
            Text = "SorguEkranı";
            Load += SorguEkranı_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private RadioButton radioButtonkiralik;
        private RadioButton radioButtonsatilik;
        private Label label5;
        private ComboBox comboBoxaktifmi;
        private Label label17;
        private Label label16;
        private Label label15;
        private ComboBox comboBoxturu;
        private NumericUpDown numericUpDownkatnumarasi;
        private Label label14;
        private NumericUpDown numericUpDownalan;
        private TextBox textBox1;
        private Label label12;
        private TextBox textBox4;
        private TextBox textBoxkiradepoz;
        private TextBox textBoxkira;
        private Label label11;
        private Label label10;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label9;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label13;
        private TextBox textBoxsatis;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Button button3;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button5;
    }
}