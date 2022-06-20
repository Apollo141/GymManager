
namespace GymManager
{
    partial class NewMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMember));
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.radiom = new System.Windows.Forms.RadioButton();
            this.radiof = new System.Windows.Forms.RadioButton();
            this.bdtime = new System.Windows.Forms.DateTimePicker();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.subscribdate = new System.Windows.Forms.DateTimePicker();
            this.addresstxt = new System.Windows.Forms.RichTextBox();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.combosubscribt = new System.Windows.Forms.ComboBox();
            this.combogymtime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fnametxt
            // 
            this.fnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnametxt.Location = new System.Drawing.Point(544, 198);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(210, 28);
            this.fnametxt.TabIndex = 0;
            // 
            // lnametxt
            // 
            this.lnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnametxt.Location = new System.Drawing.Point(544, 278);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(210, 28);
            this.lnametxt.TabIndex = 1;
            // 
            // radiom
            // 
            this.radiom.AutoSize = true;
            this.radiom.BackColor = System.Drawing.Color.Transparent;
            this.radiom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiom.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radiom.Location = new System.Drawing.Point(580, 352);
            this.radiom.Name = "radiom";
            this.radiom.Size = new System.Drawing.Size(61, 29);
            this.radiom.TabIndex = 2;
            this.radiom.TabStop = true;
            this.radiom.Text = "ذكر";
            this.radiom.UseVisualStyleBackColor = false;
            this.radiom.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radiof
            // 
            this.radiof.AutoSize = true;
            this.radiof.BackColor = System.Drawing.Color.Transparent;
            this.radiof.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiof.ForeColor = System.Drawing.Color.Crimson;
            this.radiof.Location = new System.Drawing.Point(647, 351);
            this.radiof.Name = "radiof";
            this.radiof.Size = new System.Drawing.Size(63, 29);
            this.radiof.TabIndex = 3;
            this.radiof.TabStop = true;
            this.radiof.Text = "انثى";
            this.radiof.UseVisualStyleBackColor = false;
            this.radiof.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // bdtime
            // 
            this.bdtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdtime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bdtime.Location = new System.Drawing.Point(544, 439);
            this.bdtime.Name = "bdtime";
            this.bdtime.Size = new System.Drawing.Size(210, 27);
            this.bdtime.TabIndex = 4;
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(12, 195);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(210, 28);
            this.emailtxt.TabIndex = 5;
            // 
            // subscribdate
            // 
            this.subscribdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscribdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.subscribdate.Location = new System.Drawing.Point(12, 275);
            this.subscribdate.Name = "subscribdate";
            this.subscribdate.Size = new System.Drawing.Size(210, 27);
            this.subscribdate.TabIndex = 6;
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(12, 408);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(210, 73);
            this.addresstxt.TabIndex = 9;
            this.addresstxt.Text = "";
            // 
            // phonetxt
            // 
            this.phonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonetxt.Location = new System.Drawing.Point(544, 540);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(210, 28);
            this.phonetxt.TabIndex = 10;
            // 
            // combosubscribt
            // 
            this.combosubscribt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combosubscribt.FormattingEnabled = true;
            this.combosubscribt.Items.AddRange(new object[] {
            "أشتراك يوم",
            "أشتراك شهر",
            "أشتراك 3 اشهر",
            "أشتراك 6 اشهر",
            "أشتراك سنة"});
            this.combosubscribt.Location = new System.Drawing.Point(12, 535);
            this.combosubscribt.Name = "combosubscribt";
            this.combosubscribt.Size = new System.Drawing.Size(210, 30);
            this.combosubscribt.TabIndex = 11;
            // 
            // combogymtime
            // 
            this.combogymtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combogymtime.FormattingEnabled = true;
            this.combogymtime.Items.AddRange(new object[] {
            "8AM-10AM",
            "10AM-2PM",
            "2PM-5PM",
            "5PM-8PM",
            "8PM-11PM"});
            this.combogymtime.Location = new System.Drawing.Point(12, 350);
            this.combogymtime.Name = "combogymtime";
            this.combogymtime.Size = new System.Drawing.Size(210, 30);
            this.combogymtime.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(774, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 77);
            this.label1.TabIndex = 13;
            this.label1.Text = "الأسم الاول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(774, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 77);
            this.label2.TabIndex = 14;
            this.label2.Text = "أسم الأب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(774, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 77);
            this.label3.TabIndex = 15;
            this.label3.Text = "الجنس";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MediumBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(774, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 77);
            this.label4.TabIndex = 16;
            this.label4.Text = "تاريخ الميلاد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(774, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(240, 77);
            this.label5.TabIndex = 17;
            this.label5.Text = "رقم الهاتف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MediumBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(228, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 77);
            this.label6.TabIndex = 18;
            this.label6.Text = " البريد الألكتروني";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MediumBlue;
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(232, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 77);
            this.label7.TabIndex = 19;
            this.label7.Text = "تاريخ التسجيل";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(236, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 77);
            this.label8.TabIndex = 20;
            this.label8.Text = "وقت التمارين";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MediumBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(236, 416);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 77);
            this.label9.TabIndex = 21;
            this.label9.Text = "العنوان";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.LightGreen;
            this.savebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Image = ((System.Drawing.Image)(resources.GetObject("savebutton.Image")));
            this.savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.savebutton.Location = new System.Drawing.Point(339, 593);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(174, 88);
            this.savebutton.TabIndex = 22;
            this.savebutton.Text = "حفظ ";
            this.savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.LightCoral;
            this.resetbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutton.Image = ((System.Drawing.Image)(resources.GetObject("resetbutton.Image")));
            this.resetbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.resetbutton.Location = new System.Drawing.Point(544, 593);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(174, 88);
            this.resetbutton.TabIndex = 23;
            this.resetbutton.Text = "أعادة تعيين";
            this.resetbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Goudy Stout", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(240, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(243, 77);
            this.label10.TabIndex = 24;
            this.label10.Text = "مدة الأشتراك";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(448, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 72);
            this.label11.TabIndex = 79;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(447, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 24);
            this.label12.TabIndex = 77;
            this.label12.Text = "By : Ali Hashim";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(366, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(304, 24);
            this.label13.TabIndex = 78;
            this.label13.Text = "Supervisor : Dr. Dunia Hamid Hameed";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Georgia", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Crimson;
            this.label14.Location = new System.Drawing.Point(267, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(518, 43);
            this.label14.TabIndex = 76;
            this.label14.Text = "Gym Managment System";
            // 
            // NewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 701);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combogymtime);
            this.Controls.Add(this.combosubscribt);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.subscribdate);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.bdtime);
            this.Controls.Add(this.radiof);
            this.Controls.Add(this.radiom);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.fnametxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewMember";
            this.Load += new System.EventHandler(this.NewMember_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.RadioButton radiom;
        private System.Windows.Forms.RadioButton radiof;
        private System.Windows.Forms.DateTimePicker bdtime;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.DateTimePicker subscribdate;
        private System.Windows.Forms.RichTextBox addresstxt;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.ComboBox combosubscribt;
        private System.Windows.Forms.ComboBox combogymtime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}