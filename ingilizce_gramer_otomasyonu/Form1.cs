using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_gramer_otomasyonu
{
    public partial class giris : Form
    {
        int timer0=0;
       
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }
        concept open = new concept();
        private void timer1_Tick(object sender, EventArgs e)
        { 
             timer0+=40;
            pictureBox1.Size = new Size(1007-timer0,613-timer0);
            if (timer0>1013)
            {
                timer1.Stop();
                button1.Visible = false;
              
               
           
          
               this.Hide();
                open.ShowDialog();
                 
               
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLoginPanel open=new AdminLoginPanel();
            this.Visible = false;
            open.ShowDialog();
            
          
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        int zaman = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 1;
            progressBar1.Value = zaman;
            zaman++;
            if (zaman>100)
            {
                timer2.Stop();
                timer1.Start();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
