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
    public partial class selftest : Form
    {
        public selftest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selftestquiz selftestquiz = new selftestquiz();
            
            this.Close();
            this.Visible = false;
            selftestquiz.ShowDialog();           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {subject_selecter open = new subject_selecter();
            
            open.Visible = true;
            this.Visible = false;
        }

        private void selftest_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }

        private void selftest_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
  selftestquiz selftestquiz = new selftestquiz();
        private void button5_Click(object sender, EventArgs e)
        {
          

            this.Close();
            this.Visible = false;
            selftestquiz.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
