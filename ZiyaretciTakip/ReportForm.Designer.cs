
namespace ZiyaretciTakip
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.getReportBtn = new FontAwesome.Sharp.IconButton();
            this.getInsideBtn = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.raporPanel = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.getReportBtn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.getInsideBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.raporPanel, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // getReportBtn
            // 
            this.getReportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.getReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getReportBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.getReportBtn.IconColor = System.Drawing.Color.Black;
            this.getReportBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.getReportBtn.Location = new System.Drawing.Point(23, 56);
            this.getReportBtn.Name = "getReportBtn";
            this.getReportBtn.Size = new System.Drawing.Size(303, 37);
            this.getReportBtn.TabIndex = 8;
            this.getReportBtn.Text = "Rapor Hazırla";
            this.getReportBtn.UseVisualStyleBackColor = false;
            this.getReportBtn.Click += new System.EventHandler(this.getReportBtn_Click);
            // 
            // getInsideBtn
            // 
            this.getInsideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.getInsideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getInsideBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.getInsideBtn.IconColor = System.Drawing.Color.Black;
            this.getInsideBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.getInsideBtn.Location = new System.Drawing.Point(332, 56);
            this.getInsideBtn.Name = "getInsideBtn";
            this.getInsideBtn.Size = new System.Drawing.Size(303, 37);
            this.getInsideBtn.TabIndex = 5;
            this.getInsideBtn.Text = "İçeride Kalanlar Raporu";
            this.getInsideBtn.UseVisualStyleBackColor = false;
            this.getInsideBtn.Click += new System.EventHandler(this.getInsideBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 27);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(303, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rapor Tarihi Seçin :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // raporPanel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.raporPanel, 2);
            this.raporPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.raporPanel.Location = new System.Drawing.Point(23, 99);
            this.raporPanel.Name = "raporPanel";
            this.raporPanel.Size = new System.Drawing.Size(612, 428);
            this.raporPanel.TabIndex = 10;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AcceptButton = this.getInsideBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(659, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportForm";
            this.Text = "SupportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton getInsideBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton getReportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel raporPanel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}