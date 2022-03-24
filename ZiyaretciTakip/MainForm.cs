using FontAwesome.Sharp;
using IniParser;
using IniParser.Model;
using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class MainForm : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;

        private Form currentChildForm;

        bool saveUppercase = false;

        string mandatoryFields = "";

        string appFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";

        public MainForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void formUpdate(string userName, string fileName)
        {
            fileNameLabel.Text = fileName;
            userNameBtn.Text = userName;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                panelShadow.BackColor = color;
                panelShadow2.BackColor = color;


            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                currentBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));

            }
        }
        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();

        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void readSettings()
        {
            try
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = new IniData();

                data = parser.ReadFile(appFolder + "\\Settings.ini");

                saveUppercase = bool.Parse(data["Settings"]["saveUppercase"]);
                mandatoryFields = data["Settings"]["mandatoryFields"];
            }
            catch (Exception)
            {
                FileIniDataParser parser = new FileIniDataParser();
                IniData data = new IniData();

                data["Settings"]["saveUppercase"] = "True";
                data["Settings"]["mandatoryFields"] = "Name,Phone,CarReg,Company,Personal,VisitReason";

                parser.WriteFile(appFolder + "\\Settings.ini", data);

            }
        }

        private void fileCreate()
        {
            try
            {
                string filename = appFolder + "ziyaret.s3db";
                new saveFile(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            tarihGoster();

            string saveFile = appFolder + "\\ZiyaretciGuncelle.exe";

            if (System.IO.File.Exists(saveFile))
            {
                System.IO.File.Delete(saveFile);
            }

            readSettings();
            adminButton.Visible = false;
            reportButton.Visible = false;
            userButton.Visible = false;
            recordButton.Visible = false;
            loginButton.PerformClick();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string[] filePaths = Directory.GetFiles(appFolder, "*.s3db");

            if (filePaths.Length > 0)
            {


            }
            else
            {
                fileCreate();
                filePaths = Directory.GetFiles(appFolder, "*.s3db");
            }

            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new LoginForm(this, filePaths));
        }

        private void recordButton_Click(object sender, EventArgs e)
        {
            ActivateButton(recordButton, RGBColors.color2);
            OpenChildForm(new RecordForm(fileNameLabel.Text, userNameBtn.Text, mandatoryFields, saveUppercase));
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ReportForm(fileNameLabel.Text));
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChildForm(new UserForm(fileNameLabel.Text, userNameBtn.Text));

        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenChildForm(new AdminForm());
        }

        private void supportButton_Click(object sender, EventArgs e)
        {
            Reset();
            ActivateButton(sender, RGBColors.color6);
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            supportButton.PerformClick();
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void userNameBtn_TextChanged(object sender, EventArgs e)
        {
            if (userNameBtn.Text.Length > 0)
            {
                Reset();
                loginButton.Visible = false;
                recordButton.Visible = true;
                reportButton.Visible = true;
                userButton.Visible = true;

                reportButton.Enabled = true;
                userButton.Enabled = true;
                recordButton.Enabled = true;
                userButton.Enabled = true;

                if (userNameBtn.Text == "admin")
                {
                    adminButton.Enabled = true;
                    adminButton.Visible = true;
                }
                recordButton.PerformClick();
            }
        }

        private void userNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void webLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // https://www.mhrgl.com
            System.Diagnostics.Process.Start("https://www.mhrgl.com");
        }

        private void telLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //tel:+90 537 990 2352
            System.Diagnostics.Process.Start("tel:+905379902352");
        }

        private void mailLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // "mailto:mahirgul@gmail.com"
            System.Diagnostics.Process.Start("mailto:mahirgul@gmail.com");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            readSettings();
            userNameBtn.Text = "";
            fileNameLabel.Text = "---";
            adminButton.Visible = false;
            reportButton.Visible = false;
            userButton.Visible = false;
            recordButton.Visible = false;
            loginButton.Visible = true;
            loginButton.Enabled = true;
            loginButton.PerformClick();
        }

        private void zamanTimer_Tick(object sender, EventArgs e)
        {
            tarihGoster();
        }

        private void userNameBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tarihGoster()
        {
            saat.Text = DateTime.Now.ToString("T");
            tarih.Text = DateTime.Now.ToString("D");
        }
    }
}
