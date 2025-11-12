namespace kasir_toko_elektronik
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gbLogin = new GroupBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtPassword);
            gbLogin.Controls.Add(txtUsername);
            gbLogin.Controls.Add(lblPassword);
            gbLogin.Controls.Add(lblUsername);
            gbLogin.Font = new Font("SimSun", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gbLogin.ForeColor = SystemColors.Highlight;
            gbLogin.Location = new Point(160, 145);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new Size(486, 259);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(191, 184);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(195, 127);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(210, 28);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(195, 59);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(210, 28);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(56, 130);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(80, 18);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(56, 62);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(80, 18);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 541);
            Controls.Add(gbLogin);
            Name = "FormLogin";
            Text = "Login";
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label lblPassword;
        private Label lblUsername;
        private Button btnLogin;
    }
}
