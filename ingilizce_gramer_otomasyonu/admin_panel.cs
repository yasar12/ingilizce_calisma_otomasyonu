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
using database;
using System.Collections;

namespace ingilizce_gramer_otomasyonu
{
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }
        Class1 veritabani=new Class1();
        private void button2_Click(object sender, EventArgs e)//soru ekleme butonu
        {
            if (soru.Text != null && cevapA.Text != null && cevapB.Text != null && cevapC.Text != null && cevapD.Text != null && dogruCevap.Text != null && soruSeviyesi.Text!= null)
            {
                try
                {
                veritabani.cmd = new OleDbCommand();
                veritabani.cmd.CommandText = veritabani.komut= "insert into Seviye_Testleri  (soru,a,b,c,d,cevap,Soru_Seviyesi) values(@soruu,@cevapa,@cevapb,@cevapc,@cevapd,@cevapp,@seviye)";
                veritabani.cmd.Parameters.AddWithValue("@soruu", soru.Text);
                veritabani.cmd.Parameters.AddWithValue("@cevapa", cevapA.Text);
                veritabani.cmd.Parameters.AddWithValue("@cevapb", cevapB.Text);
                veritabani.cmd.Parameters.AddWithValue("@cevapc", cevapC.Text);
                veritabani.cmd.Parameters.AddWithValue("@cevapd", cevapD.Text);
                veritabani.cmd.Parameters.AddWithValue("@cevapp", dogruCevap.Text);
                veritabani.cmd.Parameters.AddWithValue("@seviye", soruSeviyesi.Text);
                veritabani.bilgiyaz();
                }
                catch (Exception)
                {

                    MessageBox.Show("Soru eklenemedi");
                }
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            giris open=new giris();
            open.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)//kelime ekleme butonu
        {
            ArrayList arrayList=new ArrayList();
            try
            {
            veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "select kelime from flash_card_kelimeler where kelime=@kelimee";
            veritabani.cmd.Parameters.AddWithValue("@kelimee", kelime.Text);
           arrayList = veritabani.veri_cek();
            }
            catch (Exception)
            {

                MessageBox.Show("işlem başarısız");
            }
           
          
            if (arrayList.Count==0)
            {
                try
                {
            veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "insert into flash_card_kelimeler (kelime,anlami,seviyesi,ikinci_anlami) values(@kelimee,@anlamii,@seviyesii,@ikinci_anlamii)";
            veritabani.cmd.Parameters.AddWithValue("@kelimee", kelime.Text);
            veritabani.cmd.Parameters.AddWithValue("@anlamii", anlami.Text);
            veritabani.cmd.Parameters.AddWithValue("@seviyesii",seviyesi.Text );
            veritabani.cmd.Parameters.AddWithValue("@ikinci_anlamii", ikinciAnlami.Text);
            veritabani.bilgiyaz();
                }
                catch (Exception)
                {

                    MessageBox.Show("kelime eklenemedi");
                }
           
            }
            else
            {
                MessageBox.Show("Bu kelime zaten bulunuyor");
            }

           
        }

        private void button4_Click(object sender, EventArgs e)//kullanıcı ekleme butonu
        {
            
            if (kullaniciadi.Text!=""&&sifre.Text!="")
            {
                try
                {
                
                veritabani.cmd=new OleDbCommand();
                veritabani.cmd.CommandText =veritabani.komut = "insert into AdminUser (kullanici_ismi,kullanici_sifre) values (@isimm,@sifree)" ;
                veritabani.cmd.Parameters.AddWithValue("@isimm", kullaniciadi.Text);
                veritabani.cmd.Parameters.AddWithValue("@sifree", sifre.Text);
                veritabani.bilgiyaz();

                }
                catch (Exception)
                {

                    MessageBox.Show("kullanıcı eklenemedi");
                }
               

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz");
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
