using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Reflection.Emit;
using System.Collections;
using System.Windows.Forms;

namespace database
{
    public class Class1
    {
        public string databaseaddress= "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ingilizce_otomasyon_database.accdb";
        public string komut="";
      public  OleDbConnection conn;
       public OleDbCommand cmd=new OleDbCommand();
       public OleDbDataReader reader;

        public ArrayList veri_cek() 
        {
        ArrayList output=new ArrayList();
            conn = new OleDbConnection(databaseaddress);
            conn.Open();
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string tutucu="";
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    tutucu += reader[i].ToString();
                    tutucu += " ";
                }
          output.Add(tutucu);
              
            }

            conn.Close();
            return output;
        }
        public ArrayList veri_cek2()
        {
            ArrayList output = new ArrayList();
            conn = new OleDbConnection(databaseaddress);
            conn.Open();
            cmd.Connection = conn;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    output.Add(reader[i]);
                }
                

            }

            conn.Close();
            return output;
        }


        public string  bilgicekme() {
            string cikti="";
            conn = new OleDbConnection(databaseaddress);
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = komut;
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
              cikti=reader[0].ToString();
            }
            conn.Close();
            return cikti;

        }
        public string  bilgicek(string komut,string databaseaddress,string colon_name, string colon_name2,string searchname)
        {
            string resultt = "";
            this.databaseaddress = databaseaddress;
            OleDbConnection connect = new OleDbConnection(databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();
            
            command.CommandText = komut;
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader[colon_name].ToString()==searchname )
                {
                    resultt= reader[colon_name2].ToString();
                }
            }
            return resultt;
        }
        public void  bilgicek(string komut, string databaseaddress,string colonname,string colonname2,string colonname3,out ArrayList word,out ArrayList meaning, out ArrayList meaning2)
        {
            this.databaseaddress = databaseaddress;
            OleDbConnection connect = new OleDbConnection(databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();
           
            command.CommandText = komut;
            word=new ArrayList();
             meaning = new ArrayList();
             meaning2 = new ArrayList();
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

              word.Add(reader[colonname].ToString()) ;
                meaning.Add(reader[colonname2].ToString()) ;
                meaning2.Add(reader[colonname3].ToString()) ;
               
                
            }
          connect.Close();  
              
            
               
        }
        public void bilgiyaz()
        {
            conn = new OleDbConnection(databaseaddress);
            conn.Open();
            cmd.Connection = conn;               
            cmd.ExecuteNonQuery();          
            conn.Close();
        }
        public void bilgisil()
        {
            conn=new OleDbConnection(databaseaddress);
            conn.Open();
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void bilgiguncelle(string komut, string databaseaddress,string degisilceksutunismi,bool deger)
        {
            this.databaseaddress = databaseaddress;
            OleDbConnection connect = new OleDbConnection(databaseaddress);
            connect.Open();
            OleDbCommand command = connect.CreateCommand();
            command.CommandText = komut;
            command.Parameters.AddWithValue("@NewValue", deger);
            command.Parameters.AddWithValue("@RecordID",degisilceksutunismi); 

            int rowsAffected = command.ExecuteNonQuery();

            
            if (rowsAffected > 0)
            {
                Console.WriteLine("Güncelleme başarıyla gerçekleştirildi.");
            }
            else
            {
                Console.WriteLine("Güncelleme sırasında bir hata oluştu veya güncellenecek kayıt bulunamadı.");
            }
            connect.Close();
        }
  
    }
 
}
