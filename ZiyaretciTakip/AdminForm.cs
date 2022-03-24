using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class AdminForm : Form
    {
        private string appFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";


        public AdminForm()
        {
            InitializeComponent();
           
        }

        private void fileSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (newFileTbox.Text.Length > 0)
                {
                    string filename = appFolder + newFileTbox.Text + ".s3db";

                    new saveFile(filename);
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void upCbox_CheckedChanged(object sender, EventArgs e)
        {
            dataSave();
        }

        private void dataSave()
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = new IniData();

            data["Settings"]["saveUppercase"] = upCbox.Checked.ToString();
            data["Settings"]["mandatoryFields"] = mandTbox.Text;

            parser.WriteFile(appFolder + "\\Settings.ini", data);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            FileIniDataParser parser = new FileIniDataParser();
            IniData data = parser.ReadFile(appFolder + "\\Settings.ini");

            upCbox.Checked = bool.Parse(data["Settings"]["saveUppercase"]);
            mandTbox.Text = data["Settings"]["mandatoryFields"];
        }

        private void mandTbox_TextChanged(object sender, EventArgs e)
        {
            dataSave();
        }
    }
}
