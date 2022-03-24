using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        private string appFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";


        public LoginForm(MainForm frm, string[] fileNames)
        {
            InitializeComponent();
            mainForm = frm;
            databaseCbox.DataSource = fileNames;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!loginBW.IsBusy)
                loginBW.RunWorkerAsync();
        }

        private void loginBW_DoWork(object sender, DoWorkEventArgs e)
        {

            Invoke((Action)(() =>
            {
                loginBtn.Text = "Lütfen Bekleyin";
                loginBtn.BackColor = Color.Red;
                loginBtn.Enabled = false;
                loginVoid();
            }));
        }

        private void loginVoid()
        {
            try
            {
                string filename = databaseCbox.SelectedItem.ToString();

                SQLiteConnection con = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
                SQLiteDataAdapter da = new SQLiteDataAdapter("Select * From Users WHERE UserName = '" + userNameTbox.Text + "' AND Password = '" + passwordTbox.Text + "';", con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    AcceptButton = null;
                    mainForm.formUpdate(userNameTbox.Text, filename);
                }
                else
                {
                    loginBtn.Text = "Giriş";
                    loginBtn.BackColor = Color.Transparent;
                    loginBtn.Enabled = true;
                    MessageBox.Show("Hatalı Kullanıcı Bilgisi");
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void upgradeBtn_Click(object sender, EventArgs e)
        {
            if (!updateBW.IsBusy)
                updateBW.RunWorkerAsync();
        }

        private void updateBW_DoWork(object sender, DoWorkEventArgs e)
        {
            Invoke((Action)(() =>
            {
                FileDownload();
            }));
        }

        private void FileDownload()
        {
            string saveFile = appFolder + "\\ZiyaretciGuncelle.exe";

            try
            {
                string clientfile = "https://www.mhrgl.com/ZiyaretciGuncelle.exe";

                Uri uri = new Uri(clientfile);

                if (System.IO.File.Exists(saveFile))
                {
                    System.IO.File.Delete(saveFile);
                }

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                WebClient wc = new WebClient();
                wc.DownloadFileAsync(uri, saveFile);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(wc_DownloadFileCompleted);

            }
            catch (Exception ee)
            {
                if (System.IO.File.Exists(saveFile))
                {
                    System.IO.File.Delete(saveFile);
                }
                MessageBox.Show("Hata - " + ee.ToString());
            }

        }

        private void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            if (progressBar1.Value == progressBar1.Maximum)
            {
                progressBar1.Value = 0;
            }

        }

        private void wc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            FileRun();
        }

        private void FileRun()
        {
            string filename = appFolder + "\\ZiyaretciGuncelle.exe";

            FileInfo fi = new FileInfo(filename);

            if (fi.Length > 1000)
            {
                MessageBox.Show("Dosya indirildi şimdi güncelleme başlayacak");

                Process.Start(filename);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Dosya indirme hatası daha sonra yeniden deneyin.");

            }
        }
    }
}
