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
    public partial class Employees : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");

        public Employees()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            String fname = empfnametxt.Text;
            String lname = emplnametxt.Text;
            String gender = "";
            bool isChecked = radioempm.Checked;
            if (isChecked)
            {
                gender  =radioempm.Text;
            }

            else
            {
                gender = radioempf.Text;
            }
            String dob = empbddate.Text;
            Int64 mobile = Int64.Parse(empphonetxt.Text);
            String email = empemailtxt.Text;
            String joinDate = empjoindate.Text;
            String city = empcitytxt.Text;
            String area = empareatxt.Text; 
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into NewStaff (Fname,Lname,Gender,Dob,Mobile,Email,JoinDate,Area,City) values ('" + fname + "','" + lname + "','" + gender + "','" + dob + "','" + mobile + "','" + email + "','" + joinDate + "','" + area + "','" + city + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            MessageBox.Show("تم حفظ البيانات بنجاح");


            connection.Close();
        }

        private void resetbutton_Click(object sender, EventArgs e)
        {
            empfnametxt.Clear();
            emplnametxt.Clear();
             radioempm.Checked = false;
            radioempf.Checked = false;
            empbddate.Value = DateTime.Now;
            empphonetxt.Clear();
            empemailtxt.Clear();
            empjoindate.Value = DateTime.Now;
            empareatxt.Clear();
            empcitytxt.ResetText(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
    }
}
