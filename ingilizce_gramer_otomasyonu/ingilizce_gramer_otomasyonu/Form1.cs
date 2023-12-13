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
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
             timer0+=40;
            pictureBox1.Size = new Size(1007-timer0,613-timer0);
            if (timer0>1013)
            {
                timer1.Stop();
                button1.Visible = false;
                comboBox1.Visible = false;
               
         concept open = new concept();
          
               this.Hide();
                open.ShowDialog();
                 
               
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
