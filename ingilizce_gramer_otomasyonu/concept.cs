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
            
           subject_selecter opensb=new subject_selecter();
            this.Visible = false;
            opensb.ShowDialog();
         
        }

        private void concept_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
          giris open= new giris();
            this.Visible = false;
        
            open.Visible = true;
        }
  
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giris open = new giris();
            this.Visible = false;
          
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
           
             Flash_Card opencard = new Flash_Card();
            this.Visible = false;
            
            opencard.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            all_exams openallexam=new all_exams();
            this.Visible=false;
            openallexam.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
