using RecordShopService.DTOs;
using RecordShopService.Services;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Login : Form
    {
        private readonly AlbumService albumService;
        private readonly AdminService adminService;
        private readonly ReportService reportService;
        private readonly LoginService loginService;

        private string typewriterText = "WELCOME TO RECORD SHOP!";
        private int typewriterIndex = 0;

        public Login(AlbumService albumService, AdminService adminService, ReportService reportService, LoginService loginService)
        {
            InitializeComponent();
            this.albumService = albumService;
            this.adminService = adminService;
            this.reportService = reportService;
            this.loginService = loginService;
            txtbxPassword.PasswordChar = '*';
            chckShowPassword.CheckedChanged += chckShowPassword_CheckedChanged;

            timerAnimation.Interval = 100;
            timerAnimation.Tick += timerAnimation_Tick;
            timerAnimation.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtbxUsername.Text;
                string password = txtbxPassword.Text;

                bool isValidUser = loginService.ValidateUser(userName, password);

                if (isValidUser)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 mainForm = new Form1(albumService, adminService, reportService, loginService);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chckShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chckShowPassword.Checked)
            {
                txtbxPassword.PasswordChar = '\0';
            }
            else
            {
                txtbxPassword.PasswordChar = '*';
            }
        }

        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            
            if (typewriterIndex < typewriterText.Length)
            {
                lblAnimatedText.Text += typewriterText[typewriterIndex];
                typewriterIndex++;
            }
            else
            {
                timerAnimation.Stop();
            }

        }
    }
}
