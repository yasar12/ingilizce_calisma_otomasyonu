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
    public partial class A1Test : Form
    {
        public A1Test()
        {
            InitializeComponent();
        }
        public string seviye = "A1";//bir önceki formdan ayarlanan seviye bu seviyeye göre sorular rastgele seçilir.
        public int[] secilensorunumalari = new int[10];
        Class1 veritabani=new Class1();
        public  RadioButton[] radioButtonn1 =new RadioButton[40];//cevap radio buttonları
        private void A1Test_Load(object sender, EventArgs e)//form yüklenirken seçtiğimiz seviyeye göre bize soruları rastgele şekilde veri tabanından çeker radiobutton ve soruların yazıları cevapların yazıları bu kısımda manuel olarak oluşturulmuştur
        {
            ArrayList sorular=new ArrayList();
            ArrayList cevaplar=new ArrayList();
            try
            {
  veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "select Soru from Seviye_Testleri where Soru_Seviyesi=@seviye";
            veritabani.cmd.Parameters.AddWithValue("@seviye", seviye);
            sorular = veritabani.veri_cek();
            
            veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "select a,b,c,d from Seviye_Testleri where Soru_Seviyesi=@seviye";
            veritabani.cmd.Parameters.AddWithValue("@seviye", seviye);
            cevaplar = veritabani.veri_cek2();
            }
            catch (Exception)
            {

                MessageBox.Show("Sınav oluşturulamadı lütfen sınava tekrardan giriş yapınız","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
          
          
            Random rnd=new Random();
           
            secilensorunumalari[9] = 77;
            for (int i = 0; i < 10; i++)
            {           
                
                TabPage myTabPage = new TabPage("Soru-"+(tabControl1.TabCount + 1).ToString());
                tabControl1.TabPages.Add(myTabPage);
                Label labels = new Label();
               int randomsoru= rnd.Next(-1, sorular.Count);

                do
                {
                    randomsoru= rnd.Next(0, sorular.Count);
                }
                while (secilensorunumalari.Contains(randomsoru));

              ;
                secilensorunumalari[i] = randomsoru;
                labels.Text = sorular[secilensorunumalari[i]].ToString();                              
                Font LargeFont = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                labels.Font = LargeFont;
                labels.AutoSize = true;
                labels.Location = new Point(150, 90);
                TabPage tabPage = tabControl1.TabPages[i];
                tabPage.Controls.Add(labels);
             
            }
            int x = 200;
            int y = 200;
           
            for (int i = 0; i < 10; i++)
            {
              
                radioButtonn1[i * 4] = new RadioButton();
                radioButtonn1[i * 4+1] = new RadioButton();
                radioButtonn1[i * 4+2] = new RadioButton();
                radioButtonn1[i * 4+3] = new RadioButton();
               
             
                radioButtonn1[i*4].Text = cevaplar[(secilensorunumalari[i] * 4) + 0].ToString();
                radioButtonn1[i*4+1].Text = cevaplar[(secilensorunumalari[i] * 4) + 1].ToString();
                radioButtonn1[i*4+2].Text = cevaplar[(secilensorunumalari[i] * 4 )+ 2].ToString();
                radioButtonn1[i*4+3].Text = cevaplar[(secilensorunumalari[i] * 4) + 3].ToString();

                TabPage tabPage5 = tabControl1.TabPages[i];
                tabPage5.Controls.Add(radioButtonn1[i * 4]);
                tabPage5.Controls.Add(radioButtonn1[i * 4 + 1]);
                tabPage5.Controls.Add(radioButtonn1[i * 4 + 2]);
                tabPage5.Controls.Add(radioButtonn1[i * 4 + 3]);
                radioButtonn1[i * 4].Location = new Point(x - 15, y);
                radioButtonn1[i * 4 + 1].Location = new Point(x - 15, y+30);
                radioButtonn1[i * 4 + 2].Location = new Point(x - 15, y+60);
                radioButtonn1[i * 4 + 3].Location = new Point(x - 15,y+90);


            }
         
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        { 
           

       

            
        }
        double dakikaa = 14;
        double saniyee = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (saniyee <= 0) { saniyee = 59; dakikaa--; }
            dakika.Text = dakikaa.ToString();
            saniye.Text = saniyee.ToString();
            saniyee--;
            if (dakikaa == 0 && saniyee == 0)
            {
                timer1.Stop();
                MessageBox.Show("sınav süreniz bitmiştir bu ekranı kapattıktan sonra sınav sonuçlarınız gösterilecektir.");
                CheckSystem();
                SinavSonuclari();
                this.Close();
            }
        }

        int dogruSayisi = 0;
        int yanlisSayisi = 0;
        int bosSayisi = 0;
        public void CheckSystem() 
        {
            ArrayList dogruCevaplar=new ArrayList();
            try
            {
 veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "select cevap from Seviye_Testleri where Soru_Seviyesi=@seviye";
            veritabani.cmd.Parameters.AddWithValue("@seviye", seviye);
           dogruCevaplar = veritabani.veri_cek();
            }
            catch (Exception)
            {

                MessageBox.Show("Sorular belirlenirken bir hata oluştu lütfen tekrar sınava giriş yapınız.");
            }
           
            int sayac = 0;
          
            for (int i = 0; i <40; i++)
            {
                if (radioButtonn1[i].Checked)
                {
                    if (radioButtonn1[i].Text.ToLower().Trim() == dogruCevaplar[secilensorunumalari[sayac]].ToString().ToLower().Trim())
                    {
                     dogruSayisi++;
                    }
                    else
                    {
                        yanlisSayisi++;
                    }
                    
                }

                if ((i + 1) % 4 == 0)
                {
                    sayac++;
                }
            }
            bosSayisi = 10 -( yanlisSayisi + dogruSayisi);

            try
            {
            veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "UPDATE quizbilgileri SET sure=@sinav_suresii ,dogru_sayisi=@dogru_sayisii,yanlis_sayisi=@yanlis_sayisii,bos_soru=@bos_soruu,sinav_bitirme_suresi=@sinav_bitirme_suresii  where sinav_adi=@sinav_adii";
            
            veritabani.cmd.Parameters.AddWithValue("@sinav_suresii", 15);
            veritabani.cmd.Parameters.AddWithValue("@dogru_sayisii", dogruSayisi);
            veritabani.cmd.Parameters.AddWithValue("@yanlis_sayisii", yanlisSayisi);
            veritabani.cmd.Parameters.AddWithValue("@bos_soruu", bosSayisi);
            veritabani.cmd.Parameters.AddWithValue("@sinav_bitirme_suresii", (double)(15-dakikaa+saniyee*0.1));
            veritabani.cmd.Parameters.AddWithValue("@sinav_adii", seviye);
            veritabani.bilgiyaz();
            }
            catch (Exception)
            {

                MessageBox.Show("Sınav bilgileri gönderilemedi sınav geçersiz.");
            }
          
        }//doğru cevapları kontrol etmeye yarıyan methot

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)//sonraki soruya geçmemizi sağlayan sonraki butonu
        {
            if (tabControl1.SelectedIndex < tabControl1.TabCount - 1)
                tabControl1.SelectTab(tabControl1.SelectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)// bir önceki soruya geçmemizi sağlayan önceki butonu
        {
            if (tabControl1.SelectedIndex > 0)
                tabControl1.SelectTab(tabControl1.SelectedIndex - 1);

        }

        private void button2_Click(object sender, EventArgs e)//sınavı bitirme butonu
        {
            DialogResult cevap = new DialogResult();
            cevap = MessageBox.Show("Sınavı bitirmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);

            if (cevap==DialogResult.Yes)
            {
                timer1.Stop();
            CheckSystem();
            SinavSonuclari();
                all_exams open=new all_exams();
                open.Visible = true;
                this.Visible = false;
               
            }
            else if (cevap==DialogResult.No)
            {
            
            }
            
            
        }
        public void SinavSonuclari() //sınav sonuçlarını messagebox ile göstermeye yarayan method
        {
            MessageBox.Show("Sınav sonuçlarınız\nDogru Sayısı: " + dogruSayisi + "\nYanlış Sayısı: " + yanlisSayisi + "\nBoş Sayısı: " + bosSayisi + " ","Sınav Sonuçları",MessageBoxButtons.OK);
        }

        private void button4_Click(object sender, EventArgs e)//sağ üstteki exit tuşudur.
        {
            DialogResult dialogResult = new DialogResult();
          dialogResult=  MessageBox.Show("Şuanda çıkış yaparsanız sınav ilerleminiz silinecektir.","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
