using database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_gramer_otomasyonu
{
    public partial class selftestquiz : Form
    {
        public selftestquiz()
        {
            InitializeComponent();
        }
        public string[] cevaplar = new string[20];//veri tabanında çekilen cevapları tutmak için
        public Class1 class1 = new Class1();//veri tabanı işlemleri
        public int dakikaa = 20;//sınav dakikası
        public int saniyee = 0;//sınav süresi
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sınavınızı bitirmek istediğinize eminmisiniz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//sınavı bitir tuşuna basarba yapılcaklar
            {
                int dogrucevapsayisi = 0;
                int yanliscevapsayisi = 0;
                checksystem(out dogrucevapsayisi,out  yanliscevapsayisi);
                MessageBox.Show("sınavınız bitmiştir seviyeniz bu ekranı kapattıktan sonra sınav sonuçlarınız ile birlikte gösterilecektir.");
                MessageBox.Show(sinav_sonuclari(20, dogrucevapsayisi, yanliscevapsayisi, 20, dakikaa), "Sınac Sonucunuz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Class1 class1 = new Class1();
                if (class1.bilgicek("SELECT * FROM Tek_Kullanimlik", class1.databaseaddress, "ilk_acilis", "gecildi_gecilmedi", "testyourself").ToString().ToLower().Equals("false"))
                    class1.bilgiguncelle("UPDATE Tek_Kullanimlik SET gecildi_gecilmedi = @NewValue WHERE ilk_acilis = @RecordID", class1.databaseaddress, "testyourself", true);//sınav yaptıktan sonra kendini test et öğelerinin tekrar gözükmemesini sağlamak için

            }

        }
        private void selftestquiz_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 20; i++)
            {

            }
            timer1.Start();//sınav süresi başlatıldı
            this.ControlBox = false;//sınav ekranını sadece bitir tuşu ile kapatabilsin diye üstteki işaretler kapandı
            for (int i = 1; i < 21; i++)//pagelere isim vermek için
            {
                TabPage tabPagee = a.TabPages[i - 1];
                tabPagee.Text = "soru " + i;
            }//tabpageslere isim vermek için soru1,soru2 gibi.

            soruyaratici();

            cevapyaratici(200);

        }
        public RadioButton[] labeller = new RadioButton[80];
        public void soruyaratici()
        {
            int sayac = 0;
            OleDbConnection connect = new OleDbConnection(class1.databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();

            command.CommandText = "Select*FROM geneltestsorular";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Label labels = new Label();
                labels.Text = sayac + ")" + reader["soru"].ToString();
                Font LargeFont = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                labels.Font = LargeFont;
                labels.AutoSize = true;
                labels.Location = new Point(150, 90);
                TabPage tabPage = a.TabPages[sayac];
                tabPage.Controls.Add(labels);
                sayac++;

            }
            connect.Close();
        }//soruları oluşturmak için method
        public void cevapyaratici(int x)
        {
            int sayac = 0;
            OleDbConnection connect = new OleDbConnection(class1.databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();

            command.CommandText = "Select*FROM geneltestsorular";
            OleDbDataReader reader = command.ExecuteReader();
            int i = 0;

            while (reader.Read())
            {
                for (int j = 0; j < 1; j++)
                {
                    RadioButton radioButtonn1 = new RadioButton();
                    RadioButton radioButtonn2 = new RadioButton();
                    RadioButton radioButtonn3 = new RadioButton();
                    RadioButton radioButtonn4 = new RadioButton();

                    RadioButton[] radioButtonn5 = { radioButtonn1, radioButtonn2, radioButtonn3, radioButtonn4 };


                    radioButtonn5[j].Text = reader["a"].ToString();
                    radioButtonn5[j + 1].Text = reader["b"].ToString();
                    radioButtonn5[j + 2].Text = reader["c"].ToString();
                    radioButtonn5[j + 3].Text = reader["d"].ToString();
                    TabPage tabPage5 = a.TabPages[sayac];
                    tabPage5.Controls.Add(radioButtonn5[j]);
                    tabPage5.Controls.Add(radioButtonn5[j + 1]);
                    tabPage5.Controls.Add(radioButtonn5[j + 2]);
                    tabPage5.Controls.Add(radioButtonn5[j + 3]);
                    radioButtonn5[j].Location = new Point(x - 15, 140);
                    radioButtonn5[j + 1].Location = new Point(x - 15, 170);
                    radioButtonn5[j + 2].Location = new Point(x - 15, 200);
                    radioButtonn5[j + 3].Location = new Point(x - 15, 230);



                    labeller[i] = radioButtonn5[j];
                    labeller[i + 1] = radioButtonn5[j + 1];
                    labeller[i + 2] = radioButtonn5[j + 2];
                    labeller[i + 3] = radioButtonn5[j + 3];

                }
                if (sayac < 20)
                    sayac++;
                if (i < 76)
                    i += 4;

            }


            connect.Close();
        }//cevapları oluşturmak için method
        private void button2_Click(object sender, EventArgs e)//bir sonraki soruya geçmek için
        {

            if (a.SelectedIndex < a.TabCount - 1)
                a.SelectTab(a.SelectedIndex + 1);
        }

        private void button3_Click(object sender, EventArgs e)//bir önceki soruya geçmek için
        {
            if (a.SelectedIndex > 0)
                a.SelectTab(a.SelectedIndex - 1);

        }

        public string sinav_sonuclari(int  sorusayisi, int  dogru_cevap, int  yanlis_cevap,int sinav_suresi, int sinav_bitirme_suresi)
        {
            int bos_soru = sorusayisi - (dogru_cevap + yanlis_cevap);
            string seviye = " ";

            sinav_bitirme_suresi = sinav_suresi - sinav_bitirme_suresi;
            if (dogru_cevap >= 15 && dogru_cevap <= 20)
                seviye = "B2";
            else if (dogru_cevap >= 10 && dogru_cevap < 15)
                seviye = "B1";
            else if (dogru_cevap >= 5 && dogru_cevap < 10)
                seviye = "A2";
            else
                seviye = "A1";

            
            return "Sınavı süresi : "+sinav_bitirme_suresi+ " dakika\nSınavı bitirme süreniz : " + sinav_bitirme_suresi+" dakika\nSoru Sayısı : "+sorusayisi+"\nDogru sayısı : "+dogru_cevap+"D\nYanlış sayısı :"+yanlis_cevap+"Y\nBoş soru sayısı :"+bos_soru+"\nSınav Sonuçlarına Göre Seviyeniz :"+seviye+"  ";
        }//sınav sonuçlarını yazdırmak için

        public void checksystem(out  int dogrucevapsayisi, out  int yanliscevapsayisi) {
            
             dogrucevapsayisi = 0;
             yanliscevapsayisi = 0;


            try
            {
  OleDbConnection connect = new OleDbConnection(class1.databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();

            command.CommandText = "Select*FROM geneltestsorular";
            OleDbDataReader reader = command.ExecuteReader();
            string[] cevaplar = new string[20];
            int j = 0;
            while (reader.Read()) {

                cevaplar[j] = reader["dogru_cevap"].ToString().Trim().ToLower();
                j++;
            }
            bool cevapdogru = false;
            int sayac = 1;
            for (int i = 0; i < 80; i++)
            {

                if (labeller[i].Checked)
                {


                    for (int k = sayac - 1; k < sayac;)
                    {

                        if (labeller[i].Text.ToLower().Trim() == cevaplar[k])
                        {
                            dogrucevapsayisi++;
                            cevapdogru = true;

                        }

                        k++;
                    }
                    if (!cevapdogru)
                    {
                        yanliscevapsayisi++;
                    }


                }
                cevapdogru = false;

                if ((i + 1) % 4 == 0)
                {
                    sayac++;
                }


            }










            int bos_sorusayisi = 20 - (dogrucevapsayisi + yanliscevapsayisi);
            connect.Close();
            connect.Open();
            command.CommandText = "update quizbilgileri set dogru_sayisi=@dogrusoru , yanlis_sayisi=@yanlissoru,bos_soru=@bos_soru  where sinav_adi=@degisiceksinavdegerleri";
            command.Parameters.AddWithValue("@dogrusoru", dogrucevapsayisi);
            command.Parameters.AddWithValue("@yanlissoru", yanliscevapsayisi);
            command.Parameters.AddWithValue("@bos_soru", bos_sorusayisi);
            command.Parameters.AddWithValue("@degiseceksinavdegerleri", "genel_test");
            command.ExecuteNonQuery();


            connect.Close();
            }
            catch (Exception)
            {

                throw;
            }



          
        }//kullanıcı cevaplarını kontrol etmek için
       
         private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniyee <= 0) { saniyee = 59; dakikaa--; }
            dakika.Text = dakikaa.ToString();
            saniye.Text = saniyee.ToString();
            saniyee--;
            if (dakikaa == 0 && saniyee == 0)
            {
                timer1.Stop();
                MessageBox.Show("sınav süreniz bitmiştir seviyeniz bu ekranı kapattıktan sonra sınav sonuçlarınız ile birlikte gösterilecektir.");
                int dogrucevapsayisi = 0;
                int yanliscevapsayisi = 0;
                checksystem(out dogrucevapsayisi ,out  yanliscevapsayisi);
                MessageBox.Show(sinav_sonuclari(20, dogrucevapsayisi, yanliscevapsayisi,20, 20),"Sınac Sonucunuz",MessageBoxButtons.OK,MessageBoxIcon.Information);
                

            }
        }//sınav süresini kontrol etmek için









      //kullanılmayan kapatılamayan methodlar
 private void selftestquiz_FormClosed(object sender, FormClosedEventArgs e){}
 private void selftestquiz_FormClosing(object sender, FormClosingEventArgs e){ }
 private void tabPage1_Click(object sender, EventArgs e){}
 private void label4_Click(object sender, EventArgs e){ }
 private void tabPage3_Click(object sender, EventArgs e)
        {

        }       
 private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
 private void tabPage2_Click(object sender, EventArgs e)
        {

        }
  private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }       
 private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
