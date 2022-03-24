using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace ZiyaretciTakip
{
    public partial class ReportForm : Form
    {
        string fileName;

        public ReportForm(string _fileName)
        {
            InitializeComponent();
            fileName = _fileName;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            raporPanel.Controls.Add(reportViewer1);
        }

        private void getReportBtn_Click(object sender, EventArgs e)
        {

            string saveDate = " WHERE Date = '" + dateTimePicker1.Value.ToString("dd.MM.yyyy") + "' ";
            string sql = "SELECT ID, CAST(Date AS TEXT) AS Date, Name, Phone, CarReg, Company, Personal, VisitReason, CAST(inTime AS TEXT) AS inTime, CAST(outTime AS TEXT) AS outTime, CAST(SaveDate AS TEXT) AS SaveDate, UserName FROM Records " + saveDate + "ORDER BY ID DESC;";
            getReport(sql);
        }

        private void getInsideBtn_Click(object sender, EventArgs e)
        {


            string saveDate = " WHERE Date = '" + dateTimePicker1.Value.ToString("dd.MM.yyyy") + "' ";
            string sql = "SELECT ID, CAST(Date AS TEXT) AS Date, Name, Phone, CarReg, Company, Personal, VisitReason, CAST(inTime AS TEXT) AS inTime, CAST(outTime AS TEXT) AS outTime, CAST(SaveDate AS TEXT) AS SaveDate, UserName FROM Records " + saveDate + " AND outTime IS NULL ORDER BY ID DESC;";
            getReport(sql);
        }

        private void getReport(string sql)
        {
            try
            {
                SQLiteConnection con = new SQLiteConnection("Data Source=" + fileName + ";Version=3;");
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    reportViewer1.LocalReport.DataSources.Clear();

                    reportViewer1.ProcessingMode = ProcessingMode.Local;
                    reportViewer1.LocalReport.ReportEmbeddedResource = "ZiyaretciTakip.ziyaretci.rdlc";
                    reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ziyaretci", dt));

                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.RefreshReport();

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
    }
}
