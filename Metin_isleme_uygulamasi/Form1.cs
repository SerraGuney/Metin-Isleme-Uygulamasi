using System.Text;
//Serra G�ney OkulNo:221030910018
namespace Metin_isleme_uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnArama_Click(object sender, EventArgs e)
        {
            string metin = txtMetin.Text;
            string arananKelime = txtYardimci.Text;
            if (txtMetin.Text.IndexOf(txtYardimci.Text) == 0)
            {
                MessageBox.Show("arad���n�z kelime mevcut ve konumu ilk metin");
            }
            else if (txtMetin.Text.IndexOf(txtYardimci.Text) == -1)
            {
                MessageBox.Show("arad���n�z kelime mevcut de�il");
            }
            else
            {
                MessageBox.Show("arad���n�z kelime mevcut.Konumu=" + txtMetin.Text.IndexOf(txtYardimci.Text));
            }
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
        private void btnBirlestirme_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(txtMetin.Text);
            sb.Append(txtYardimci.Text);
            MessageBox.Show("metinler birle�tirildi." + " " + sb);
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
        private void btnDegi�tirme_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(txtMetin.Text);
            sb.Replace(txtMetin.Text, txtYardimci.Text);
            MessageBox.Show("metinler de�i�tirildi." + " " + sb);
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
        private void btnSilme_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(txtMetin.Text);
            sb.Remove(1, 5);
            MessageBox.Show("metinler silindi." + " " + sb);
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
    }
}
