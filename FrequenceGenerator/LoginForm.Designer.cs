namespace FrequenceGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.picLoader = new System.Windows.Forms.PictureBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.btnRegister1 = new System.Windows.Forms.Button();
            this.labelEmail1 = new System.Windows.Forms.Label();
            this.txtEmail1 = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnLogin1 = new System.Windows.Forms.Button();
            this.panel_register = new System.Windows.Forms.Panel();
            this.preLoader1 = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLoader)).BeginInit();
            this.panel_register.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.preLoader1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Yellow;
            this.labelTitle.Location = new System.Drawing.Point(44, 72);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(292, 34);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Frequence Generator";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_login
            // 
            this.panel_login.Controls.Add(this.picLoader);
            this.panel_login.Controls.Add(this.btnRegister);
            this.panel_login.Controls.Add(this.txtEmail);
            this.panel_login.Controls.Add(this.btnLogin);
            this.panel_login.Controls.Add(this.txtPassword);
            this.panel_login.Controls.Add(this.labelPassword);
            this.panel_login.Controls.Add(this.labelEmail);
            this.panel_login.Controls.Add(this.labelLogin);
            this.panel_login.Location = new System.Drawing.Point(20, 160);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(340, 480);
            this.panel_login.TabIndex = 1;
            // 
            // picLoader
            // 
            this.picLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLoader.BackColor = System.Drawing.SystemColors.Control;
            this.picLoader.Image = ((System.Drawing.Image) (resources.GetObject("picLoader.Image")));
            this.picLoader.InitialImage = ((System.Drawing.Image) (resources.GetObject("picLoader.InitialImage")));
            this.picLoader.Location = new System.Drawing.Point(141, 208);
            this.picLoader.Name = "picLoader";
            this.picLoader.Size = new System.Drawing.Size(50, 49);
            this.picLoader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoader.TabIndex = 10;
            this.picLoader.TabStop = false;
            this.picLoader.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(120, 360);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(116, 30);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtEmail.Location = new System.Drawing.Point(0, 120);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 37);
            this.txtEmail.TabIndex = 8;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 302);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(340, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword.Location = new System.Drawing.Point(0, 220);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(340, 37);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPassword.ForeColor = System.Drawing.Color.White;
            this.labelPassword.Location = new System.Drawing.Point(0, 180);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(340, 25);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            this.labelEmail.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(0, 80);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(340, 25);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLogin
            // 
            this.labelLogin.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(0, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(340, 40);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelRegister
            // 
            this.labelRegister.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelRegister.ForeColor = System.Drawing.Color.White;
            this.labelRegister.Location = new System.Drawing.Point(0, 0);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(340, 40);
            this.labelRegister.TabIndex = 6;
            this.labelRegister.Text = "Register";
            this.labelRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword1
            // 
            this.labelPassword1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPassword1.ForeColor = System.Drawing.Color.White;
            this.labelPassword1.Location = new System.Drawing.Point(0, 135);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(340, 25);
            this.labelPassword1.TabIndex = 7;
            this.labelPassword1.Text = "Password";
            this.labelPassword1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtPassword1.Location = new System.Drawing.Point(0, 165);
            this.txtPassword1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(340, 37);
            this.txtPassword1.TabIndex = 8;
            this.txtPassword1.UseSystemPasswordChar = true;
            // 
            // btnRegister1
            // 
            this.btnRegister1.BackColor = System.Drawing.Color.White;
            this.btnRegister1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister1.Font = new System.Drawing.Font("Britannic Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegister1.Location = new System.Drawing.Point(0, 318);
            this.btnRegister1.Name = "btnRegister1";
            this.btnRegister1.Size = new System.Drawing.Size(340, 45);
            this.btnRegister1.TabIndex = 9;
            this.btnRegister1.Text = "Register";
            this.btnRegister1.UseVisualStyleBackColor = false;
            this.btnRegister1.Click += new System.EventHandler(this.btnRegister1_Click);
            // 
            // labelEmail1
            // 
            this.labelEmail1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelEmail1.ForeColor = System.Drawing.Color.White;
            this.labelEmail1.Location = new System.Drawing.Point(0, 60);
            this.labelEmail1.Name = "labelEmail1";
            this.labelEmail1.Size = new System.Drawing.Size(340, 25);
            this.labelEmail1.TabIndex = 10;
            this.labelEmail1.Text = "Email";
            this.labelEmail1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail1
            // 
            this.txtEmail1.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtEmail1.Location = new System.Drawing.Point(0, 90);
            this.txtEmail1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtEmail1.Name = "txtEmail1";
            this.txtEmail1.Size = new System.Drawing.Size(340, 37);
            this.txtEmail1.TabIndex = 11;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmPassword.Location = new System.Drawing.Point(0, 210);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(340, 25);
            this.labelConfirmPassword.TabIndex = 12;
            this.labelConfirmPassword.Text = "Confirm Password";
            this.labelConfirmPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Britannic Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(0, 240);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(340, 37);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin1
            // 
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLogin1.ForeColor = System.Drawing.Color.White;
            this.btnLogin1.Location = new System.Drawing.Point(104, 388);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.Size = new System.Drawing.Size(105, 32);
            this.btnLogin1.TabIndex = 14;
            this.btnLogin1.Text = "Log in";
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.btnLogin1_Click);
            // 
            // panel_register
            // 
            this.panel_register.Controls.Add(this.preLoader1);
            this.panel_register.Controls.Add(this.btnLogin1);
            this.panel_register.Controls.Add(this.txtConfirmPassword);
            this.panel_register.Controls.Add(this.labelConfirmPassword);
            this.panel_register.Controls.Add(this.txtEmail1);
            this.panel_register.Controls.Add(this.labelEmail1);
            this.panel_register.Controls.Add(this.btnRegister1);
            this.panel_register.Controls.Add(this.txtPassword1);
            this.panel_register.Controls.Add(this.labelPassword1);
            this.panel_register.Controls.Add(this.labelRegister);
            this.panel_register.Location = new System.Drawing.Point(20, 160);
            this.panel_register.Name = "panel_register";
            this.panel_register.Size = new System.Drawing.Size(340, 480);
            this.panel_register.TabIndex = 2;
            // 
            // preLoader1
            // 
            this.preLoader1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.preLoader1.BackColor = System.Drawing.SystemColors.Control;
            this.preLoader1.Image = ((System.Drawing.Image) (resources.GetObject("preLoader1.Image")));
            this.preLoader1.InitialImage = ((System.Drawing.Image) (resources.GetObject("preLoader1.InitialImage")));
            this.preLoader1.Location = new System.Drawing.Point(141, 208);
            this.preLoader1.Name = "preLoader1";
            this.preLoader1.Size = new System.Drawing.Size(50, 49);
            this.preLoader1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.preLoader1.TabIndex = 15;
            this.preLoader1.TabStop = false;
            this.preLoader1.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(384, 661);
            this.Controls.Add(this.panel_register);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picLoader)).EndInit();
            this.panel_register.ResumeLayout(false);
            this.panel_register.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.preLoader1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox preLoader1;

        private System.Windows.Forms.PictureBox picLoader;


        private System.Windows.Forms.Button btnLogin1;
        private System.Windows.Forms.Button btnRegister1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail1;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelConfirmPassword;

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEmail1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        
        private System.Windows.Forms.Panel panel_register;
        private System.Windows.Forms.Panel panel_login;

        #endregion
    }
}