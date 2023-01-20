namespace Login
{
    partial class LoginPage
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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.Image = global::UI.Properties.Resources.Varlık_1;
            this.picLogo.Location = new System.Drawing.Point(78, 71);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Transparent;
            this.picUser.Image = global::UI.Properties.Resources.icons8_username_32;
            this.picUser.Location = new System.Drawing.Point(40, 230);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(32, 32);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtUsername.Location = new System.Drawing.Point(78, 236);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(230, 23);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "Kullanıcı Adı";
            this.txtUsername.Click += new System.EventHandler(this.TxtUsername_Click);
            this.txtUsername.TextChanged += new System.EventHandler(this.TxtUsername_TextChanged);
            this.txtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(78, 261);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(78, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 1);
            this.panel2.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.Location = new System.Drawing.Point(78, 308);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(230, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Text = "Şifre";
            this.txtPassword.Click += new System.EventHandler(this.TxtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // picLock
            // 
            this.picLock.BackColor = System.Drawing.Color.Transparent;
            this.picLock.Image = global::UI.Properties.Resources.icons8_sign_in_form_password_32;
            this.picLock.Location = new System.Drawing.Point(40, 302);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(32, 32);
            this.picLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLock.TabIndex = 4;
            this.picLock.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnLogin.Location = new System.Drawing.Point(40, 365);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(268, 55);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::UI.Properties.Resources.icons8_Close_32;
            this.picClose.Location = new System.Drawing.Point(306, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(32, 32);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 8;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            this.picClose.MouseEnter += new System.EventHandler(this.PicClose_MouseEnter);
            this.picClose.MouseLeave += new System.EventHandler(this.PicClose_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 50);
            this.panel3.TabIndex = 9;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Panel3_MouseUp);
            // 
            // labError
            // 
            this.labError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labError.Location = new System.Drawing.Point(47, 431);
            this.labError.Name = "labError";
            this.labError.Size = new System.Drawing.Size(255, 59);
            this.labError.TabIndex = 10;
            this.labError.Text = "Giriş Başarısız. Lütfen kullanıcı adı ve şifrenizi kontrol ediniz.";
            this.labError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labError.UseMnemonic = false;
            this.labError.Visible = false;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.labError);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picLogo;
        private PictureBox picUser;
        private TextBox txtUsername;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtPassword;
        private PictureBox picLock;
        private Button btnLogin;
        private PictureBox picClose;
        private Panel panel3;
        private Label labError;
    }
}