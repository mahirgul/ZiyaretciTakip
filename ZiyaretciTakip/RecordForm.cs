using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class RecordForm : Form
    {
        string fileName;
        string userName;
        string mandatoryFields;
        bool saveUpperCase;

        private void doubleBuffer(object obj)
        {
            try
            {
                typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, obj, new object[] { true });
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        public RecordForm(string _fileName, string _userName, string _zorunluAlanlar, bool _buyukYaz)
        {
            InitializeComponent();
            fileName = _fileName;
            userName = _userName;
            mandatoryFields = _zorunluAlanlar;
            saveUpperCase = _buyukYaz;
            doubleBuffer(recordsDG);
        }

        private bool zorunlulukTest(Control cont1, string isim)
        {
            if (mandatoryFields.Contains(isim))
            {
                if (cont1.Text.Length == 0)
                {
                    cont1.Focus();
                    return true;
                }
                else
                    return false;

            }
            else
                return false;
        }

        private void buyukHarf()
        {
            if (saveUpperCase)
            {
                isimTbox.Text = isimTbox.Text.ToUpper();
                telefonTbox.Text = telefonTbox.Text.ToUpper();
                plakaTbox.Text = plakaTbox.Text.ToUpper();
                hesTbox.Text = hesTbox.Text.ToUpper();
                firmaTbox.Text = firmaTbox.Text.ToUpper();
                hesTbox.Text = hesTbox.Text.ToUpper();
                aciklamaTbox.Text = aciklamaTbox.Text.ToUpper();
            }
        }


        private void addVisitBtn_Click(object sender, EventArgs e)
        {
            buyukHarf();

            if (zorunlulukTest(isimTbox, "Name"))
                return;
            if (zorunlulukTest(telefonTbox, "Phone"))
                return;

            if (zorunlulukTest(plakaTbox, "CarReg"))
                return;

            if (zorunlulukTest(firmaTbox, "Company"))
                return;

            if (zorunlulukTest(hesTbox, "Personal"))
                return;

            if (zorunlulukTest(aciklamaTbox, "VisitReason"))
                return;

            try
            {

                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + "; Version=3;");
                con.Open();

                string girisTime = DateTime.Now.ToString("HH:mm:ss");

                string sql = @"INSERT INTO Records 
                        ('Date', 'Name', 'Phone', 'CarReg', 'Company', 'Personal', 'VisitReason', 'inTime','UserName') 
                        VALUES 
                        ( '" + DateTime.Now.ToString("dd.MM.yyyy") + "', '" + isimTbox.Text + "', " +
                            " '" + telefonTbox.Text + "', '" + plakaTbox.Text + "', '" + firmaTbox.Text + "', " +
                            " '" + hesTbox.Text + "', '" + aciklamaTbox.Text + "', '" + girisTime + "', '" + userName + "');";

                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clean();

            refreshDG();

        }

        private void refreshDG()
        {
            try
            {
                string where = "";
                if (isimTbox.Text.Length > 0)
                {
                    where = " WHERE Name LIKE '%" + isimTbox.Text + "%'";
                }
                if (plakaTbox.Text.Length > 0)
                {
                    if (where.Contains("WHERE"))
                        where += " AND ";
                    else
                        where += " WHERE ";
                    where += " CarReg LIKE '%" + plakaTbox.Text + "%'";
                }
                if (firmaTbox.Text.Length > 0)
                {
                    if (where.Contains("WHERE"))
                        where += " AND ";
                    else
                        where += " WHERE ";
                    where += " Company LIKE '%" + firmaTbox.Text + "%'";
                }
                if (inCbox.Checked)
                {
                    if (where.Contains("WHERE"))
                        where += " AND ";
                    else
                        where += " WHERE ";
                    where += " outTime IS NULL ";
                }
                string sql = "SELECT ID, CAST(Date AS TEXT) AS Date, Name, Phone, CarReg, Company, Personal, VisitReason, CAST(inTime AS TEXT) AS inTime, CAST(outTime AS TEXT) AS outTime, UserName AS UserName , SaveDate FROM Records " + where + " ORDER BY SaveDate DESC, ID DESC LIMIT 100;";
                Console.WriteLine(sql);
                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    recordsDG.DataSource = dt;
                    recordsDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    recordsDG.Columns["ID"].Visible = false;
                    recordsDG.Columns["SaveDate"].Visible = false;


                    recordsDG.Columns["Date"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    recordsDG.Columns["inTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    recordsDG.Columns["outTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    recordsDG.Columns["UserName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                    recordsDG.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    recordsDG.DataSource = null;
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

        private void clean()
        {
            idTbox.Text = "";
            isimTbox.Text = "";
            telefonTbox.Text = "";
            plakaTbox.Text = "";
            firmaTbox.Text = "";
            hesTbox.Text = "";
            aciklamaTbox.Text = "";
            girisTbox.Text = "";
            cikisTbox.Text = "";
            isimTbox.Focus();
        }

        private void updateVisitBtn_Click(object sender, EventArgs e)
        {
            buyukHarf();

            if (zorunlulukTest(isimTbox, "Name"))
                return;
            if (zorunlulukTest(telefonTbox, "Phone"))
                return;
            if (zorunlulukTest(plakaTbox, "CarReg"))
                return;
            if (zorunlulukTest(firmaTbox, "Company"))
                return;
            if (zorunlulukTest(hesTbox, "Personal"))
                return;
            if (zorunlulukTest(aciklamaTbox, "VisitReason"))
                return;

            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + "; Version=3;");
                con.Open();

                string sql = @"UPDATE Records SET Name = '" + isimTbox.Text + "', Phone = '" + telefonTbox.Text + "', " +
                            " CarReg = '" + plakaTbox.Text + "', Company = '" + firmaTbox.Text + "', Personal = '" + hesTbox.Text + "', " +
                            " VisitReason = '" + aciklamaTbox.Text + "', inTime = '" + girisTbox.Text + "', outTime = '" + cikisTbox.Text + "', " +
                            " UserName = '" + userName + "' WHERE ID = '" + idTbox.Text + "';";


                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            clean();
            refreshDG();

        }

        private void addExitBtn_Click(object sender, EventArgs e)
        {
            buyukHarf();

            if (zorunlulukTest(isimTbox, "Name"))
                return;
            if (zorunlulukTest(telefonTbox, "Phone"))
                return;
            if (zorunlulukTest(plakaTbox, "CarReg"))
                return;
            if (zorunlulukTest(firmaTbox, "Company"))
                return;
            if (zorunlulukTest(hesTbox, "Personal"))
                return;
            if (zorunlulukTest(aciklamaTbox, "VisitReason"))
                return;

            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + "; Version=3;");
                con.Open();

                string cikisTime = DateTime.Now.ToString("HH:mm:ss");
                if (cikisTbox.Text.Length > 0)
                    cikisTime = cikisTbox.Text;

                string sql = @"UPDATE Records SET Name = '" + isimTbox.Text + "', Phone = '" + telefonTbox.Text + "', " +
                            " CarReg = '" + plakaTbox.Text + "', Company = '" + firmaTbox.Text + "', Personal = '" + hesTbox.Text + "', " +
                            " VisitReason = '" + aciklamaTbox.Text + "', outTime = '" + cikisTime + "', UserName = '" + userName + "' " +
                            " WHERE ID = '" + idTbox.Text + "';";


                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                Console.WriteLine(sql);
                Console.WriteLine(con.ConnectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clean();

            refreshDG();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void RecordForm_Load(object sender, EventArgs e)
        {
            refreshDG();
        }

        private void recordsDG_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (recordsDG.Rows.Count > 0)
            {
                if (recordsDG.SelectedRows.Count == 1)
                {
                    idTbox.Text = recordsDG.SelectedRows[0].Cells["ID"].Value.ToString();
                    isimTbox.Text = recordsDG.SelectedRows[0].Cells["Name"].Value.ToString();
                    telefonTbox.Text = recordsDG.SelectedRows[0].Cells["Phone"].Value.ToString();
                    plakaTbox.Text = recordsDG.SelectedRows[0].Cells["CarReg"].Value.ToString();
                    firmaTbox.Text = recordsDG.SelectedRows[0].Cells["Company"].Value.ToString();
                    hesTbox.Text = recordsDG.SelectedRows[0].Cells["Personal"].Value.ToString();
                    aciklamaTbox.Text = recordsDG.SelectedRows[0].Cells["VisitReason"].Value.ToString();
                    girisTbox.Text = recordsDG.SelectedRows[0].Cells["inTime"].Value.ToString();
                    cikisTbox.Text = recordsDG.SelectedRows[0].Cells["outTime"].Value.ToString();
                }
            }
        }

        private void isimTbox_TextChanged(object sender, EventArgs e)
        {
            refreshDG();
        }

        private void plakaTbox_TextChanged(object sender, EventArgs e)
        {
            refreshDG();
        }

        private void firmaTbox_TextChanged(object sender, EventArgs e)
        {
            refreshDG();
        }

        private void inCbox_CheckedChanged(object sender, EventArgs e)
        {
            refreshDG();
        }
    }
}
