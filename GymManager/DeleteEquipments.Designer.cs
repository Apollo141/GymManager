
namespace GymManager
{
    partial class DeleteEquipments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteEquipments));
            this.label1 = new System.Windows.Forms.Label();
            this.eqwuipmentidtxtdelt = new System.Windows.Forms.TextBox();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.justOne = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(797, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "حذف بواسطة رقم الأداة";
            // 
            // eqwuipmentidtxtdelt
            // 
            this.eqwuipmentidtxtdelt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqwuipmentidtxtdelt.Location = new System.Drawing.Point(392, 198);
            this.eqwuipmentidtxtdelt.Name = "eqwuipmentidtxtdelt";
            this.eqwuipmentidtxtdelt.Size = new System.Drawing.Size(381, 30);
            this.eqwuipmentidtxtdelt.TabIndex = 50;
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Location = new System.Drawing.Point(12, 258);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.RowHeadersWidth = 51;
            this.dataGridMembers.RowTemplate.Height = 24;
            this.dataGridMembers.Size = new System.Drawing.Size(1175, 433);
            this.dataGridMembers.TabIndex = 57;
            this.dataGridMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMembers_CellContentClick);
            // 
            // justOne
            // 
            this.justOne.BackColor = System.Drawing.Color.LightSalmon;
            this.justOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.justOne.Image = ((System.Drawing.Image)(resources.GetObject("justOne.Image")));
            this.justOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.justOne.Location = new System.Drawing.Point(99, 172);
            this.justOne.Name = "justOne";
            this.justOne.Size = new System.Drawing.Size(278, 80);
            this.justOne.TabIndex = 58;
            this.justOne.Text = "حذف الأداة";
            this.justOne.UseVisualStyleBackColor = false;
            this.justOne.Click += new System.EventHandler(this.justOne_Click);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(533, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 72);
            this.label4.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(532, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 81;
            this.label2.Text = "By : Ali Hashim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(451, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(304, 24);
            this.label3.TabIndex = 82;
            this.label3.Text = "Supervisor : Dr. Dunia Hamid Hameed";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Georgia", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(352, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(518, 43);
            this.label5.TabIndex = 80;
            this.label5.Text = "Gym Managment System";
            // 
            // DeleteEquipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(227)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1199, 688);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.justOne);
            this.Controls.Add(this.dataGridMembers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eqwuipmentidtxtdelt);
            this.Name = "DeleteEquipments";
            this.Text = "DeleteEquipments";
            this.Load += new System.EventHandler(this.DeleteEquipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox eqwuipmentidtxtdelt;
        private System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.Button justOne;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}