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
    public partial class EvDüzenleme : Form
    {
        public EvDüzenleme()
        {
            InitializeComponent();
        }

        private void EvDüzenleme_Load(object sender, EventArgs e)
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
        private void radioButtonkiralik_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Columns.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Emlak Numarası", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("İl", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("İlçe", 90, HorizontalAlignment.Left);
            listView1.Columns.Add("Mahalle", 90, HorizontalAlignment.Left);
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main geri = new Main();
            geri.Show();
            this.Hide();
        }
    }
}
