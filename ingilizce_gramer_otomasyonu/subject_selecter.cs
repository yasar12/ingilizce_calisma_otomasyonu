using database;
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
    public partial class subject_selecter : Form
    {
     static bool first_open=false;
        public int sayac=0;//butonları yüklemek için sıra sıra sayaç
         Class1 class1 = new Class1();//database işlemleri için class
         
        public subject_selecter()
        {
            InitializeComponent();
        }

        private void subject_selecter_Load(object sender, EventArgs e)
        {
          string databaseaddres= class1.databaseaddress ;
            
            
            if (class1.bilgicek("SELECT * FROM Tek_Kullanimlik", databaseaddres, "ilk_acilis", "gecildi_gecilmedi", "testyourself").ToString().ToLower().Equals("true"))
            {
                leveltest(false);//eğer program daha önce açılmışsa kendini test etme öğeleri tekrar görüntülenmez.
            }
         button_visible(first_open);
            if (!first_open)
                timer1.Start();
           

            first_open = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                
 sayac += 10;
            switch (sayac)
            {
                case 10:
                    button1.Visible = true;
                        break;
               case 60:
                    button2.Visible = true;
                    break;

                case 110:
                    button3.Visible = true;
                    break;
                case 170:
                    button4.Visible = true;
                    break;
            }
           
               
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        public void leveltest(bool ac_kapa)//kullanıcı test etmek için çıkan button ve resimleri açıp kapamak için method.
        { 
        button5.Visible = ac_kapa;//beyin fotoğrafı
        pictureBox2.Visible = ac_kapa;//konuşma balonu
        label1.Visible = ac_kapa;//konuşma balonu içinde yazan yazı
        }

        private void button5_Click(object sender, EventArgs e)
        {
 selftest openselftest=new selftest();
           //kendini test et butonuna tıklarsa onu açmak için
            this.Visible = false;//bu formu görünmez kılar
           
            openselftest.ShowDialog();
            
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
              concept open=new concept();
         
            open.Visible = true;
            this.Visible = false;

        }

        private void subject_selecter_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
          
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
           A1_konu_anlatımı openA1 = new A1_konu_anlatımı();
            this.Visible = false;
            openA1.ShowDialog();
        }
 
        private void button3_Click(object sender, EventArgs e)
        {
           B1 openb1 = new B1();
            this.Visible = false;
            openb1.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            B2 openb2 = new B2();
            this.Visible = false;
            openb2.ShowDialog();
        }
 
        private void button2_Click(object sender, EventArgs e)
        {
           A2 openA2 = new A2();
            this.Visible = false;
            openA2.ShowDialog();
        }

        private void subject_selecter_Activated(object sender, EventArgs e)
        {
            
            if (class1.bilgicek("SELECT * FROM Tek_Kullanimlik",class1.databaseaddress, "ilk_acilis", "gecildi_gecilmedi", "testyourself").ToString().ToLower().Equals("true"))
            {
                leveltest(false);//eğer program daha önce açılmışsa kendini test etme öğeleri tekrar görüntülenmez.
            }
        }

        public void button_visible(bool ac_kapa)
        {

            button1.Visible = ac_kapa;
            button2.Visible = ac_kapa;
            button3.Visible = ac_kapa;
            button4.Visible = ac_kapa;
        }

        private void subject_selecter_FormClosing(object sender, FormClosingEventArgs e)
        {
            first_open = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
