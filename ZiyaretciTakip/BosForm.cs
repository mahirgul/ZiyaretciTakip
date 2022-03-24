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
    public partial class BosForm : Form
    {
        private string appFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\";


        public BosForm()
        {
            InitializeComponent();
           
        }

        private void BosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
