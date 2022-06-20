
namespace GymManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.signin = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.usrnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(197, 159);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Supervisor : Dr. Dunia Hamid Hameed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(277, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "By : Ali Hashim";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Georgia", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Crimson;
            this.label11.Location = new System.Drawing.Point(80, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(518, 43);
            this.label11.TabIndex = 54;
            this.label11.Text = "Gym Managment System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Controls.Add(this.passwordtxt);
            this.panel1.Controls.Add(this.usrnametxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(318, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(679, 591);
            this.panel1.TabIndex = 57;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(278, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 72);
            this.label4.TabIndex = 63;
            // 
            // signin
            // 
            this.signin.BackColor = System.Drawing.Color.PaleGreen;
            this.signin.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.Image = ((System.Drawing.Image)(resources.GetObject("signin.Image")));
            this.signin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.signin.Location = new System.Drawing.Point(201, 460);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(268, 82);
            this.signin.TabIndex = 62;
            this.signin.Text = "تسجيل ألدخول";
            this.signin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.signin.UseVisualStyleBackColor = false;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.Color.DarkSalmon;
            this.passwordtxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.passwordtxt.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(113, 371);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(312, 46);
            this.passwordtxt.TabIndex = 61;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // usrnametxt
            // 
            this.usrnametxt.BackColor = System.Drawing.Color.LightSteelBlue;
            this.usrnametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.usrnametxt.Font = new System.Drawing.Font("Simplified Arabic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrnametxt.Location = new System.Drawing.Point(113, 286);
            this.usrnametxt.Name = "usrnametxt";
            this.usrnametxt.Size = new System.Drawing.Size(312, 46);
            this.usrnametxt.TabIndex = 60;
            this.usrnametxt.TextChanged += new System.EventHandler(this.usrnametxt_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(443, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 68);
            this.label3.TabIndex = 59;
            this.label3.Text = "ألرمز السري";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Simplified Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(443, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 68);
            this.label2.TabIndex = 58;
            this.label2.Text = "أسم المستخدم";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label1.Location = new System.Drawing.Point(170, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 57;
            this.label1.Text = "تسجيل دخول الجيم";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1352, 723);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox usrnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.Label label4;
    }
}