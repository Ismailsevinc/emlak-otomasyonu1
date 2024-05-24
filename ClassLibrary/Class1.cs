using System;
using System.IO;
using System.Numerics;

namespace evclass
{

    public enum EvTuru
    {
        Daire,
        Bahceli,
        Dubleks,
        Mustakil
    }
    public class Ev
    {
        private int katnumarasi;
        private string semt;
        private int alani;
        private int yapimtarihi;
        private int emlaknumarasi;
        private bool aktif;
        private int kiradepozito;
        private int kirafiyat;
        private int satilikevfiyat;
        private int yasi;
        private int _odasayisi;
        public EvTuru Turu { get; set; }

        public Ev()
        {
            
        }
        public Ev(int Emlaknumarasi, string Semt, int Katnumarasi, int Alani, int YapimTarihi, int EvYasi, int Odasayisi, bool Aktif, int Kirafiyat, int Kiradepozito,EvTuru turu)
        {
            this.emlaknumarasi = Emlaknumarasi;
            this.Semt = Semt;
            this.alani = Alani;
            this.katnumarasi = Katnumarasi;
            this.yapimtarihi = YapimTarihi;
            this.EvYasi = EvYasi;
            this.Odasayisi = Odasayisi;
            this.aktif = Aktif;
            this.kiradepozito = Kiradepozito;
            this.kirafiyat = Kirafiyat;
            this.Turu = turu;

        }
        public Ev(int Emlaknumarasi, string Semt, int Katnumarasi, int Alani, int YapimTarihi, int EvYasi, int Odasayisi, bool Aktif, int satisfiyati,EvTuru turu)
        {
            this.emlaknumarasi = Emlaknumarasi;
            this.Semt = Semt;
            this.alani = Alani;
            this.katnumarasi = Katnumarasi;
            this.yapimtarihi = YapimTarihi;
            this.EvYasi = EvYasi;
            this.Odasayisi = Odasayisi;
            this.aktif = Aktif;
            this.satilikevfiyat = satisfiyati;
            this.Turu=turu;

        }

        private void LogMesaji(string _logmesaji)
        {
            string logdosyasi = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Log.txt";
            string logMesaji = $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} - {_logmesaji}";

            using (StreamWriter sw = File.AppendText(logdosyasi))
            {
                sw.WriteLine(logMesaji);
            }
        }

        public int Odasayisi
        {
            get { return _odasayisi; }
            set
            {
                if (value < 0)
                {
                    _odasayisi = 0;
                    LogMesaji($"Hatalı giriş girilen negatif değer={value}");
                }
                else
                {
                    _odasayisi = value;
                    LogMesaji($"Doğru giriş girilen pozitif değer={value}");
                }
            }
        }

        public int Katnumarasi
        {
            get { return katnumarasi; }
            set
            {
                katnumarasi = value;
                LogMesaji($"Girilen kat numarası={value}");
            }
        }

        public string Semt
        {
            get { return semt; }
            set
            {
                semt = value;
                LogMesaji($"Girilen semt={value}");
            }
        }

        public int Alani
        {
            get { return alani; }
            set
            {
                alani = value;
                LogMesaji($"Evin Alanı ={value}");
            }
        }

        public int YapimTarihi
        {
            get { return yapimtarihi; }
            set
            {
                yapimtarihi = value;
                LogMesaji($"Ev yapım tarihi={value}");
                EvYasi = 2024 - yapimtarihi;
            }
        }

        public int EvYasi
        {
            get { return yasi; }
            set
            {
                yasi = 2024-yapimtarihi;
                LogMesaji($"Ev Yaşı={yasi}");
            }
        }

        public int Emlaknumarasi
        {
            get { return emlaknumarasi; }
            set
            {
                emlaknumarasi = value;
                LogMesaji($"Emlak numarası={value}");
            }
        }

        public bool Aktif
        {
            get { return aktif; }
            set
            {
                aktif = value;
                LogMesaji($"Emlak aktif durumu={value}");
            }
        }

        public int Kiradepozito
        {
            get { return kiradepozito; }
            set
            {
                kiradepozito = value;
                LogMesaji($"Kira depozito={value}");
            }
        }

        public int Kirafiyat
        {
            get { return kirafiyat; }
            set
            {
                kirafiyat = value;
                LogMesaji($"Kira fiyatı={value}");
            }
        }

        public int Satilikevfiyat
        {
            get { return satilikevfiyat; }
            set
            {
                satilikevfiyat = value;
                LogMesaji($"Satılık ev fiyatı={value}");
            }
        }

        public object Adres { get; set; }

        public virtual string  EvbBilgileri()
        {
            return string.Format(
                "Emlak Numarası: {0}\nSemt: {1}\nKat Numarası: {2}\nAlanı: {3} m2\nYapım Tarihi: {4}\nEv Yaşı: {5}\nOda Sayısı: {6}\nAktif: {7}\nKira Fiyatı: {8} TL\nKira Depozito: {9} TL\nSatılık Ev Fiyatı: {10} TL",
                Emlaknumarasi,
                Semt,
                Katnumarasi,
                Alani,
                YapimTarihi,
                EvYasi,
                Odasayisi,
                Aktif ? "Evet" : "Hayır",
                Kirafiyat,
                Kiradepozito,
                Satilikevfiyat
            );

        }
        public double Fiyathesapla()
        {
            double Katsayi = 200;
            double fiyat=Katsayi*_odasayisi;
            try
            {
                string katsayiyolu = "C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\room_cost.txt";

                
                if (File.Exists(katsayiyolu))
                {

                    string katsayi = File.ReadAllText(katsayiyolu);
                    if (double.TryParse(katsayi, out double dogrukatsayi))
                    {
                        Katsayi = dogrukatsayi;
                        LogMesaji($"Dosyadaki katsayı=  {dogrukatsayi}  , olarak okundu");
                    }
                }
            }
            catch
            {
                LogMesaji($"Dosyadaki katsayı okunamadı otomatik olarak {Katsayi} değeri atandı");
            }
            return fiyat;
        }

        public static Ev FromString(string line)
        {
            throw new NotImplementedException();
        }
    }

    public class Kiralikev:Ev
    {
        public override string EvbBilgileri()
        {
            return string.Format(
                "Emlak Numarası: {0}\nSemt: {1}\nKat Numarası: {2}\nAlanı: {3} m2\nYapım Tarihi: {4}\nEv Yaşı: {5}\nOda Sayısı: {6}\nAktif: {7}\nKira Fiyatı: {8} TL\nKira Depozito: {9} TL\nEv Türü:{10}",
                Emlaknumarasi,
                Semt,
                Katnumarasi,
                Alani,
                YapimTarihi,
                EvYasi,
                Odasayisi,
                Aktif ? "Evet" : "Hayır",
                Kirafiyat,
                Kiradepozito,
                Turu
                
            );

        }
    }

    public class SatilikEv:Ev
    {
        public override string EvbBilgileri()
        {
            return string.Format(
                "Emlak Numarası: {0}\nSemt: {1}\nKat Numarası: {2}\nAlanı: {3} m2\nYapım Tarihi: {4}\nEv Yaşı: {5}\nOda Sayısı: {6}\nAktif: {7}\nSatılık Ev Fiyatı: {8} TL\nEv Türü:{9}",
                Emlaknumarasi,
                Semt,
                Katnumarasi,
                Alani,
                YapimTarihi,
                EvYasi,
                Odasayisi,
                Aktif ? "Evet" : "Hayır",
                Satilikevfiyat,
                Turu
            );

        }
    }
}
