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
    public partial class ChooseSearch : Form
    {
        public ChooseSearch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchForMembers search = new SearchForMembers();
            search.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            SearchForMembers search = new SearchForMembers();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SearchForEmployees search = new SearchForEmployees();
            search.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            SearchForEmployees search = new SearchForEmployees();
            search.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SearchForEquipments search = new SearchForEquipments();
            search.Show();
        }
    }
}
