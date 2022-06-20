
namespace GymManager
{
    partial class DeleteEmpolyees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEmpolyees));
            this.justOne = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeidtxtdelt = new System.Windows.Forms.TextBox();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // justOne
            // 
            this.justOne.BackColor = System.Drawing.Color.LightSalmon;
            this.justOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justOne.Image = ((System.Drawing.Image)(resources.GetObject("justOne.Image")));
            this.justOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.justOne.Location = new System.Drawing.Point(105, 167);
            this.justOne.Name = "justOne";
            this.justOne.Size = new System.Drawing.Size(278, 80);
            this.justOne.TabIndex = 55;
            this.justOne.Text = "حذف الموظف";
            this.justOne.UseVisualStyleBackColor = false;
            this.justOne.Click += new System.EventHandler(this.justOne_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(808, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "حذف بواسطة رقم الموظف";
            // 
            // employeeidtxtdelt
            // 
            this.employeeidtxtdelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeidtxtdelt.Location = new System.Drawing.Point(403, 193);
            this.employeeidtxtdelt.Name = "employeeidtxtdelt";
            this.employeeidtxtdelt.Size = new System.Drawing.Size(381, 30);
            this.employeeidtxtdelt.TabIndex = 50;
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Location = new System.Drawing.Point(12, 252);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.RowHeadersWidth = 51;
            this.dataGridMembers.RowTemplate.Height = 24;
            this.dataGridMembers.Size = new System.Drawing.Size(1175, 424);
            this.dataGridMembers.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(529, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 72);
            this.label4.TabIndex = 87;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(528, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "By : Ali Hashim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(447, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 24);
            this.label3.TabIndex = 86;
            this.label3.Text = "Supervisor : Dr. Dunia Hamid Hameed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(348, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 43);
            this.label5.TabIndex = 84;
            this.label5.Text = "Gym Managment System";
            // 
            // DeleteEmpolyees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(155)))), ((int)(((byte)(200)))));
            this.ClientSize = new System.Drawing.Size(1199, 688);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridMembers);
            this.Controls.Add(this.justOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeidtxtdelt);
            this.Name = "DeleteEmpolyees";
            this.Text = "DeleteEmpolyees";
            this.Load += new System.EventHandler(this.DeleteEmpolyees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button justOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox employeeidtxtdelt;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}