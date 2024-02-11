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
    public partial class A2 : Form
    {
        public A2()
        {
            InitializeComponent();
        }

        private void label104_Click(object sender, EventArgs e)
        {

        }

        private void label105_Click(object sender, EventArgs e)
        {

        }
    
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        subject_selecter open = new subject_selecter();
            open.Visible = true;
            this.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
