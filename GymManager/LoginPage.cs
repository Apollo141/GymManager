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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {
            if(usrnametxt.Text == "" && passwordtxt.Text == "")
            {
                MessageBox.Show("قم بادخال اسم المستخدم و الرمز السري");
            }
            else if(usrnametxt.Text =="ali" && passwordtxt.Text == "0000")
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او الرمز غير صالح","رسالة",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
           
        }

        private void usrnametxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
