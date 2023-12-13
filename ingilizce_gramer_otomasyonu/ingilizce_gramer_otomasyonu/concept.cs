using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_gramer_otomasyonu
{
    public partial class concept : Form
    {
        public concept()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            subject_selecter open=new subject_selecter();
            this.Visible = false;
            open.ShowDialog();
         
        }

        private void concept_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            giris open = new giris();
            open.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            giris open = new giris();
            open.Visible = true;
        }

        private void concept_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }

        private void concept_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flash_Card open = new Flash_Card();
            open.ShowDialog();
        }
    }
}
