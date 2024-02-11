using database;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;

namespace ingilizce_gramer_otomasyonu
{
    public partial class Flash_Card : Form
    {
        Class1 veritabani=new Class1();
       public ArrayList word;
       public ArrayList meaning;
       public ArrayList meaning2;
        public Random rastgeleSoru=new Random();
        public string cevap;
        public string cevap2;
        public bool cevapVerildimi;
        public bool cevapGosterme;
     public   ArrayList bilinemeyen_Kelimeler=new ArrayList();
        public bool bilinmeyen_kelime;
        public Flash_Card()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!cevapVerildimi&&button5.Text!="")
            {
                if(!cevapGosterme)
                cevapVerildimi = true;
        
 
               if ((cevap.ToLower().Equals(textBox1.Text.Trim().Replace(" ","").ToLower())|| cevap2.ToLower().Equals(textBox1.Text.Trim().Replace(" ", "").ToLower()) )&& !cevapGosterme)
                {
                    if (bilinmeyen_kelime)
                    {
                        bilinmeyen_kelime = false;
                        try
                        {
                         veritabani.cmd.CommandText=veritabani.komut = "delete from bilinmeyen_kelimeler where kelime=@kelimee";
                        veritabani.cmd.Parameters.AddWithValue("@kelimee",button5.Text);
                        veritabani.bilgisil();
                        veritabani.cmd.CommandText = veritabani.komut = "select kelime,anlami,ikinci_anlami from Bilinmeyen_Kelimeler";
                        bilinemeyen_Kelimeler = veritabani.veri_cek();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Bir hata meydana geldi.");
                        }
                       
                    }                   
                MessageBox.Show("doğru cevap");
                    if (cevap!=cevap2)
                    {
                    button2.Text = cevap+","+cevap2;
                    }
                    else
                    {
                        button2.Text = cevap;
                    }              
                    KartDondurmeSesi();
               }
              else if(!cevapGosterme&& !cevap.ToLower().Equals(textBox1.Text.Trim().Replace(" ", "").ToLower()))
              {
                    veritabani.komut = "select *from Bilinmeyen_Kelimeler where kelime='"+button5.Text+"'";
                    if (veritabani.bilgicekme()=="")
                    {
                        try
                        {
                        veritabani.conn.Close();
                        veritabani.komut = "Insert into Bilinmeyen_Kelimeler (kelime,anlami) Values (@kelimee,@anlamii)";
                    veritabani.cmd = new OleDbCommand(veritabani.komut);                   
                    veritabani.cmd.Parameters.AddWithValue("@kelimee", button5.Text);
                    veritabani.cmd.Parameters.AddWithValue("@anlamii",cevap.ToString());
                    veritabani.bilgiyaz();
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Bir hata meydana geldi");
                        }
                       
                    }
                   
                    MessageBox.Show("yanlış cevap");
                    KartDondurmeSesi();
                    button2.Text = cevap;
                    
                   
               
              }
              else if(cevapGosterme==true)
              {
                   MessageBox.Show("Kelimenin anlamı zaten görüntülendi lütfen tekrar kart çekin");
              }
              }
            else
            {
                MessageBox.Show("Bu soruya zaten cevap verdiniz veya henüz herhangi bir kart çekilmedi");
            }
            
           
            
        }//bu kısımda cevabın doğruluğu kontrol edilir eğer zaten cevap göster denilmişse bize uyarı verir eğer yanlış cevap verirsek o kelimeyi bilinememiş kelimeler listesine ekler.

        private void Flash_Card_Load(object sender, EventArgs e)
        {
            Bilinemeyen_Kelimeleri_yenileme();
            Kelime_Listesini_Yenileme();
             button2.Enabled = false;
            button5.Enabled = false;
           
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cevapGosterme = false;

            Soru_Degistirici();
          cevapVerildimi=false;
            
        }

        public void Soru_Degistirici()
        {
            button2.Text = "?";
            int rastgeleSoruNumarasi=rastgeleSoru.Next(0,word.Count-1);
            button5.Text = word[rastgeleSoruNumarasi].ToString();
            cevap = meaning[rastgeleSoruNumarasi].ToString();
            if (cevap2 != "")
            {
                cevap2 = meaning2[rastgeleSoruNumarasi].ToString();
            }
            else
            {
                cevap2 = meaning[rastgeleSoruNumarasi].ToString();
            }

         
        }//bir sonraki kelimeyi getirmeyi sağlayan method
        public void KartDondurmeSesi() {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "fds";
            player.Play();
        }

        public void Bilinemeyen_Kelimeleri_yenileme()
        {
            if (bilinemeyen_Kelimeler != null)
            {
                bilinemeyen_Kelimeler.Clear();
            }
            
            veritabani.cmd.CommandText = veritabani.komut = "select kelime,anlami,ikinci_anlami from Bilinmeyen_Kelimeler";
            bilinemeyen_Kelimeler = veritabani.veri_cek();
         
          
        }

        public void Kelime_Listesini_Yenileme() 
        {
            if (word!=null||meaning!=null||meaning2!=null)
            {
            word.Clear();
            meaning.Clear();
            meaning2.Clear();
            }
            
            Class1 class1 = new Class1();
            class1.bilgicek("Select *From flash_card_kelimeler", class1.databaseaddress, "kelime", "anlami", "ikinci_anlami", out word, out meaning, out meaning2);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            if (!cevapGosterme)
            {
                
            KartDondurmeSesi();
            button2.Text = cevap;
            } 
            cevapGosterme = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            bilinmeyen_kelime=true;
            button2.Text = "?";
            int rastgeleSoruNumarasi = rastgeleSoru.Next(0, bilinemeyen_Kelimeler.Count - 1);
            string[]kelimeVeAnlami= bilinemeyen_Kelimeler[rastgeleSoruNumarasi].ToString().Split(' ');
            if (kelimeVeAnlami.Length>1)
            {
           if (kelimeVeAnlami[2]!="")
            {
             cevap2 = kelimeVeAnlami[2];
            }
            else
            {
                cevap2 = kelimeVeAnlami[1];
            }
            } 
            
           button5.Text = kelimeVeAnlami[0];
            cevap = kelimeVeAnlami[1];
           

        }//sağ altta bulunan bilinememiş kelimeler tuşuna basınca daha önce bilemediğimiz bir kelimeyi bizim önümüze çıkarır.

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Flash_Card_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            concept open = new concept();
            open.Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kelime_Listesini_Yenileme();
            Bilinemeyen_Kelimeleri_yenileme();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
