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
    public partial class SearchForEmployees : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");

        public SearchForEmployees()
        {
            InitializeComponent();
        }

        private void justOne_Click(object sender, EventArgs e)
        {
            if (employeeidtxt.Text != "")
            {
                connection.Open();
                string query = "select * from NewStaff where SID=" + employeeidtxt.Text + "";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder();
                var dst = new DataSet();
                adapter.Fill(dst);
                dataGridMembers.DataSource = dst.Tables[0];
                connection.Close();
            }
            else
            {
                MessageBox.Show("رجاء ادخال رقم العميل ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

        }
        private void publicaz()
        {
            connection.Open();
            string query = "select * from NewStaff";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dst = new DataSet();
            adapter.Fill(dst);
            dataGridMembers.DataSource = dst.Tables[0];
            connection.Close();
        }
        private void SearchForEmployees_Load(object sender, EventArgs e)
        {
            publicaz();
        }

        private void wholeThing_Click(object sender, EventArgs e)
        {
            publicaz();
            employeeidtxt.Clear();
        }

        private void dataGridMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
