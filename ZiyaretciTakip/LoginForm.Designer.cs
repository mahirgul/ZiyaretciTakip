
namespace ZiyaretciTakip
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTbox = new System.Windows.Forms.TextBox();
            this.passwordTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.databaseCbox = new System.Windows.Forms.ComboBox();
            this.upgradeBtn = new FontAwesome.Sharp.IconButton();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.loginBW = new System.ComponentModel.BackgroundWorker();
            this.updateBW = new System.ComponentModel.BackgroundWorker();
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
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.userNameTbox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.passwordTbox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.loginBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.databaseCbox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.upgradeBtn, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.label3.Size = new System.Drawing.Size(612, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lütfen kullanıcı bilgilerinizi girin.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(23, 97);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(303, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userNameTbox
            // 
            this.userNameTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTbox.Location = new System.Drawing.Point(332, 56);
            this.userNameTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameTbox.MaxLength = 50;
            this.userNameTbox.Name = "userNameTbox";
            this.userNameTbox.Size = new System.Drawing.Size(303, 37);
            this.userNameTbox.TabIndex = 0;
            // 
            // passwordTbox
            // 
            this.passwordTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTbox.Location = new System.Drawing.Point(332, 101);
            this.passwordTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTbox.MaxLength = 50;
            this.passwordTbox.Name = "passwordTbox";
            this.passwordTbox.PasswordChar = '*';
            this.passwordTbox.Size = new System.Drawing.Size(303, 37);
            this.passwordTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(303, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.loginBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginBtn.IconColor = System.Drawing.Color.Black;
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.Location = new System.Drawing.Point(332, 189);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(303, 37);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Giriş";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // databaseCbox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.databaseCbox, 2);
            this.databaseCbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseCbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.databaseCbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.databaseCbox.FormattingEnabled = true;
            this.databaseCbox.Location = new System.Drawing.Point(23, 145);
            this.databaseCbox.Name = "databaseCbox";
            this.databaseCbox.Size = new System.Drawing.Size(612, 38);
            this.databaseCbox.TabIndex = 6;
            // 
            // upgradeBtn
            // 
            this.upgradeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.tableLayoutPanel1.SetColumnSpan(this.upgradeBtn, 2);
            this.upgradeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upgradeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.upgradeBtn.IconColor = System.Drawing.Color.Black;
            this.upgradeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.upgradeBtn.Location = new System.Drawing.Point(23, 292);
            this.upgradeBtn.Name = "upgradeBtn";
            this.upgradeBtn.Size = new System.Drawing.Size(612, 37);
            this.upgradeBtn.TabIndex = 7;
            this.upgradeBtn.Text = "Program Güncelle";
            this.upgradeBtn.UseVisualStyleBackColor = false;
            this.upgradeBtn.Click += new System.EventHandler(this.upgradeBtn_Click);
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 2);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(23, 335);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(612, 37);
            this.progressBar1.TabIndex = 8;
            // 
            // loginBW
            // 
            this.loginBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loginBW_DoWork);
            // 
            // updateBW
            // 
            this.updateBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateBW_DoWork);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(659, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox userNameTbox;
        private System.Windows.Forms.TextBox passwordTbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton loginBtn;
        private System.ComponentModel.BackgroundWorker loginBW;
        private System.Windows.Forms.ComboBox databaseCbox;
        private FontAwesome.Sharp.IconButton upgradeBtn;
        private System.ComponentModel.BackgroundWorker updateBW;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}