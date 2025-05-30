namespace InventorySystem1._0
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.lblCaptcha = new System.Windows.Forms.Label();
            this.pictureBoxCaptcha = new System.Windows.Forms.PictureBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.BackColor = System.Drawing.Color.FromArgb(36, 37, 42);
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panelCard.Controls.Add(this.lblWarning);
            this.panelCard.Controls.Add(this.Button3);
            this.panelCard.Controls.Add(this.Button2);
            this.panelCard.Controls.Add(this.Button1);
            this.panelCard.Controls.Add(this.txtCaptcha);
            this.panelCard.Controls.Add(this.lblCaptcha);
            this.panelCard.Controls.Add(this.pictureBoxCaptcha);
            this.panelCard.Controls.Add(this.txtpass);
            this.panelCard.Controls.Add(this.Label2);
            this.panelCard.Controls.Add(this.txtusername);
            this.panelCard.Controls.Add(this.Label1);
            this.panelCard.Location = new System.Drawing.Point(40, 60);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(340, 340);
            this.panelCard.TabIndex = 0;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.lblWarning.Location = new System.Drawing.Point(20, 300);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 10;
            // 
            // Button3 (Close)
            // 
            this.Button3.BackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.Button3.FlatAppearance.BorderSize = 0;
            this.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.Location = new System.Drawing.Point(230, 260);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(90, 32);
            this.Button3.TabIndex = 9;
            this.Button3.Text = "Close";
            this.Button3.UseVisualStyleBackColor = false;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2 (Clear)
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(60, 63, 65);
            this.Button2.FlatAppearance.BorderSize = 0;
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(125, 260);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(90, 32);
            this.Button2.TabIndex = 8;
            this.Button2.Text = "Clear";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1 (Login)
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
            this.Button1.FlatAppearance.BorderSize = 0;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.Location = new System.Drawing.Point(20, 260);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(90, 32);
            this.Button1.TabIndex = 7;
            this.Button1.Text = "Login";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptcha.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCaptcha.ForeColor = System.Drawing.Color.White;
            this.txtCaptcha.Location = new System.Drawing.Point(20, 210);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(140, 25);
            this.txtCaptcha.TabIndex = 5;
            // 
            // lblCaptcha
            // 
            this.lblCaptcha.AutoSize = true;
            this.lblCaptcha.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCaptcha.ForeColor = System.Drawing.Color.White;
            this.lblCaptcha.Location = new System.Drawing.Point(20, 190);
            this.lblCaptcha.Name = "lblCaptcha";
            this.lblCaptcha.Size = new System.Drawing.Size(108, 19);
            this.lblCaptcha.TabIndex = 4;
            this.lblCaptcha.Text = "Enter Captcha:";
            // 
            // pictureBoxCaptcha
            // 
            this.pictureBoxCaptcha.BackColor = System.Drawing.Color.White;
            this.pictureBoxCaptcha.Location = new System.Drawing.Point(170, 210);
            this.pictureBoxCaptcha.Name = "pictureBoxCaptcha";
            this.pictureBoxCaptcha.Size = new System.Drawing.Size(150, 25);
            this.pictureBoxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCaptcha.TabIndex = 6;
            this.pictureBoxCaptcha.TabStop = false;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(20, 140);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(300, 25);
            this.txtpass.TabIndex = 3;
            this.txtpass.UseSystemPasswordChar = true;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(20, 120);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(76, 19);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(50, 50, 55);
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(20, 80);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(300, 25);
            this.txtusername.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(20, 60);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(81, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Username:";
            // 
            // PictureBox1 (Logo)
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(160, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 1;
            this.PictureBox1.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lbldate.ForeColor = System.Drawing.Color.Gray;
            this.lbldate.Location = new System.Drawing.Point(10, 420);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(36, 15);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date:";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.lbltime.ForeColor = System.Drawing.Color.Gray;
            this.lbltime.Location = new System.Drawing.Point(370, 420);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(36, 15);
            this.lbltime.TabIndex = 3;
            this.lbltime.Text = "Time:";
            // 
            // frmLogin
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(28, 28, 30);
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        internal System.Windows.Forms.Label lblWarning;
        internal System.Windows.Forms.Button Button3;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox txtCaptcha;
        internal System.Windows.Forms.Label lblCaptcha;
        internal System.Windows.Forms.PictureBox pictureBoxCaptcha;
        internal System.Windows.Forms.TextBox txtpass;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Timer Timer1;
        internal System.Windows.Forms.Label lbldate;
        internal System.Windows.Forms.Label lbltime;
    }
}