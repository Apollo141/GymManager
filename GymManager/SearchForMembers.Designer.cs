
namespace GymManager
{
    partial class SearchForMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForMembers));
            this.memberidtxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.justOne = new System.Windows.Forms.Button();
            this.wholeThing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // memberidtxt
            // 
            this.memberidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberidtxt.Location = new System.Drawing.Point(392, 177);
            this.memberidtxt.Name = "memberidtxt";
            this.memberidtxt.Size = new System.Drawing.Size(381, 30);
            this.memberidtxt.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "بحث بواسطة رقم العميل";
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Location = new System.Drawing.Point(12, 281);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.RowHeadersWidth = 51;
            this.dataGridMembers.RowTemplate.Height = 24;
            this.dataGridMembers.Size = new System.Drawing.Size(1175, 395);
            this.dataGridMembers.TabIndex = 40;
            // 
            // justOne
            // 
            this.justOne.BackColor = System.Drawing.Color.GreenYellow;
            this.justOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justOne.Image = ((System.Drawing.Image)(resources.GetObject("justOne.Image")));
            this.justOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.justOne.Location = new System.Drawing.Point(74, 104);
            this.justOne.Name = "justOne";
            this.justOne.Size = new System.Drawing.Size(278, 70);
            this.justOne.TabIndex = 41;
            this.justOne.Text = "أبحث عن رقم العميل";
            this.justOne.UseVisualStyleBackColor = false;
            this.justOne.Click += new System.EventHandler(this.justOne_Click);
            // 
            // wholeThing
            // 
            this.wholeThing.BackColor = System.Drawing.Color.Plum;
            this.wholeThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholeThing.Image = ((System.Drawing.Image)(resources.GetObject("wholeThing.Image")));
            this.wholeThing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.wholeThing.Location = new System.Drawing.Point(74, 203);
            this.wholeThing.Name = "wholeThing";
            this.wholeThing.Size = new System.Drawing.Size(278, 70);
            this.wholeThing.TabIndex = 42;
            this.wholeThing.Text = "اظهار جميع البيانات";
            this.wholeThing.UseVisualStyleBackColor = false;
            this.wholeThing.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(515, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 72);
            this.label4.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(514, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 69;
            this.label2.Text = "By : Ali Hashim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(433, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 24);
            this.label3.TabIndex = 70;
            this.label3.Text = "Supervisor : Dr. Dunia Hamid Hameed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(334, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 43);
            this.label5.TabIndex = 68;
            this.label5.Text = "Gym Managment System";
            // 
            // SearchForMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(238)))), ((int)(((byte)(202)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1199, 688);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.wholeThing);
            this.Controls.Add(this.justOne);
            this.Controls.Add(this.dataGridMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.memberidtxt);
            this.Name = "SearchForMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchUp";
            this.Load += new System.EventHandler(this.SearchForMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox memberidtxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.Button justOne;
        private System.Windows.Forms.Button wholeThing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}