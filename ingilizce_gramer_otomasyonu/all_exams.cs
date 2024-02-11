using database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace ingilizce_gramer_otomasyonu
{
    public partial class all_exams : Form
    {
        public all_exams()
        {
            InitializeComponent();
        }

        private void all_exams_Load(object sender, EventArgs e)
        {
           
        }


        

        private void all_exams_FormClosed(object sender, FormClosedEventArgs e)
        {
      
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Seviye_Belirleyici("A1");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seviye_Belirleyici("A2");
        }

        public void Seviye_Belirleyici(string seviye) {
         DialogResult cevap=new DialogResult();
            cevap=MessageBox.Show("Sınavı Başlat\nSoru Sayısı: 10\nSüre:15 dakika","warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (cevap==DialogResult.Yes)
            {
            A1Test a1Test = new A1Test();
                a1Test.seviye =seviye;
                this.Close();
                 a1Test.ShowDialog();
            }
        }//buton ile seçilen seviyeye göre sorular getiren method

        private void button2_Click(object sender, EventArgs e)
        {
            Seviye_Belirleyici("B1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seviye_Belirleyici("B2");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            concept open = new concept();
        
    open.Visible = true;
    this.Close();
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
            Class1 veritabani=new Class1();
            veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = "select * from quizbilgileri";
           ArrayList sinav_sonuclari = veritabani.veri_cek2();
            for (int i = 0; i < sinav_sonuclari.Count; i+=7)
            {
                MessageBox.Show("Sınav Derecesi:" + sinav_sonuclari[i] +" \nSoru Sayısı: " + sinav_sonuclari[i+1] + "\nDogru Sayısı: " + sinav_sonuclari[i+2] + "\nYanlış sayısı: " + sinav_sonuclari[i+3] + "\nBoş Sayısı: " + sinav_sonuclari[i+4] + "\nSınavı Bitirme Süresi: " + sinav_sonuclari[i+5]+"dk" + " \nSınav Süresi: " + sinav_sonuclari[i+6] + "dk" + " ","En Son Girilen Sınav Sonuçları",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            }
            catch (Exception)
            {

                MessageBox.Show("Sonuçlar gösterilirken bir hata meydana geldi lütfen tekrar deneyiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
         

        }//En son girdiğimiz sınav sonuçlarını bize gösteren method

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
