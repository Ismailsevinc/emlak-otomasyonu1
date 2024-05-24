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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using evclass;

namespace ödev2._0
{
    public partial class EvSilme : Form
    {
        private Dictionary<string, List<string>> sehirVeSemtler;
        public EvSilme()
        {
            InitializeComponent();
        }

        private void EvSilme_Load(object sender, EventArgs e)
        {
            listView1.MouseClick += listView1_MouseClick;
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

        private void radioButtonkiralik_CheckedChanged(object sender, EventArgs e)
        {
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listviewverieklekiralik(string dosyayolu)
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
            if (radioButtonkiralik.Checked)
            {
                listView1.Items.Clear();
                listviewverieklekiralik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt");
            }
            else if (radioButtonsatilik.Checked)
            {
                listView1.Items.Clear();
                listviewverieklesatilik("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt");
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem secilenSatir = listView1.SelectedItems[0];

                DialogResult dialogResult = MessageBox.Show("Seçili Ev kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Seçilen satırı listView1'den kaldırdım
                    listView1.Items.Remove(secilenSatir);

                    // Silinen satırın emlak numarasını aldım
                    string emlakNumarasi = secilenSatir.Text;

                    // Dosya türüne göre dosya yolunu belirtin (Kiralık veya Satılık dosyası)
                    string dosyaYolu = radioButtonkiralik.Checked ? "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt" : "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt";

                    // Ev silme işlevini çağırın
                    EvSil(emlakNumarasi, dosyaYolu);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string emlakNumarasi = numericUpDown1.Value.ToString();
            if (radioButtonkiralik.Checked)
            {
                // Silinecek evin dosya yolunu belirttim
                string dosyaYolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt"; 
                EvSil(emlakNumarasi, dosyaYolu);
            }
            else if (radioButtonsatilik.Checked)
            {
                string dosyaYolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt";
                EvSil(emlakNumarasi, dosyaYolu);
            }
           
        }

        private void GüncelleDosya(string emlakNumarasi, string yeniDurum, string dosyaTipi)
        {
            string dosyaYolu = $"C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\{dosyaTipi}.txt";

            try
            {
                List<string> lines = new List<string>(File.ReadAllLines(dosyaYolu));

                for (int i = 0; i < lines.Count; i++)
                {
                    if (lines[i].Contains($"emlak numarasi={emlakNumarasi},"))
                    {
                        string[] parts = lines[i].Split(new[] { ", " }, StringSplitOptions.None);
                        parts[9] = $"Aktif Mi={yeniDurum}";
                        lines[i] = string.Join(", ", parts);
                        break;
                    }
                }

                File.WriteAllLines(dosyaYolu, lines);
                Console.WriteLine("Satır başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main geri = new Main();
            geri.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
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

                string dosyaYolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Kiralik.txt";
                string girilenEmlakNumarasi = numericUpDown1.Value.ToString(); // Emlak numarasını girilen TextBox
                string yeniIl = comboBox1.Text;
                string yeniIlce = comboBox2.Text;
                string yeniMahalle = textBox1.Text;
                string yeniKatNumarasi = numericUpDownkatnumarasi.Value.ToString();
                string yeniAlani = numericUpDownalan.Value.ToString();
                string yeniYapimTarihi = textBox4.Text;
                string yeniEvYasi = (2024 - Convert.ToInt32(yeniYapimTarihi)).ToString();
                string yeniOdaSayisi = numericUpDown2.Value.ToString();
                string yeniAktifMi = comboBoxaktifmi.Text;
                string yeniKiraFiyati = textBoxkira.Text;
                string yeniKiraDepozitoFiyati = textBoxkiradepoz.Text;
                string yeniEvTuru = comboBoxturu.Text;

                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines(dosyaYolu));
                    bool bulundu = false;

                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (lines[i].StartsWith($"emlak numarasi={girilenEmlakNumarasi},"))
                        {
                            string[] parts = lines[i].Split(new[] { ", " }, StringSplitOptions.None);

                            parts[1] = $"il={yeniIl}";
                            parts[2] = $"ilçe={yeniIlce}";
                            parts[3] = $"mahalle={yeniMahalle}";
                            parts[4] = $"Kat Numarası={yeniKatNumarasi}";
                            parts[5] = $"Alanı={yeniAlani}";
                            parts[6] = $"Yapım Tarihi={yeniYapimTarihi}";
                            parts[7] = $"Ev Yaşı={yeniEvYasi}";
                            parts[8] = $"Oda Sayısı={yeniOdaSayisi}";
                            parts[9] = $"Aktif Mi={yeniAktifMi}";
                            parts[10] = $"Kira Fiyatı={yeniKiraFiyati}";
                            parts[11] = $"Kira Depozito Fiyatı={yeniKiraDepozitoFiyati}";
                            parts[12] = $"Ev Türü={yeniEvTuru}";

                            lines[i] = string.Join(", ", parts);
                            bulundu = true;
                            break;
                        }
                    }

                    if (bulundu)
                    {
                        File.WriteAllLines(dosyaYolu, lines);
                        MessageBox.Show("Emlak kaydı başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Girilen emlak numarasına sahip kayıt bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            if (radioButtonsatilik.Checked)
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
                string dosyaYolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Satilik.txt";
                string girilenEmlakNumarasi = numericUpDown1.Value.ToString(); // Emlak numarasını girilen TextBox
                string yeniIl = comboBox1.Text;
                string yeniIlce = comboBox2.Text;
                string yeniMahalle = textBox1.Text;
                string yeniKatNumarasi = numericUpDownkatnumarasi.Value.ToString();
                string yeniAlani = numericUpDownalan.Value.ToString();
                string yeniYapimTarihi = textBox4.Text;
                string yeniEvYasi = (2024 - Convert.ToInt32(yeniYapimTarihi)).ToString();
                string yeniOdaSayisi = numericUpDown2.Value.ToString();
                string yeniAktifMi = comboBoxaktifmi.Text;
                string satilikevfiyat = textBoxsatis.Text;
                string yeniEvTuru = comboBoxturu.Text;

                try
                {
                    List<string> lines = new List<string>(File.ReadAllLines(dosyaYolu));
                    bool bulundu = false;

                    for (int i = 0; i < lines.Count; i++)
                    {
                        if (lines[i].StartsWith($"emlak numarasi={girilenEmlakNumarasi},"))
                        {
                            string[] parts = lines[i].Split(new[] { ", " }, StringSplitOptions.None);

                            parts[1] = $"il={yeniIl}";
                            parts[2] = $"ilçe={yeniIlce}";
                            parts[3] = $"mahalle={yeniMahalle}";
                            parts[4] = $"Kat Numarası={yeniKatNumarasi}";
                            parts[5] = $"Alanı={yeniAlani}";
                            parts[6] = $"Yapım Tarihi={yeniYapimTarihi}";
                            parts[7] = $"Ev Yaşı={yeniEvYasi}";
                            parts[8] = $"Oda Sayısı={yeniOdaSayisi}";
                            parts[9] = $"Aktif Mi={yeniAktifMi}";
                            parts[10] = $"Satılık Ev Fiyatı={satilikevfiyat}";
                            parts[11] = $"Ev Türü={yeniEvTuru}";

                            lines[i] = string.Join(", ", parts);
                            bulundu = true;
                            break;
                        }
                    }

                    if (bulundu)
                    {
                        File.WriteAllLines(dosyaYolu, lines);
                        MessageBox.Show("Emlak kaydı başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Girilen emlak numarasına sahip kayıt bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
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
        private void EvSil(string emlakNumarasi, string dosyaYolu)
        {
            try
            {
                List<string> satirlar = new List<string>(File.ReadAllLines(dosyaYolu));

                for (int i = 0; i < satirlar.Count; i++)
                {
                    if (satirlar[i].StartsWith($"emlak numarasi={emlakNumarasi},"))
                    {
                        satirlar.RemoveAt(i);
                        break;
                    }
                }

                File.WriteAllLines(dosyaYolu, satirlar);
                MessageBox.Show("Ev başarıyla silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

    }

}

