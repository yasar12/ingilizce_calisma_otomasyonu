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
    public partial class AdminLoginPanel : Form
    {
        public AdminLoginPanel()
        {
            InitializeComponent();
        }
        Class1 veritabani=new Class1();
        private void button1_Click(object sender, EventArgs e)//sağ üstteki program kapatma butonu
        {
            this.Close();
            giris giris = new giris();
            giris.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//giriş butonu
        {
            ArrayList kullanici=new ArrayList();
            try
            {
             veritabani.cmd = new OleDbCommand();
            veritabani.cmd.CommandText = veritabani.komut = "select kullanici_ismi,kullanici_sifre from AdminUser where kullanici_ismi=@isim and kullanici_sifre=@sifre";
            veritabani.cmd.Parameters.AddWithValue("@isim", username.Text.ToLower().Trim());
            veritabani.cmd.Parameters.AddWithValue("@sifre", password.Text.ToLower().Trim());
            kullanici = veritabani.veri_cek();


            if (username.Text!=null&&password.Text!=null)
            {
                if (kullanici!=null)
            {
                admin_panel open = new admin_panel();
                this.Visible = false;
                open.ShowDialog();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya şifre yanlış");
            }
            }
            else
            {
                MessageBox.Show("kullanıcı adı ve parola boş bırakılamaz");
            }


            }
            catch (Exception)
            {

                MessageBox.Show("Bir hata meydana geldi giriş yapılamıyor.");
            }
           


        }
    }
}
