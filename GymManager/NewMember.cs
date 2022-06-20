using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymManager
{
    public partial class NewMember : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");
        
        public NewMember()
        {
            InitializeComponent();
        }

        private void NewMember_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fname = fnametxt.Text;
            String lname = lnametxt.Text;
            String gender = "";
            bool isChecked = radiom.Checked;
            if (isChecked)
            {
                gender = radiom.Text;
            }

            else
            {
                gender = radiof.Text;
            }
            String dob = bdtime.Text;
            Int64 mobile = Int64.Parse(phonetxt.Text);
            String email = emailtxt.Text;
            String joinDate = subscribdate.Text;
            String gymTime = combogymtime.Text;
            String address = addresstxt.Text;
            String membership = combosubscribt.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into NewMember (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,GymTime,Maddress,MembershipTime) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joinDate + "','" + gymTime + "','" + address + "','" + membership + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            MessageBox.Show("تم حفظ البيانات بنجاح");
            
            
            connection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnametxt.Clear();
            lnametxt.Clear();
            radiom.Checked = false;
            radiof.Checked = false;


            bdtime.Value = DateTime.Now;
            phonetxt.Clear();
            emailtxt.Clear();
            subscribdate.Value = DateTime.Now;
            combogymtime.ResetText();
            addresstxt.Clear(); 
          combosubscribt.ResetText(); ;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
