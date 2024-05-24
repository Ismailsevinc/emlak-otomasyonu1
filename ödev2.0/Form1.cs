using System.IO;
namespace ödev2._0
    
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;
            if (kontrol(kullaniciadi, sifre))
            {
                Main main = new Main();
                main.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                textBox1.Clear();
                textBox2.Clear();
            }
        }
        public bool kontrol(string kullaniciadi, string sifre)
        {
            string[] users = File.ReadAllLines("C:\\Users\\ismai\\OneDrive\\Masaüstü\\ödev2\\ödev2\\ClassLibrary\\Users.txt");
            foreach (var user in users)
            {
                //vigülle ayırıp oku
                string[] parts = user.Split(',');
                string _kullaniciadi = parts[0].Trim();
                string _sifre = parts[1].Trim();
                if (_kullaniciadi == kullaniciadi && _sifre == sifre)
                {
                    return true;
                }

            }
            return false;

        }
    }
}
