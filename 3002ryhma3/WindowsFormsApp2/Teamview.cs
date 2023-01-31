using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Teamview : Form
    {
        readonly OleDbConnection connection;

        public Teamview(OleDbConnection connection)
        {
            InitializeComponent();

            this.connection = connection;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string contentTopic = textBox1.Text;
            int priorityStatus = Convert.ToInt32(comboBox1.Text);
            string query = $"INSERT INTO Teams(Team_name, Project_Priorities) VALUES ('{contentTopic}', {priorityStatus})";

            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {

        }

        private void Teamview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ketterakantaDataSet.Persons' table. You can move, or remove it, as needed.
            this.personsTableAdapter.Fill(this.ketterakantaDataSet.Persons);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
