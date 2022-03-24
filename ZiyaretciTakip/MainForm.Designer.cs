
namespace ZiyaretciTakip
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.zamanPanel = new System.Windows.Forms.Panel();
            this.tarih = new System.Windows.Forms.Label();
            this.saat = new System.Windows.Forms.Label();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.supportButton = new FontAwesome.Sharp.IconButton();
            this.adminButton = new FontAwesome.Sharp.IconButton();
            this.userButton = new FontAwesome.Sharp.IconButton();
            this.reportButton = new FontAwesome.Sharp.IconButton();
            this.recordButton = new FontAwesome.Sharp.IconButton();
            this.loginButton = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelShadow2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMin = new FontAwesome.Sharp.IconButton();
            this.btnMax = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.userNameBtn = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailLink = new System.Windows.Forms.LinkLabel();
            this.webLink = new System.Windows.Forms.LinkLabel();
            this.telLink = new System.Windows.Forms.LinkLabel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.zamanTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.zamanPanel.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.zamanPanel);
            this.panelMenu.Controls.Add(this.exitBtn);
            this.panelMenu.Controls.Add(this.supportButton);
            this.panelMenu.Controls.Add(this.adminButton);
            this.panelMenu.Controls.Add(this.userButton);
            this.panelMenu.Controls.Add(this.reportButton);
            this.panelMenu.Controls.Add(this.recordButton);
            this.panelMenu.Controls.Add(this.loginButton);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.panelShadow2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 595);
            this.panelMenu.TabIndex = 0;
            // 
            // zamanPanel
            // 
            this.zamanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.zamanPanel.Controls.Add(this.tarih);
            this.zamanPanel.Controls.Add(this.saat);
            this.zamanPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.zamanPanel.Location = new System.Drawing.Point(0, 475);
            this.zamanPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zamanPanel.Name = "zamanPanel";
            this.zamanPanel.Size = new System.Drawing.Size(200, 100);
            this.zamanPanel.TabIndex = 8;
            // 
            // tarih
            // 
            this.tarih.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tarih.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tarih.Location = new System.Drawing.Point(0, 48);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(200, 52);
            this.tarih.TabIndex = 1;
            this.tarih.Text = "-";
            this.tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saat
            // 
            this.saat.Dock = System.Windows.Forms.DockStyle.Top;
            this.saat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat.Location = new System.Drawing.Point(0, 0);
            this.saat.Name = "saat";
            this.saat.Size = new System.Drawing.Size(200, 48);
            this.saat.TabIndex = 0;
            this.saat.Text = "-";
            this.saat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.exitBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 32;
            this.exitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.Location = new System.Drawing.Point(0, 400);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.exitBtn.Size = new System.Drawing.Size(200, 50);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "Kullanıcı Değiştir";
            this.exitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exitBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // supportButton
            // 
            this.supportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.supportButton.FlatAppearance.BorderSize = 0;
            this.supportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.supportButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.supportButton.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.supportButton.IconColor = System.Drawing.Color.Gainsboro;
            this.supportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.supportButton.IconSize = 32;
            this.supportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supportButton.Location = new System.Drawing.Point(0, 350);
            this.supportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supportButton.Name = "supportButton";
            this.supportButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.supportButton.Size = new System.Drawing.Size(200, 50);
            this.supportButton.TabIndex = 6;
            this.supportButton.Text = "Destek";
            this.supportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.supportButton.UseVisualStyleBackColor = true;
            this.supportButton.Click += new System.EventHandler(this.supportButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.adminButton.Enabled = false;
            this.adminButton.FlatAppearance.BorderSize = 0;
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.adminButton.IconChar = FontAwesome.Sharp.IconChar.Screwdriver;
            this.adminButton.IconColor = System.Drawing.Color.Gainsboro;
            this.adminButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminButton.IconSize = 32;
            this.adminButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.Location = new System.Drawing.Point(0, 300);
            this.adminButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminButton.Name = "adminButton";
            this.adminButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.adminButton.Size = new System.Drawing.Size(200, 50);
            this.adminButton.TabIndex = 5;
            this.adminButton.Text = "Yönetim Ayar";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // userButton
            // 
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.Enabled = false;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.userButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userButton.IconColor = System.Drawing.Color.Gainsboro;
            this.userButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userButton.IconSize = 32;
            this.userButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.Location = new System.Drawing.Point(0, 250);
            this.userButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userButton.Name = "userButton";
            this.userButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.userButton.Size = new System.Drawing.Size(200, 50);
            this.userButton.TabIndex = 4;
            this.userButton.Text = "Kullanıcı Ayar";
            this.userButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.reportButton.Enabled = false;
            this.reportButton.FlatAppearance.BorderSize = 0;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.reportButton.IconChar = FontAwesome.Sharp.IconChar.ChartPie;
            this.reportButton.IconColor = System.Drawing.Color.Gainsboro;
            this.reportButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.reportButton.IconSize = 32;
            this.reportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.Location = new System.Drawing.Point(0, 200);
            this.reportButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reportButton.Name = "reportButton";
            this.reportButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.reportButton.Size = new System.Drawing.Size(200, 50);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Rapor";
            this.reportButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // recordButton
            // 
            this.recordButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.recordButton.Enabled = false;
            this.recordButton.FlatAppearance.BorderSize = 0;
            this.recordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recordButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.recordButton.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.recordButton.IconColor = System.Drawing.Color.Gainsboro;
            this.recordButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.recordButton.IconSize = 32;
            this.recordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.Location = new System.Drawing.Point(0, 150);
            this.recordButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recordButton.Name = "recordButton";
            this.recordButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.recordButton.Size = new System.Drawing.Size(200, 50);
            this.recordButton.TabIndex = 2;
            this.recordButton.Text = "Ziyaret Kayıt";
            this.recordButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.recordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginButton.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.loginButton.IconColor = System.Drawing.Color.Gainsboro;
            this.loginButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginButton.IconSize = 32;
            this.loginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Location = new System.Drawing.Point(0, 100);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.loginButton.Size = new System.Drawing.Size(200, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Giriş";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(200, 100);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Ziyaretçi Takip";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // panelShadow2
            // 
            this.panelShadow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panelShadow2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShadow2.Location = new System.Drawing.Point(0, 575);
            this.panelShadow2.Name = "panelShadow2";
            this.panelShadow2.Size = new System.Drawing.Size(200, 20);
            this.panelShadow2.TabIndex = 9;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.panelTitleBar.Controls.Add(this.btnMin);
            this.panelTitleBar.Controls.Add(this.btnMax);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.userNameBtn);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(800, 30);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMin.IconSize = 24;
            this.btnMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMin.Location = new System.Drawing.Point(680, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(40, 30);
            this.btnMin.TabIndex = 4;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMax.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMax.IconSize = 24;
            this.btnMax.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMax.Location = new System.Drawing.Point(720, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(40, 30);
            this.btnMax.TabIndex = 3;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 24;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // userNameBtn
            // 
            this.userNameBtn.AutoSize = true;
            this.userNameBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(80)))), ((int)(((byte)(118)))));
            this.userNameBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userNameBtn.FlatAppearance.BorderSize = 0;
            this.userNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userNameBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.userNameBtn.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userNameBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.userNameBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userNameBtn.IconSize = 24;
            this.userNameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameBtn.Location = new System.Drawing.Point(0, 0);
            this.userNameBtn.Name = "userNameBtn";
            this.userNameBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.userNameBtn.Size = new System.Drawing.Size(800, 30);
            this.userNameBtn.TabIndex = 1;
            this.userNameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.userNameBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userNameBtn.UseVisualStyleBackColor = false;
            this.userNameBtn.TextChanged += new System.EventHandler(this.userNameBtn_TextChanged);
            this.userNameBtn.Click += new System.EventHandler(this.userNameBtn_Click);
            this.userNameBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.userNameBtn_MouseDown);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 50);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(600, 575);
            this.panelDesktop.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mailLink);
            this.panel2.Controls.Add(this.webLink);
            this.panel2.Controls.Add(this.telLink);
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 575);
            this.panel2.TabIndex = 5;
            // 
            // mailLink
            // 
            this.mailLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.mailLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailLink.LinkColor = System.Drawing.Color.Gainsboro;
            this.mailLink.Location = new System.Drawing.Point(0, 347);
            this.mailLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.mailLink.Name = "mailLink";
            this.mailLink.Size = new System.Drawing.Size(600, 60);
            this.mailLink.TabIndex = 4;
            this.mailLink.TabStop = true;
            this.mailLink.Text = "mahirgul@gmail.com";
            this.mailLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.mailLink_LinkClicked);
            // 
            // webLink
            // 
            this.webLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.webLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.webLink.LinkColor = System.Drawing.Color.Gainsboro;
            this.webLink.Location = new System.Drawing.Point(0, 287);
            this.webLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.webLink.Name = "webLink";
            this.webLink.Size = new System.Drawing.Size(600, 60);
            this.webLink.TabIndex = 2;
            this.webLink.TabStop = true;
            this.webLink.Text = "www.mhrgl.com";
            this.webLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.webLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.webLink_LinkClicked);
            // 
            // telLink
            // 
            this.telLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.telLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telLink.LinkColor = System.Drawing.Color.Gainsboro;
            this.telLink.Location = new System.Drawing.Point(0, 227);
            this.telLink.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.telLink.Name = "telLink";
            this.telLink.Size = new System.Drawing.Size(600, 60);
            this.telLink.TabIndex = 3;
            this.telLink.TabStop = true;
            this.telLink.Text = "+90 537 990 2352";
            this.telLink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.telLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.telLink_LinkClicked);
            // 
            // iconButton2
            // 
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 0);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(600, 227);
            this.iconButton2.TabIndex = 1;
            this.iconButton2.Text = "Ziyaretçi Takip Programı\r\nv.1.0.1";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(40)))), ((int)(((byte)(78)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 30);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(600, 20);
            this.panelShadow.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 625);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 4;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(90)))), ((int)(((byte)(128)))));
            this.fileNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fileNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileNameLabel.Location = new System.Drawing.Point(0, 0);
            this.fileNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.fileNameLabel.Size = new System.Drawing.Size(800, 25);
            this.fileNameLabel.TabIndex = 0;
            this.fileNameLabel.Text = "---";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // zamanTimer
            // 
            this.zamanTimer.Enabled = true;
            this.zamanTimer.Interval = 1000;
            this.zamanTimer.Tick += new System.EventHandler(this.zamanTimer_Tick);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 650);
            this.Name = "FormMainMenu";
            this.Text = "FormMainMenu";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.Resize += new System.EventHandler(this.FormMainMenu_Resize);
            this.panelMenu.ResumeLayout(false);
            this.zamanPanel.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton loginButton;
        private FontAwesome.Sharp.IconButton userButton;
        private FontAwesome.Sharp.IconButton reportButton;
        private FontAwesome.Sharp.IconButton recordButton;
        private FontAwesome.Sharp.IconButton supportButton;
        private FontAwesome.Sharp.IconButton adminButton;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnMin;
        private FontAwesome.Sharp.IconButton btnMax;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconButton userNameBtn;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.LinkLabel mailLink;
        private System.Windows.Forms.LinkLabel telLink;
        private System.Windows.Forms.LinkLabel webLink;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton exitBtn;
        private System.Windows.Forms.Panel zamanPanel;
        private System.Windows.Forms.Label tarih;
        private System.Windows.Forms.Label saat;
        private System.Windows.Forms.Timer zamanTimer;
        private System.Windows.Forms.Panel panelShadow2;
    }
}