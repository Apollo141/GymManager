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
    public partial class DeleteEmpolyees : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");

        public DeleteEmpolyees()
        {
            InitializeComponent();
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
        private void justOne_Click(object sender, EventArgs e)
        {
            if (employeeidtxtdelt.Text != "")
            {
                DialogResult resl = MessageBox.Show(" هل انت متاكد", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resl == DialogResult.Yes)
                {
                    connection.Open();
                    string query = "delete from NewStaff where SID=" + employeeidtxtdelt.Text + "";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder();
                    var dst = new DataSet();
                    adapter.Fill(dst);
                    connection.Close();
                    publicaz();
                }
                else
                {
                    publicaz();
                }
            }
            else
            {
                MessageBox.Show("رجاء ادخال رقم العميل ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void DeleteEmpolyees_Load(object sender, EventArgs e)
        {
            publicaz();
        }
    }
}
