using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması
{
    public partial class SORU2 : Form
    {
        public SORU2()
        {
            InitializeComponent();
        }
        int sayac = 60;

        private void SORU2_Load(object sender, EventArgs e)
        {
            txt_soru2.Text = "Nobel ödüllü yazar Tagore'un, hikayesi 19. yüzyılda Birleşik Krallık yönetimindeki Hindistan'ın Kalküta şehrinde geçen ve başkarakteriyle aynı adı taşıyan romanının adı nedir?";

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = sayac.ToString();
            sayac--;

            if (sayac==0)
            {
                timer2.Stop();
                MessageBox.Show("Süreniz bitmiştir elendiniz.");
                label2.Text = 0.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_gora.Checked)
            {
                MessageBox.Show("Doğru","Tebrikler.",MessageBoxButtons.OK);
                timer2.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış elendiniz!!","Elendin",MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radio_gora.Checked)
            {
                this.Hide();
                SORU3 frm3 = new SORU3();
                frm3.ShowDialog();

            }
        }
    }
}
