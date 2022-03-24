
namespace ZiyaretciTakip
{
    partial class UserForm
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
            this.userLabel = new System.Windows.Forms.Label();
            this.updatePassTbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePassBtn = new FontAwesome.Sharp.IconButton();
            this.adminUserPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.newUserTbox = new System.Windows.Forms.TextBox();
            this.newPassTbox = new System.Windows.Forms.TextBox();
            this.addNewUserBtn = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.userDG = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.adminUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDG)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.userLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.updatePassTbox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.updatePassBtn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.adminUserPanel, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(659, 530);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // userLabel
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.userLabel, 2);
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userLabel.Location = new System.Drawing.Point(23, 20);
            this.userLabel.Name = "userLabel";
            this.userLabel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.userLabel.Size = new System.Drawing.Size(612, 32);
            this.userLabel.TabIndex = 4;
            this.userLabel.Text = "Kullanıcı şifresini değiştirmek için aşağıdaki alana yeni şifreyi giriniz.";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatePassTbox
            // 
            this.updatePassTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updatePassTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatePassTbox.Location = new System.Drawing.Point(332, 56);
            this.updatePassTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updatePassTbox.Name = "updatePassTbox";
            this.updatePassTbox.PasswordChar = '*';
            this.updatePassTbox.Size = new System.Drawing.Size(303, 37);
            this.updatePassTbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 52);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label1.Size = new System.Drawing.Size(303, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yeni Şifre :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updatePassBtn
            // 
            this.updatePassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.updatePassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatePassBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.updatePassBtn.IconColor = System.Drawing.Color.Black;
            this.updatePassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatePassBtn.Location = new System.Drawing.Point(332, 100);
            this.updatePassBtn.Name = "updatePassBtn";
            this.updatePassBtn.Size = new System.Drawing.Size(303, 37);
            this.updatePassBtn.TabIndex = 2;
            this.updatePassBtn.Text = "Şifre Güncelle";
            this.updatePassBtn.UseVisualStyleBackColor = false;
            this.updatePassBtn.Click += new System.EventHandler(this.updatePassBtn_Click);
            // 
            // adminUserPanel
            // 
            this.adminUserPanel.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.adminUserPanel, 2);
            this.adminUserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminUserPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.adminUserPanel.Controls.Add(this.label2, 0, 2);
            this.adminUserPanel.Controls.Add(this.newUserTbox, 1, 2);
            this.adminUserPanel.Controls.Add(this.newPassTbox, 1, 3);
            this.adminUserPanel.Controls.Add(this.addNewUserBtn, 1, 4);
            this.adminUserPanel.Controls.Add(this.label4, 0, 3);
            this.adminUserPanel.Controls.Add(this.label5, 0, 1);
            this.adminUserPanel.Controls.Add(this.userDG, 0, 5);
            this.adminUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminUserPanel.Location = new System.Drawing.Point(23, 143);
            this.adminUserPanel.Name = "adminUserPanel";
            this.adminUserPanel.RowCount = 6;
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.adminUserPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.adminUserPanel.Size = new System.Drawing.Size(612, 384);
            this.adminUserPanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label2.Size = new System.Drawing.Size(300, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yeni Kullanıcı :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newUserTbox
            // 
            this.newUserTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUserTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserTbox.Location = new System.Drawing.Point(309, 56);
            this.newUserTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newUserTbox.Name = "newUserTbox";
            this.newUserTbox.Size = new System.Drawing.Size(300, 37);
            this.newUserTbox.TabIndex = 3;
            // 
            // newPassTbox
            // 
            this.newPassTbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPassTbox.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newPassTbox.Location = new System.Drawing.Point(309, 101);
            this.newPassTbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.newPassTbox.Name = "newPassTbox";
            this.newPassTbox.PasswordChar = '*';
            this.newPassTbox.Size = new System.Drawing.Size(300, 37);
            this.newPassTbox.TabIndex = 4;
            // 
            // addNewUserBtn
            // 
            this.addNewUserBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(98)))));
            this.addNewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUserBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.addNewUserBtn.IconColor = System.Drawing.Color.Black;
            this.addNewUserBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addNewUserBtn.Location = new System.Drawing.Point(309, 145);
            this.addNewUserBtn.Name = "addNewUserBtn";
            this.addNewUserBtn.Size = new System.Drawing.Size(300, 37);
            this.addNewUserBtn.TabIndex = 5;
            this.addNewUserBtn.Text = "Kullanıcı Ekle";
            this.addNewUserBtn.UseVisualStyleBackColor = false;
            this.addNewUserBtn.Click += new System.EventHandler(this.addNewUserBtn_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label4.Size = new System.Drawing.Size(300, 45);
            this.label4.TabIndex = 2;
            this.label4.Text = "Yeni Şifre :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.adminUserPanel.SetColumnSpan(this.label5, 2);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.label5.Size = new System.Drawing.Size(606, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yeni kullanıcı oluşturmak için aşağıdaki alanları doldurunuz.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userDG
            // 
            this.userDG.AllowUserToAddRows = false;
            this.userDG.AllowUserToDeleteRows = false;
            this.userDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminUserPanel.SetColumnSpan(this.userDG, 2);
            this.userDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDG.Location = new System.Drawing.Point(3, 188);
            this.userDG.Name = "userDG";
            this.userDG.ReadOnly = true;
            this.userDG.RowHeadersWidth = 20;
            this.userDG.Size = new System.Drawing.Size(606, 193);
            this.userDG.TabIndex = 6;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(50)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(659, 530);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UserForm";
            this.Text = "SupportForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.adminUserPanel.ResumeLayout(false);
            this.adminUserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox updatePassTbox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton updatePassBtn;
        private System.Windows.Forms.TableLayoutPanel adminUserPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox newUserTbox;
        private System.Windows.Forms.TextBox newPassTbox;
        private FontAwesome.Sharp.IconButton addNewUserBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView userDG;
    }
}