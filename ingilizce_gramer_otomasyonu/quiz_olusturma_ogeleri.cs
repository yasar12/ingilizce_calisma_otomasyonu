using database;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_gramer_otomasyonu
{
    internal class quiz_olusturma_ogeleri
    {
        Class1 class1 = new Class1();
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
                labels.Location = new Point(400, 90);
                

                sayac++;

            }
            connect.Close();
        }
    }
}
