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
    public partial class Equipments : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ABOODY\SQLEXPRESS;Initial Catalog=gym;Integrated Security=True");

        public Equipments()
        {
            InitializeComponent();
        }

        private void Equipments_Load(object sender, EventArgs e)
        {

        }

        private void saveequipbutton_Click(object sender, EventArgs e)
        {
            String equipName = equipnametxt.Text;
            String muscleUsed = muscletxt.Text;
        
           
            String equipDateOfDelv = deliverydate.Text;
            Int64 price = Int64.Parse(equippricetxt.Text);
            
            String description = abouttxt.Text;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "insert into Equipment (EqupmentName,MuscleUsed,Edate,Ecost,EquipDescrpt) values ('" + equipName + "','" + muscleUsed + "','" + equipDateOfDelv + "','" + price + "','" + description + "')";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            MessageBox.Show("تم حفظ البيانات بنجاح","تم الادخال",MessageBoxButtons.OK,MessageBoxIcon.Information);


            connection.Close();

        }

        private void resetquipbutton_Click(object sender, EventArgs e)
        {
            equipnametxt.Clear();
            muscletxt.Clear();
         
             deliverydate.Value = DateTime.Now;
            equippricetxt.Clear();
            abouttxt.Clear();
            
        }

        private void quipshowbutt_Click(object sender, EventArgs e)
        {
          
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
