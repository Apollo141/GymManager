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
    public partial class SearchForEquipments : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");

        public SearchForEquipments()
        {
            InitializeComponent();
        }

        private void SearchForEquipments_Load(object sender, EventArgs e)
        {
            publicaz();
        }
        private void publicaz()
        {
            connection.Open();
            string query = "select * from Equipment";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var dst = new DataSet();
            adapter.Fill(dst);
            dataGridMembers.DataSource = dst.Tables[0];
            connection.Close();
            dataGridMembers.Columns[5].Width = 350;

        }

        private void justOne_Click(object sender, EventArgs e)
        {
            if (equipmentidtxt.Text != "")
            {
                connection.Open();
                string query = "select * from Equipment where EID=" + equipmentidtxt.Text + "";
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

        private void wholeThing_Click(object sender, EventArgs e)
        {
            publicaz();
            equipmentidtxt.Clear();
        }
    }
}
