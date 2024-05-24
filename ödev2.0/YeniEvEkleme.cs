using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using evclass;

namespace ödev2._0
{
    public partial class YeniEvEkleme : Form
    {
        private Dictionary<string, List<string>> sehirVeSemtler;
        private Ev[] kirakayitlar = new Ev[1000];
        private Ev[] satilikkayitlar = new Ev[1000];
        string kiralikevadres = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt";
        string satilikevadres = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt";
        int emlaknum = 0;

        public YeniEvEkleme()
        {
            InitializeComponent();

            // İlk yüklemede emlak numarasını güncelle
            UpdateEmlakNumarasi();
        }

        private void YeniEvEkleme_Load(object sender, EventArgs e)
        {


            sehirVeSemtler = new Dictionary<string, List<string>>();
            //il ve ilçeleri okumak için dosya yolları ekledim
            string dosyayolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\semtler.txt";
            if (File.Exists(dosyayolu))
            {
                string[] satirlar = File.ReadAllLines(dosyayolu);
                foreach (string satir in satirlar)
                {
                    string[] bolumler = satir.Split(':');
                    if (bolumler.Length == 2)
                    {
                        string sehir = bolumler[0];
                        string[] semtler = bolumler[1].Split(',');

                        sehirVeSemtler[sehir] = new List<string>(semtler);
                        comboBox1.Items.Add(sehir);
                    }
                }

                comboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            }
            else
            {
                MessageBox.Show("Semt bilgilerini içeren dosya bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //enum tipindeki Ev Türünü comboboxa ekleme
            foreach (string tur in Enum.GetNames(typeof(EvTuru)))
            {
                comboBoxturu.Items.Add(tur);
            }

            textBoxemlaknumara.ReadOnly = true;

            radioButtonkiralik.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            radioButtonsatilik.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);

            UpdateEmlakNumarasi();
        }

        //emlak numarası otomatik olarak atanması için
        private void UpdateEmlakNumarasi()
        {
            if (radioButtonsatilik.Checked)
            {
                if (File.Exists(satilikevadres))
                {
                    int satirsayisi = File.ReadAllLines(satilikevadres).Length;
                    textBoxemlaknumara.Text = Convert.ToInt32(satirsayisi + 1).ToString();
                }
            }
            else if (radioButtonkiralik.Checked)
            {
                if (File.Exists(kiralikevadres))
                {
                    //sıfırdan başlamaması için emlak numarasını 1 ekleyerek düzenledim
                    int satirsayisi = File.ReadAllLines(kiralikevadres).Length;
                    textBoxemlaknumara.Text = Convert.ToInt32(satirsayisi + 1).ToString();
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {

            UpdateEmlakNumarasi();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            EvTuru turu;
            //Ev türü eğer seçildiyse ve enum türüne dönüştürüldüyse if bloju çalışır
            if (comboBoxturu.SelectedItem != null && Enum.TryParse(comboBoxturu.SelectedItem.ToString(), out turu))
            {
                //eğer kiralık butonu seçilirse 
                if (radioButtonkiralik.Checked)
                {
                    //hata kontrolleri
                    int kira, kiradep, yapimyilikontrol;
                    bool yapimkont = int.TryParse(textBox4.Text, out yapimyilikontrol);
                    bool kiraIsNumeric = int.TryParse(textBoxkira.Text, out kira);
                    bool kiraDepIsNumeric = int.TryParse(textBoxkiradepoz.Text, out kiradep);

                    if (!kiraIsNumeric)
                    {
                        textBoxkira.Clear();
                        MessageBox.Show("Kira Fiyatı Yanlış Girildi ");
                        return;
                    }

                    if (!kiraDepIsNumeric)
                    {
                        textBoxkiradepoz.Clear();
                        MessageBox.Show("Kira Depozito Fiyatı Yanlış Girildi ");
                        return;
                    }
                    if (!yapimkont || Convert.ToInt32(textBox4.Text) > 2024)
                    {
                        textBox4.Clear();
                        MessageBox.Show("Yapım Yılı Yanlış Girildi");
                        return;
                    }

                    //kiralık sınıfı ile  constructor kullanarak overload edilmiş constructoru kullanma
                    Kiralikev kiralik1 = new Kiralikev
                    {
                        Odasayisi = (int)numericUpDown1.Value,
                        Kirafiyat = Convert.ToInt32(textBoxkira.Text),
                        Kiradepozito = Convert.ToInt32(textBoxkiradepoz.Text),
                        Aktif = true,
                        YapimTarihi = Convert.ToInt32(textBox4.Text),
                        EvYasi = Convert.ToInt32(textBox4.Text),
                        Semt = $"il={comboBox1.Text}, ilçe={comboBox2.Text}, mahalle={textBox1.Text}",
                        Alani = (int)numericUpDownalan.Value,
                        Emlaknumarasi = Convert.ToInt32(textBoxemlaknumara.Text),
                        Katnumarasi = (int)numericUpDownkatnumarasi.Value,
                        Turu = turu
                    };

                    MessageBox.Show(kiralik1.EvbBilgileri());
                    kirakayitlar[kiralik1.Emlaknumarasi] = kiralik1;

                    using (StreamWriter dosyayaz = new StreamWriter(kiralikevadres, append: true))
                    {
                        dosyayaz.WriteLine($"emlak numarasi={kiralik1.Emlaknumarasi}, {kiralik1.Semt}, Kat Numarası={kiralik1.Katnumarasi}, Alanı={kiralik1.Alani}, Yapım Tarihi={kiralik1.YapimTarihi}, Ev Yaşı={kiralik1.EvYasi}, Oda Sayısı={kiralik1.Odasayisi}, Aktif Mi={kiralik1.Aktif}, Kira Fiyatı={kiralik1.Kirafiyat}, Kira Depozito Fiyatı={kiralik1.Kiradepozito}, Ev Türü={kiralik1.Turu}");
                    }
                    verileritemizle();


                }
                //eğer satılık butonu seçilirse
                else if (radioButtonsatilik.Checked)
                {
                    //hata kontrolleri
                    int yapimyilikontrol, satilikkontrol;
                    bool yapimkont = int.TryParse(textBox4.Text, out yapimyilikontrol);
                    bool satkont = int.TryParse(textBoxsatis.Text, out satilikkontrol);
                    if (!satkont)
                    {
                        textBoxsatis.Clear();
                        MessageBox.Show("Satış Fiyatı Yanlış Girildi");
                        return;
                    }

                    if (!yapimkont || Convert.ToInt32(textBox4.Text) > 2024)
                    {
                        textBox4.Clear();
                        MessageBox.Show("Yapım Yılı Yanlış Girildi");
                        return;
                    }
                    //satılıkev sınıfı constructoru ile değer ataması
                    SatilikEv satilik1 = new SatilikEv
                    {
                        Odasayisi = (int)numericUpDown1.Value,
                        Satilikevfiyat = Convert.ToInt32(textBoxsatis.Text),
                        Katnumarasi = (int)numericUpDownkatnumarasi.Value,
                        Aktif = true,
                        YapimTarihi = Convert.ToInt32(textBox4.Text),
                        EvYasi = Convert.ToInt32(textBox4.Text),
                        Semt = $"il={comboBox1.Text}, ilçe={comboBox2.Text}, mahalle={textBox1.Text}",
                        Alani = (int)numericUpDownalan.Value,
                        Emlaknumarasi = Convert.ToInt32(textBoxemlaknumara.Text),
                        Turu = turu
                    };

                    MessageBox.Show(satilik1.EvbBilgileri());
                    satilikkayitlar[satilik1.Emlaknumarasi] = satilik1;
                    //değerleri satılık.txt ye gönderme
                    using (StreamWriter dosyayaz = new StreamWriter(satilikevadres, append: true))
                    {
                        dosyayaz.WriteLine($"emlak numarasi={satilik1.Emlaknumarasi}, {satilik1.Semt}, Kat Numarası={satilik1.Katnumarasi}, Alanı={satilik1.Alani}, Yapım Tarihi={satilik1.YapimTarihi}, Ev Yaşı={satilik1.EvYasi}, Oda Sayısı={satilik1.Odasayisi}, Aktif Mi={satilik1.Aktif}, Satılık Ev Fiyatı={satilik1.Satilikevfiyat}, Ev Türü={satilik1.Turu}");
                    }
                    verileritemizle();
                }
            }
            else
            {
                MessageBox.Show("Geçersiz ev türü seçimi!");
            }


            emlaknum = Convert.ToInt32(textBoxemlaknumara.Text);
            emlaknum++;
            textBoxemlaknumara.Text = emlaknum.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen şehire göre ilçeleri combobox2 ye semtler adlı dosyadan yazma
            string secilenSehir = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();

            if (sehirVeSemtler.ContainsKey(secilenSehir))
            {
                foreach (string semt in sehirVeSemtler[secilenSehir])
                {
                    comboBox2.Items.Add(semt);
                }
            }
        }

        private void radioButtonkiralik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonkiralik.Checked)
            {
                textBoxsatis.ReadOnly = true;
                textBoxsatis.Clear();
                textBoxkira.ReadOnly = false;
                textBoxkiradepoz.ReadOnly = false;
            }
        }

        private void radioButtonsatilik_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonsatilik.Checked)
            {
                textBoxkira.ReadOnly = true;
                textBoxkiradepoz.ReadOnly = true;
                textBoxkira.Clear();
                textBoxkiradepoz.Clear();
                textBoxsatis.ReadOnly = false;
            }
        }

        private void textBoxsatis_TextChanged(object sender, EventArgs e)
        {

        }
        public void verileritemizle()
        {
            textBoxsatis.Clear();
            textBoxkiradepoz.Clear();
            textBoxkira.Clear();
            textBox4.Clear();
            textBox1.Clear();
            numericUpDown1.Value = 1;
            numericUpDownalan.Value = 1;
            numericUpDownkatnumarasi.Value = 1;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main geri = new Main();
            geri.Show();
            this.Hide();

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
