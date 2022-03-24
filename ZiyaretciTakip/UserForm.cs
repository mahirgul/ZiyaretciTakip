using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class UserForm : Form
    {
        string userName;
        string fileName;

        public UserForm(string _fileName, string _userName)
        {
            userName = _userName;
            fileName = _fileName;
            InitializeComponent();

        }

        private void updatePassBtn_Click(object sender, EventArgs e)
        {
            try
            {


                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
                con.Open();
                string sql = @"UPDATE Users SET Password = '" + updatePassTbox.Text + "' WHERE UserName = '" + userName + "';";
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);
                updatePassTbox.Text = "";
                MessageBox.Show("Şifre Değişti.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addNewUserBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newUserTbox.Text.Length == 0)
                {
                    newUserTbox.Focus();
                    return;
                }
                else if (newPassTbox.Text.Length == 0)
                {
                    newPassTbox.Focus();
                    return;
                }

                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + "; Version=3;");
                con.Open();

                string sql = @"INSERT INTO Users 
                        ('UserName', 'Password') 
                        VALUES 
                        ( '" + newUserTbox.Text + "', '" + newPassTbox.Text + "');";

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);
                refreshUserDG();
                newUserTbox.Text = "";
                newPassTbox.Text = "";
                MessageBox.Show("Kullanıcı kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void refreshUserDG()
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
                string sql = "SELECT ID, UserName, Password, CAST(SaveDate AS TEXT) AS SaveDate FROM Users WHERE UserName !='admin' ORDER BY ID DESC;";
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                userDG.DataSource = null;
                if (dt.Rows.Count > 0)
                {
                    userDG.DataSource = dt;
                    userDG.DefaultCellStyle.ForeColor = Color.Black;
                }
             
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (userName == "admin")
            {
                refreshUserDG();
            }
            else
            {
                adminUserPanel.Visible = false;
            }

            userLabel.Text = userName + " " + userLabel.Text;
        }
    }
}
