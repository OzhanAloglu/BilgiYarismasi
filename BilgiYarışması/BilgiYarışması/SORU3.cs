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
    public partial class SORU3 : Form
    {
        public SORU3()
        {
            InitializeComponent();
        }

        int sayac2 = 60;

        private void SORU3_Load(object sender, EventArgs e)
        {
            textBox_soru3.Text = "Guinness Dünya Rekorlarına göre Hintli Karate Nataraj ellerini kullanmadan ağzında kaç tane pipet tutabilmiştir?";
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label3.Text=sayac2.ToString();
            sayac2--;

            if (sayac2==0)
            {
                timer3.Stop();
                MessageBox.Show("Süre bitmiştir elendiniz.");
                label3.Text = 0.ToString();
            }
        }

        private void buttoncevapla3_Click(object sender, EventArgs e)
        {
            if (radio_650.Checked)
            {
                timer3.Stop();
                MessageBox.Show("Tebrikler doğru cevap.");
                

            }
            else
            {
                timer3.Stop();
                MessageBox.Show("Yanlış cevap elendiniz.", "Yanlış", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
    }
}
