using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    class saveFile
    {
        public saveFile(string fileName)
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    SQLiteConnection.CreateFile(fileName);
                    SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + "; Version=3;");
                    con.Open();

                    string sql = @"CREATE TABLE Users(
                               ID           INTEGER PRIMARY KEY AUTOINCREMENT ,
                               UserName     VARCHAR(20) UNIQUE  NOT NULL,
                               Password     VARCHAR(20)     NOT NULL,
                               SaveDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP NULL
                            );";

                    SQLiteCommand cmd = new SQLiteCommand(sql, con);

                    cmd.ExecuteNonQuery();

                    sql = @"INSERT INTO users ('UserName', 'Password') VALUES ( 'admin', '123');";

                    cmd = new SQLiteCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    sql = @"CREATE TABLE Records (
                        ID INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date DATE DEFAULT CURRENT_DATE,
                        Name VARCHAR(50)  NULL,
                        Phone VARCHAR(15)  NULL,
                        CarReg VARCHAR(15)  NULL,
                        Company VARCHAR(100)  NULL,
                        Personal VARCHAR(15)  NULL,
                        VisitReason TEXT  NULL,
                        inTime TIME  NULL,
                        outTime TIME  NULL,
                        UserName VARCHAR(15) NULL,
                        SaveDate TIMESTAMP DEFAULT CURRENT_TIMESTAMP NULL
                     );";

                    cmd = new SQLiteCommand(sql, con);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
