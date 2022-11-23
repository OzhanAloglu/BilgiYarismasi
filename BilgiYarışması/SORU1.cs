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
    public partial class SORU1 : Form
    {
        public SORU1()
        {
            InitializeComponent();
        }

        int saniye = 60;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radio_önsöz.Checked)
            {
                MessageBox.Show("Doğru");
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Yanlış elendiniz.");
                
                Application.Exit();
                
            }
        }

        private void SORU1_Load(object sender, EventArgs e)
        {
            
            timer1.Interval = 1000;
            timer1.Enabled = true;

            txt_soru1.Text = "İbn Haldun'un bir eserinin adı da olan mukaddime kelimesi ne anlama gelir?";

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label1.Text = saniye.ToString();
            saniye--;
            if (saniye==-1)
            {
                timer1.Stop();
                MessageBox.Show("Süreniz sona ermiştir.");
                label1.Text = 0.ToString();
                
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (radio_önsöz.Checked)
            {

                MessageBox.Show("Tebrikler Doğru cevap.");
                this.Hide();
                SORU2 frm2 = new SORU2();
                frm2.ShowDialog();
                

            }

            
            

        }
    }
}
