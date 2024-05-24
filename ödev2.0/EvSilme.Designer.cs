namespace ödev2._0
{
    partial class EvSilme
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
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            radioButtonkiralik = new RadioButton();
            radioButtonsatilik = new RadioButton();
            label5 = new Label();
            label6 = new Label();
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
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
            button3 = new Button();
            label16 = new Label();
            label17 = new Label();
            comboBoxaktifmi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(193, 65);
            label1.Name = "label1";
            label1.Size = new Size(642, 31);
            label1.TabIndex = 0;
            label1.Text = "Silmek veya düzenlemek İstediğiniz Evin Emlak Numarası=";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(841, 69);
            numericUpDown1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(102, 27);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(1124, 169);
            button1.Name = "button1";
            button1.Size = new Size(104, 73);
            button1.TabIndex = 2;
            button1.Text = "Evleri Görüntüle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 13F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(1124, 259);
            button2.Name = "button2";
            button2.Size = new Size(104, 73);
            button2.TabIndex = 3;
            button2.Text = "Evi Sil";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // radioButtonkiralik
            // 
            radioButtonkiralik.Font = new Font("Segoe UI", 13F);
            radioButtonkiralik.Location = new Point(752, 118);
            radioButtonkiralik.Name = "radioButtonkiralik";
            radioButtonkiralik.Size = new Size(93, 34);
            radioButtonkiralik.TabIndex = 13;
            radioButtonkiralik.TabStop = true;
            radioButtonkiralik.Text = "Kiralık";
            radioButtonkiralik.UseVisualStyleBackColor = true;
            radioButtonkiralik.CheckedChanged += radioButtonkiralik_CheckedChanged;
            // 
            // radioButtonsatilik
            // 
            radioButtonsatilik.Font = new Font("Segoe UI", 13F);
            radioButtonsatilik.Location = new Point(657, 118);
            radioButtonsatilik.Name = "radioButtonsatilik";
            radioButtonsatilik.Size = new Size(101, 34);
            radioButtonsatilik.TabIndex = 12;
            radioButtonsatilik.TabStop = true;
            radioButtonsatilik.Text = "Satılık";
            radioButtonsatilik.UseVisualStyleBackColor = true;
            radioButtonsatilik.CheckedChanged += radioButtonsatilik_CheckedChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(459, 118);
            label5.Name = "label5";
            label5.Size = new Size(192, 28);
            label5.TabIndex = 11;
            label5.Text = "Satılık mı Kiralık mı=";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(123, 26);
            label6.Name = "label6";
            label6.Size = new Size(1034, 31);
            label6.TabIndex = 14;
            label6.Text = "Silmek İstediğiniz Evin Emlak Numarasını Girin Veya Emlak Numarası Satırında Üzerine Tıklayın";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 472);
            listView1.Name = "listView1";
            listView1.Size = new Size(1301, 270);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            listView1.MouseClick += listView1_MouseClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Image = Properties.Resources.geridön;
            pictureBox1.Location = new Point(1252, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 13F);
            label15.Location = new Point(310, 373);
            label15.Name = "label15";
            label15.Size = new Size(44, 30);
            label15.TabIndex = 87;
            label15.Text = "m2";
            // 
            // comboBoxturu
            // 
            comboBoxturu.FormattingEnabled = true;
            comboBoxturu.Location = new Point(628, 421);
            comboBoxturu.Name = "comboBoxturu";
            comboBoxturu.Size = new Size(130, 28);
            comboBoxturu.TabIndex = 86;
            // 
            // numericUpDownkatnumarasi
            // 
            numericUpDownkatnumarasi.Location = new Point(230, 426);
            numericUpDownkatnumarasi.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numericUpDownkatnumarasi.Name = "numericUpDownkatnumarasi";
            numericUpDownkatnumarasi.Size = new Size(74, 27);
            numericUpDownkatnumarasi.TabIndex = 85;
            numericUpDownkatnumarasi.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F);
            label14.Location = new Point(72, 421);
            label14.Name = "label14";
            label14.Size = new Size(143, 28);
            label14.TabIndex = 84;
            label14.Text = "Kat Numarası=";
            // 
            // numericUpDownalan
            // 
            numericUpDownalan.Location = new Point(230, 375);
            numericUpDownalan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownalan.Name = "numericUpDownalan";
            numericUpDownalan.Size = new Size(74, 27);
            numericUpDownalan.TabIndex = 83;
            numericUpDownalan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // textBox1
            // 
            textBox1.Location = new Point(633, 307);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 82;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(154, 374);
            label12.Name = "label12";
            label12.Size = new Size(70, 28);
            label12.TabIndex = 81;
            label12.Text = "Alanı=";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(633, 365);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 80;
            // 
            // textBoxkiradepoz
            // 
            textBoxkiradepoz.Location = new Point(230, 323);
            textBoxkiradepoz.Name = "textBoxkiradepoz";
            textBoxkiradepoz.Size = new Size(125, 27);
            textBoxkiradepoz.TabIndex = 79;
            // 
            // textBoxkira
            // 
            textBoxkira.Location = new Point(230, 266);
            textBoxkira.Name = "textBoxkira";
            textBoxkira.Size = new Size(125, 27);
            textBoxkira.TabIndex = 78;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(509, 304);
            label11.Name = "label11";
            label11.Size = new Size(118, 28);
            label11.TabIndex = 77;
            label11.Text = "Açık Adres=";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(572, 260);
            label10.Name = "label10";
            label10.Size = new Size(55, 28);
            label10.TabIndex = 76;
            label10.Text = "İlçe=";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(633, 260);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(119, 28);
            comboBox2.TabIndex = 75;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(633, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(119, 28);
            comboBox1.TabIndex = 74;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(557, 417);
            label9.Name = "label9";
            label9.Size = new Size(65, 28);
            label9.TabIndex = 73;
            label9.Text = "Türü=";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(635, 170);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(74, 27);
            numericUpDown2.TabIndex = 72;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(517, 364);
            label8.Name = "label8";
            label8.Size = new Size(110, 28);
            label8.TabIndex = 71;
            label8.Text = "Yapım Yılı=";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(61, 319);
            label7.Name = "label7";
            label7.Size = new Size(165, 28);
            label7.TabIndex = 70;
            label7.Text = "Kira Depozitosu=";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(112, 265);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 69;
            label2.Text = "Kira Fiyatı=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(105, 214);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 68;
            label3.Text = "Satış Fiyatı=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(591, 206);
            label4.Name = "label4";
            label4.Size = new Size(36, 28);
            label4.TabIndex = 67;
            label4.Text = "İl=";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F);
            label13.Location = new Point(517, 169);
            label13.Name = "label13";
            label13.Size = new Size(117, 28);
            label13.TabIndex = 66;
            label13.Text = "Oda Sayısı=";
            // 
            // textBoxsatis
            // 
            textBoxsatis.Location = new Point(230, 215);
            textBoxsatis.Name = "textBoxsatis";
            textBoxsatis.Size = new Size(125, 27);
            textBoxsatis.TabIndex = 65;
            // 
            // button3
            // 
            button3.BackColor = Color.LawnGreen;
            button3.Font = new Font("Segoe UI", 13F);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(1124, 352);
            button3.Name = "button3";
            button3.Size = new Size(104, 73);
            button3.TabIndex = 88;
            button3.Text = "Evi Düzenle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label16.Location = new Point(46, 118);
            label16.Name = "label16";
            label16.Size = new Size(407, 31);
            label16.TabIndex = 89;
            label16.Text = "Düzenlemek İstediğiniz Evin Bilgileri";
            // 
            // label17
            // 
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(126, 165);
            label17.Name = "label17";
            label17.Size = new Size(100, 28);
            label17.TabIndex = 90;
            label17.Text = "Aktif Mi=";
            // 
            // comboBoxaktifmi
            // 
            comboBoxaktifmi.FormattingEnabled = true;
            comboBoxaktifmi.Items.AddRange(new object[] { "True", "false" });
            comboBoxaktifmi.Location = new Point(230, 169);
            comboBoxaktifmi.Name = "comboBoxaktifmi";
            comboBoxaktifmi.Size = new Size(125, 28);
            comboBoxaktifmi.TabIndex = 91;
            // 
            // EvSilme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1325, 754);
            Controls.Add(comboBoxaktifmi);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(button3);
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
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(radioButtonkiralik);
            Controls.Add(radioButtonsatilik);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Name = "EvSilme";
            Text = "EvSilme";
            Load += EvSilme_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownkatnumarasi).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownalan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Button button2;
        private RadioButton radioButtonkiralik;
        private RadioButton radioButtonsatilik;
        private Label label5;
        private Label label6;
        private ListView listView1;
        private PictureBox pictureBox1;
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
        private Button button3;
        private Label label16;
        private Label label17;
        private ComboBox comboBoxaktifmi;
    }
}