using System.Text;
//Serra Güney OkulNo:221030910018
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
                MessageBox.Show("aradýðýnýz kelime mevcut ve konumu ilk metin");
            }
            else if (txtMetin.Text.IndexOf(txtYardimci.Text) == -1)
            {
                MessageBox.Show("aradýðýnýz kelime mevcut deðil");
            }
            else
            {
                MessageBox.Show("aradýðýnýz kelime mevcut.Konumu=" + txtMetin.Text.IndexOf(txtYardimci.Text));
            }
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
        private void btnBirlestirme_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(txtMetin.Text);
            sb.Append(txtYardimci.Text);
            MessageBox.Show("metinler birleþtirildi." + " " + sb);
            txtMetin.Text = " ";
            txtYardimci.Text = " ";
        }
        private void btnDegiþtirme_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(txtMetin.Text);
            sb.Replace(txtMetin.Text, txtYardimci.Text);
            MessageBox.Show("metinler deðiþtirildi." + " " + sb);
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
