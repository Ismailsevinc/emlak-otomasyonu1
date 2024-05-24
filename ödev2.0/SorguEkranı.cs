using evclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ödev2._0
{
    public partial class SorguEkranı : Form
    {
        private Dictionary<string, List<string>> sehirVeSemtler;
        string kiralikdosya = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt";
        string satilikdosya = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt";
        public SorguEkranı()
        {
            InitializeComponent();
        }

        private void SorguEkranı_Load(object sender, EventArgs e)
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

                comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
        }
        private void listviewverieklekiralik(string dosyayolu)
        {
            string[] satirlar = File.ReadAllLines(dosyayolu);

            foreach (string satir in satirlar)
            {
                string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                // parts dizisi, beklenenden daha az öğe içeriyorsa hata alabiliriz
                if (parts.Length >= 13)
                {
                    string emlakNumarasi = parts[0].Split('=')[1];
                    string il = parts[1].Split('=')[1];
                    string ilce = parts[2].Split('=')[1];
                    string mahalle = parts[3].Split('=')[1];
                    string katNumarasi = parts[4].Split('=')[1];
                    string alani = parts[5].Split('=')[1];
                    string yapimTarihi = parts[6].Split('=')[1];
                    string evYasi = parts[7].Split('=')[1];
                    string odaSayisi = parts[8].Split('=')[1];
                    string aktifMi = parts[9].Split('=')[1];
                    string kiraFiyati = parts[10].Split('=')[1];
                    string kiraDepozitoFiyati = parts[11].Split('=')[1];
                    string evTuru = parts[12].Split('=')[1];

                    ListViewItem item = new ListViewItem(emlakNumarasi);
                    item.SubItems.Add(il);
                    item.SubItems.Add(ilce);
                    item.SubItems.Add(mahalle);
                    item.SubItems.Add(katNumarasi);
                    item.SubItems.Add(alani);
                    item.SubItems.Add(yapimTarihi);
                    item.SubItems.Add(evYasi);
                    item.SubItems.Add(odaSayisi);
                    item.SubItems.Add(aktifMi);
                    item.SubItems.Add(kiraFiyati);
                    item.SubItems.Add(kiraDepozitoFiyati);
                    item.SubItems.Add(evTuru);

                    listView1.Items.Add(item);
                }
                else
                {
                    // Hatalı satırı işaretleme veya raporlama
                    MessageBox.Show("Hatalı satır: " + satir, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listviewverieklesatilik(string dosyayolu)
        {
            string[] satirlar = File.ReadAllLines(dosyayolu);

            foreach (string satir in satirlar)
            {
                string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                string emlakNumarasi = parts[0].Split('=')[1];
                string il = parts[1].Split('=')[1];
                string ilce = parts[2].Split('=')[1];
                string mahalle = parts[3].Split('=')[1];
                string katNumarasi = parts[4].Split('=')[1];
                string alani = parts[5].Split('=')[1];
                string yapimTarihi = parts[6].Split('=')[1];
                string evYasi = parts[7].Split('=')[1];
                string odaSayisi = parts[8].Split('=')[1];
                string aktifMi = parts[9].Split('=')[1];
                string satilikEvFiyati = parts[10].Split('=')[1];
                string evTuru = parts[11].Split('=')[1];

                ListViewItem item = new ListViewItem(emlakNumarasi);
                item.SubItems.Add(il);
                item.SubItems.Add(ilce);
                item.SubItems.Add(mahalle);
                item.SubItems.Add(katNumarasi);
                item.SubItems.Add(alani);
                item.SubItems.Add(yapimTarihi);
                item.SubItems.Add(evYasi);
                item.SubItems.Add(odaSayisi);
                item.SubItems.Add(aktifMi);
                item.SubItems.Add(satilikEvFiyati);
                item.SubItems.Add(evTuru);

                listView1.Items.Add(item);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            //eğer satılık ve kiralık butonlarının ikiside seçilmezse
            if (!radioButtonkiralik.Checked && !radioButtonsatilik.Checked)
            {
                MessageBox.Show("Lütfen kiralık veya satılık adlı butonlardan birini işaretleyiniz");
            }
            if (radioButtonkiralik.Checked)
            {
                if ((numericUpDown1.Value == 0) && (textBox1.Text == "") && (textBox4.Text == "") && (textBoxkira.Text == "") &&
           (textBoxkiradepoz.Text == "") && (numericUpDown2.Value == 0) && (numericUpDownalan.Value == 0) && (numericUpDownkatnumarasi.Value == 0)
           && (comboBox1.Text == "") && (comboBox2.Text == "") && (comboBoxaktifmi.Text == "") && (comboBoxturu.Text == "") && (textBoxsatis.Text == ""))
                {
                    listView1.Items.Clear();
                    listviewverieklekiralik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt");
                }
            } //eğer sadece kilarık butonu seçiliyse
            if (radioButtonsatilik.Checked)
            {
                if ((numericUpDown1.Value == 0) && (textBox1.Text == "") && (textBox4.Text == "") && (textBoxkira.Text == "") &&
           (textBoxkiradepoz.Text == "") && (numericUpDown2.Value == 0) && (numericUpDownalan.Value == 0) && (numericUpDownkatnumarasi.Value == 0)
           && (comboBox1.Text == "") && (comboBox2.Text == "") && (comboBoxaktifmi.Text == "") && (comboBoxturu.Text == "") && (textBoxsatis.Text == ""))
                {
                    listView1.Items.Clear();
                    listviewverieklesatilik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt");
                }

            } // eğer sadece satılık butonu seçiliyse
            if (numericUpDown1.Value != 0 && radioButtonkiralik.Checked) // emlak numarası verilmişse
            {
                string emlaknumarasi = numericUpDown1.Value.ToString();
                string[] satirlar = File.ReadAllLines(kiralikdosya);
                List<string> list = new List<string>();
                foreach (string satir in satirlar)
                {
                    string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);
                    string emlaknum = parts[0].Split("=")[1];
                    if (emlaknum == emlaknumarasi)
                    {
                        listView1.Items.Clear();
                        // Satırın ilk parçasını (emlak numarasını) kaldır
                        List<string> listViewItems = new List<string>();
                        for (int i = 0; i < parts.Length; i++)
                        {
                            listViewItems.Add(parts[i].Split('=')[1]);
                        }
                        // Satırı ListView'e ekle
                        ListViewItem item = new ListViewItem(listViewItems.ToArray());
                        listView1.Items.Add(item);
                        // Döngüden çık
                        break;
                    }
                }
            }
            else if (numericUpDown1.Value != 0 && radioButtonsatilik.Checked)
            {
                string emlaknumarasi = numericUpDown1.Value.ToString();
                string[] satirlar = File.ReadAllLines(satilikdosya);
                List<string> list = new List<string>();
                foreach (string satir in satirlar)
                {
                    string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);
                    string emlaknum = parts[0].Split("=")[1];
                    if (emlaknum == emlaknumarasi)
                    {
                        listView1.Items.Clear();
                        // Satırın ilk parçasını (emlak numarasını) kaldır
                        List<string> listViewItems = new List<string>();
                        for (int i = 0; i < parts.Length; i++)
                        {
                            listViewItems.Add(parts[i].Split('=')[1]);
                        }
                        // Satırı ListView'e ekle
                        ListViewItem item = new ListViewItem(listViewItems.ToArray());
                        listView1.Items.Add(item);
                        // Döngüden çık
                        break;
                    }
                }
            }

            if (numericUpDown2.Value != 0)
            {
                string dosyaYolu = radioButtonkiralik.Checked ? kiralikdosya : satilikdosya;

                string odaSayisiAranan = numericUpDown2.Value.ToString();

                listView1.Items.Clear(); // ListView'i temizle

                if (File.Exists(dosyaYolu))
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);

                    foreach (string satir in satirlar)
                    {
                        string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                        if (parts.Length >= 9) // Oda sayısının olduğu indeks
                        {
                            string odaSayisi = parts[8].Split('=')[1]; // Oda sayısını al

                            if (odaSayisi == odaSayisiAranan) // Eşleşme kontrolü
                            {
                                // Satırın ListView'e eklenmesi için gereken adımlar
                                List<string> listViewItems = new List<string>();
                                for (int i = 0; i < parts.Length; i++)
                                {
                                    listViewItems.Add(parts[i].Split('=')[1]);
                                }
                                // Satırı ListView'e ekle
                                ListViewItem item = new ListViewItem(listViewItems.ToArray());
                                listView1.Items.Add(item);
                                // Döngüden çıkma ifadesi (break;) kaldırıldı
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı: " + dosyaYolu, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (numericUpDown2.Value != 0)
            {
                string dosyaYolu = radioButtonkiralik.Checked ? kiralikdosya : satilikdosya;
                string odaSayisiAranan = numericUpDown2.Value.ToString();
                string aktifMiBeklenen = comboBoxaktifmi.Text; // "true" ya da "false"

                listView1.Items.Clear(); // ListView'i temizle

                if (File.Exists(dosyaYolu))
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);

                    foreach (string satir in satirlar)
                    {
                        string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                        if (parts.Length >= 10) // Hem oda sayısı hem de aktif mi kısmının olduğu indeks
                        {
                            string odaSayisi = parts[8].Split('=')[1]; // Oda sayısını al
                            string aktifMi = parts[9].Split('=')[1]; // Aktif mi değerini al

                            if (odaSayisi == odaSayisiAranan && aktifMi == aktifMiBeklenen) // Eşleşme ve aktif kontrolü
                            {
                                // Satırın ListView'e eklenmesi için gereken adımlar
                                List<string> listViewItems = new List<string>();
                                for (int i = 0; i < parts.Length; i++)
                                {
                                    listViewItems.Add(parts[i].Split('=')[1]);
                                }
                                // Satırı ListView'e ekle
                                ListViewItem item = new ListViewItem(listViewItems.ToArray());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı: " + dosyaYolu, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (comboBoxaktifmi.Text!="")
            {
                string dosyaYolu = radioButtonkiralik.Checked ? kiralikdosya : satilikdosya;               
                string aktifMiBeklenen = comboBoxaktifmi.Text; // "true" ya da "false"

                listView1.Items.Clear(); // ListView'i temizle

                if (File.Exists(dosyaYolu))
                {
                    string[] satirlar = File.ReadAllLines(dosyaYolu);

                    foreach (string satir in satirlar)
                    {
                        string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                        if (parts.Length >= 10) // Hem oda sayısı hem de aktif mi kısmının olduğu indeks
                        {
                           
                            string aktifMi = parts[9].Split('=')[1]; // Aktif mi değerini al

                            if ( aktifMi == aktifMiBeklenen) // Eşleşme ve aktif kontrolü
                            {
                                // Satırın ListView'e eklenmesi için gereken adımlar
                                List<string> listViewItems = new List<string>();
                                for (int i = 0; i < parts.Length; i++)
                                {
                                    listViewItems.Add(parts[i].Split('=')[1]);
                                }
                                // Satırı ListView'e ekle
                                ListViewItem item = new ListViewItem(listViewItems.ToArray());
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Belirtilen dosya bulunamadı: " + dosyaYolu, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonsatilik_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (radioButtonsatilik.Checked)
            {
                textBoxkira.ReadOnly = true;
                textBoxkiradepoz.ReadOnly = true;
                textBoxkira.Clear();
                textBoxkiradepoz.Clear();
                textBoxsatis.ReadOnly = false;
            }
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Emlak Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("İl", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("İlçe", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("mahalle", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Kat Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Alanı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Yapım Tarihi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ev Yaşı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Oda Sayısı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Aktif Mi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Satılık Ev Fiyatı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ev Türü", 100, HorizontalAlignment.Left);
        }

        private void radioButtonkiralik_CheckedChanged_1(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (radioButtonkiralik.Checked)
            {
                textBoxsatis.ReadOnly = true;
                textBoxsatis.Clear();
                textBoxkira.ReadOnly = false;
                textBoxkiradepoz.ReadOnly = false;
            }
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Emlak Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("İl", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("İlçe", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("mahalle", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Kat Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Alanı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Yapım Tarihi", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ev Yaşı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Oda Sayısı", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Aktif Mi", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Kira Fiyatı", 70, HorizontalAlignment.Left);
            listView1.Columns.Add("Kira Depozito Fiyatı", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Ev Türü", 70, HorizontalAlignment.Left);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main geri = new Main();
            geri.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool emlakNumarasiBulundu = false; // Emlak numarasının bulunduğunu kontrol etmek için bir bayrak

            if (numericUpDown1.Value != 0 && radioButtonkiralik.Checked)
            {
                string kiralikdosya = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt";
                if (File.Exists(kiralikdosya))
                {
                    string[] satirlar = File.ReadAllLines(kiralikdosya);
                    List<string> yeniSatirlar = new List<string>();
                    foreach (string satir in satirlar)
                    {
                        // Satırı parçalara ayır
                        string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                        // Emlak numarası
                        string emlakNumarasi = parts[0].Split('=')[1];

                        // Emlak numarası numericUpDown1.Value'ya eşitse, satırı güncelle
                        if (emlakNumarasi == numericUpDown1.Value.ToString())
                        {
                            // AktifMi kısmını false yapma
                            parts[9] = "Aktif Mi=False";
                            // Güncellenmiş satırı oluştur
                            string yeniSatir = string.Join(", ", parts);
                            // Yeni satırı yeniSatirlar listesine ekle
                            yeniSatirlar.Add(yeniSatir);
                            // Emlak numarasının bulunduğunu işaretle
                            emlakNumarasiBulundu = true;
                            MessageBox.Show($"emlak numarası={numericUpDown1.Value.ToString()} olan ev arşivlendi");
                            listView1.Items.Clear();
                            listviewverieklekiralik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt");
                            numericUpDown1.Value = 0;

                        }
                        else
                        {
                            // Emlak numarası eşleşmezse, satırı olduğu gibi yeniSatirlar listesine ekle
                            yeniSatirlar.Add(satir);
                        }
                    }
                    // Eğer belirtilen emlak numarası bulunamazsa, kullanıcıya uyarı ver
                    if (!emlakNumarasiBulundu)
                    {
                        MessageBox.Show("Belirtilen emlak numarası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Yeni satırları dosyaya yaz
                        File.WriteAllLines(kiralikdosya, yeniSatirlar);
                    }
                }
            }
            if (numericUpDown1.Value != 0 && radioButtonsatilik.Checked)
            {

                if (File.Exists(satilikdosya))
                {
                    string[] satirlar = File.ReadAllLines(satilikdosya);
                    List<string> yeniSatirlar = new List<string>();
                    foreach (string satir in satirlar)
                    {
                        // Satırı parçalara ayır
                        string[] parts = satir.Split(new[] { ", " }, StringSplitOptions.None);

                        // Emlak numarası
                        string emlakNumarasi = parts[0].Split('=')[1];

                        // Emlak numarası numericUpDown1.Value'ya eşitse, satırı güncelle
                        if (emlakNumarasi == numericUpDown1.Value.ToString())
                        {
                            // AktifMi kısmını false yapma
                            parts[9] = "Aktif Mi=False";
                            // Güncellenmiş satırı oluştur
                            string yeniSatir = string.Join(", ", parts);
                            // Yeni satırı yeniSatirlar listesine ekle
                            yeniSatirlar.Add(yeniSatir);
                            // Emlak numarasının bulunduğunu işaretle
                            emlakNumarasiBulundu = true;
                            MessageBox.Show($"emlak numarası={numericUpDown1.Value.ToString()} olan ev arşivlendi");
                            listView1.Items.Clear();
                            listviewverieklekiralik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt");
                            numericUpDown1.Value = 0;
                        }
                        else
                        {
                            // Emlak numarası eşleşmezse, satırı olduğu gibi yeniSatirlar listesine ekle
                            yeniSatirlar.Add(satir);
                        }
                    }
                    // Eğer belirtilen emlak numarası bulunamazsa, kullanıcıya uyarı ver
                    if (!emlakNumarasiBulundu)
                    {
                        MessageBox.Show("Belirtilen emlak numarası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Yeni satırları dosyaya yaz
                        File.WriteAllLines(satilikdosya, yeniSatirlar);
                    }
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EvSilme evSilme = new EvSilme();
            evSilme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EvDüzenleme evDüzenleme = new EvDüzenleme();
            evDüzenleme.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YeniEvEkleme ekleme = new YeniEvEkleme();
            ekleme.Show();
            this.Hide();
        }
    }
}
