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
    public partial class DeleteMembers : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");
        private void justOne_Click(object sender, EventArgs e)
        {

        }

        private void DeleteMembers_Load(object sender, EventArgs e)
        {
            publicaz();
        }

        public DeleteMembers()
        {
            InitializeComponent();
        }
        private void publicaz()
        {
            connection.Open();
            string query = "select * from NewMember";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dst = new DataSet();
            adapter.Fill(dst);
            dataGridMembers.DataSource = dst.Tables[0];
            connection.Close();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            if (memberidtxtdelt.Text != "")
            {
                DialogResult resl = MessageBox.Show(" هل انت متاكد", "رسالة", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resl == DialogResult.Yes)
                {
                    connection.Open();
                    string query = "delete from NewMember where MID=" + memberidtxtdelt.Text + "";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder();
                    var dst = new DataSet();
                    adapter.Fill(dst);
                    connection.Close();
                    publicaz();
                }
                else
                {
                    //could be used not sure
                    //this.Activate();
                    publicaz();
                }
            }
            else
            {
                MessageBox.Show("رجاء ادخال رقم العميل ", "رسالة", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
