namespace WindowsFormsApp2
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            txtbxUsername = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            txtbxPassword = new TextBox();
            chckShowPassword = new CheckBox();
            timerAnimation = new System.Windows.Forms.Timer(components);
            lblAnimatedText = new Label();
            SuspendLayout();
            // 
            // txtbxUsername
            // 
            txtbxUsername.BackColor = Color.WhiteSmoke;
            txtbxUsername.Location = new Point(92, 66);
            txtbxUsername.Margin = new Padding(4, 3, 4, 3);
            txtbxUsername.Name = "txtbxUsername";
            txtbxUsername.Size = new Size(227, 23);
            txtbxUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Linen;
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(92, 162);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(108, 45);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(92, 48);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(92, 115);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // txtbxPassword
            // 
            txtbxPassword.BackColor = Color.WhiteSmoke;
            txtbxPassword.Location = new Point(92, 133);
            txtbxPassword.Margin = new Padding(4, 3, 4, 3);
            txtbxPassword.Name = "txtbxPassword";
            txtbxPassword.PasswordChar = '*';
            txtbxPassword.Size = new Size(227, 23);
            txtbxPassword.TabIndex = 5;
            // 
            // chckShowPassword
            // 
            chckShowPassword.AutoSize = true;
            chckShowPassword.BackColor = Color.Transparent;
            chckShowPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chckShowPassword.ForeColor = Color.Yellow;
            chckShowPassword.Location = new Point(220, 188);
            chckShowPassword.Name = "chckShowPassword";
            chckShowPassword.Size = new Size(112, 19);
            chckShowPassword.TabIndex = 6;
            chckShowPassword.Text = "Show Password";
            chckShowPassword.UseVisualStyleBackColor = false;
            chckShowPassword.CheckedChanged += chckShowPassword_CheckedChanged;
            // 
            // lblAnimatedText
            // 
            lblAnimatedText.AutoSize = true;
            lblAnimatedText.BackColor = Color.Transparent;
            lblAnimatedText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAnimatedText.Location = new Point(63, 9);
            lblAnimatedText.Name = "lblAnimatedText";
            lblAnimatedText.Size = new Size(0, 28);
            lblAnimatedText.TabIndex = 7;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(422, 280);
            Controls.Add(lblAnimatedText);
            Controls.Add(chckShowPassword);
            Controls.Add(txtbxPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtbxUsername);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtbxPassword;
        private CheckBox chckShowPassword;
        private System.Windows.Forms.Timer timerAnimation;
        private Label lblAnimatedText;
    }
}