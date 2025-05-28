using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem1._0.Includes;

namespace InventorySystem1._0
{
    public partial class frmLogin : Form
    {
        Form1 frm;
        private string generatedCaptcha;
        private int loginAttempts = 0;
        private int lockoutSeconds = 300; // 5 minutes
        private int lockoutCounter = 0;
        private Timer lockoutTimer = new Timer();
        SQLConfig config = new SQLConfig();
        string sql;

        public frmLogin(Form1 frm)
        {
            InitializeComponent();
            this.frm = frm;
            lockoutTimer.Interval = 1000; // 1 second
            lockoutTimer.Tick += LockoutTimer_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToShortTimeString();
            lbldate.Text = DateTime.Now.ToShortDateString();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Timer1.Start();
            GenerateCaptcha();
            lblWarning.Text = "";
            loginAttempts = 0;
            Button1.Enabled = true;
            lockoutTimer.Stop();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpass.Text) || string.IsNullOrWhiteSpace(txtCaptcha.Text))
            {
                lblWarning.Text = "All fields are required.";
                return;
            }

            // Captcha check
            if (txtCaptcha.Text != generatedCaptcha)
            {
                loginAttempts++;
                lblWarning.Text = $"Invalid captcha. Attempt {loginAttempts}/3.";
                GenerateCaptcha();
                txtCaptcha.Clear();
                LogAudit(txtusername.Text, false);
                CheckLockout();
                return;
            }

            sql = "SELECT * FROM user WHERE user_name = '" + txtusername.Text + "' and pass = sha1('" + txtpass.Text + "')";
            config.singleResult(sql);

            bool loginSuccess = config.dt.Rows.Count > 0;
            LogAudit(txtusername.Text, loginSuccess);

            if (loginSuccess)
            {
                string userType = config.dt.Rows[0]["type"].ToString();
                frm.SetUserType(userType); // Call a new method in Form1
                frm.enabled_menu();
                this.Close();
            }
            else
            {
                loginAttempts++;
                lblWarning.Text = $"Invalid username or password. Attempt {loginAttempts}/3.";
                GenerateCaptcha();
                txtCaptcha.Clear();
                CheckLockout();
            }
        }

        private void CheckLockout()
        {
            if (loginAttempts >= 3)
            {
                Button1.Enabled = false;
                lockoutCounter = lockoutSeconds;
                lblWarning.Text = $"Too many failed attempts. Login disabled for 5 minutes.";
                lockoutTimer.Start();
            }
        }

        private void LockoutTimer_Tick(object sender, EventArgs e)
        {
            lockoutCounter--;
            lblWarning.Text = $"Login disabled. Please wait {lockoutCounter} seconds.";
            if (lockoutCounter <= 0)
            {
                lockoutTimer.Stop();
                loginAttempts = 0;
                Button1.Enabled = true;
                lblWarning.Text = "";
                GenerateCaptcha();
                txtCaptcha.Clear();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtusername.Clear();
            txtCaptcha.Clear();
            txtusername.Focus();
            lblWarning.Text = "";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GenerateCaptcha()
        {
            Random rand = new Random();
            generatedCaptcha = rand.Next(1000, 9999).ToString();
            Bitmap bmp = new Bitmap(100, 40);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                g.DrawString(generatedCaptcha, new Font("Arial", 20), Brushes.Black, 10, 5);
            }
            pictureBoxCaptcha.Image = bmp;
        }

        private void LogAudit(string username, bool success)
        {
            string status = success ? "Success" : "Failed";
            string logSql = $"INSERT INTO login_audit (username, attempt_time, status) VALUES ('{username}', NOW(), '{status}')";
            config.Execute_Query(logSql);
        }
    }
}