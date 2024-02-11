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
    public partial class A1_konu_anlatımı : Form
    {
        public A1_konu_anlatımı()
        {
            InitializeComponent();
        }

        private void splitContainer3_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            subject_selecter open = new subject_selecter();
           
            open.Visible = true;
            this.Visible = false;
        }

        private void A1_konu_anlatımı_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void A1_konu_anlatımı_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
