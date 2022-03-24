
namespace ZiyaretciTakip
{
    partial class AdminForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.newFileTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSaveBtn = new FontAwesome.Sharp.IconButton();
            this.mandTbox = new System.Windows.Forms.TextBox();
            this.upCbox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.newFileTbox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.fileSaveBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.mandTbox, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.upCbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label3.Size = new System.Drawing.Size(612, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yeni veri dosyası oluşturmak için aşağıdaki alanı doldurunuz.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newFileTbox
            // 
            this.newFileTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFileTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newFileTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newFileTbox.Location = new System.Drawing.Point(332, 64);
            this.newFileTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newFileTbox.Name = "newFileTbox";
            this.newFileTbox.Size = new System.Drawing.Size(303, 37);
            this.newFileTbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(303, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Dosya İsmi :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileSaveBtn
            // 
            this.fileSaveBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileSaveBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.fileSaveBtn.IconColor = System.Drawing.Color.Black;
            this.fileSaveBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.fileSaveBtn.Location = new System.Drawing.Point(332, 103);
            this.fileSaveBtn.Name = "fileSaveBtn";
            this.fileSaveBtn.Size = new System.Drawing.Size(303, 34);
            this.fileSaveBtn.TabIndex = 5;
            this.fileSaveBtn.Text = "Yeni Dosya Oluştur";
            this.fileSaveBtn.UseVisualStyleBackColor = true;
            this.fileSaveBtn.Click += new System.EventHandler(this.fileSaveBtn_Click);
            // 
            // mandTbox
            // 
            this.mandTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mandTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mandTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mandTbox.Location = new System.Drawing.Point(332, 184);
            this.mandTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mandTbox.Name = "mandTbox";
            this.mandTbox.Size = new System.Drawing.Size(303, 37);
            this.mandTbox.TabIndex = 8;
            this.mandTbox.TextChanged += new System.EventHandler(this.mandTbox_TextChanged);
            // 
            // upCbox
            // 
            this.upCbox.Location = new System.Drawing.Point(23, 143);
            this.upCbox.Name = "upCbox";
            this.upCbox.Size = new System.Drawing.Size(303, 34);
            this.upCbox.TabIndex = 7;
            this.upCbox.Text = "Büyük harfle kaydet";
            this.upCbox.UseVisualStyleBackColor = true;
            this.upCbox.CheckedChanged += new System.EventHandler(this.upCbox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(23, 180);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(303, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Zorunlu Alanlar :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminForm
            // 
            this.AcceptButton = this.fileSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(659, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox newFileTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton fileSaveBtn;
        private System.Windows.Forms.CheckBox upCbox;
        private System.Windows.Forms.TextBox mandTbox;
        private System.Windows.Forms.Label label2;
    }
}