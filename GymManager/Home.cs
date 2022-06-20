using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        Boolean b = true;

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(b == true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                toolstrip.Image = Image.FromFile(@"D:\Work Projects\GymManager\pics\rightar.png");

            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolstrip.Image = Image.FromFile(@"D:\Work Projects\GymManager\pics\downar.png");

            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolstrip.Image = Image.FromFile(@"D:\Work Projects\GymManager\pics\downar.png");
        }

        private void الأعضاءالجددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewMember newMember = new NewMember();
            
            newMember.Show();
        }

        private void الموظفينالجددToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employees employees = new Employees();

            employees.Show();
        }

        private void المعداتالرياضيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipments equipments = new Equipments();
            equipments.Show();
        }

        private void البحثعنالاعضاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseSearch search = new ChooseSearch();
            search.Show();
        }

        private void حذفالأعضاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseDelete chooseDelete = new ChooseDelete();
            chooseDelete.Show();
        }

        private void غلقالبرنامجToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult resl = MessageBox.Show(" هل انت متاكد من الخروج؟", "اغلاق البرنامج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resl == DialogResult.Yes)
            {

                Application.Exit();

            }
          
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resl = MessageBox.Show(" هل انت متاكد من تسجيل الخروج؟", "تسجيل الخروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resl == DialogResult.Yes)
            {

                LoginPage login = new LoginPage();
                this.Close();
                login.Show();

            }
      
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
