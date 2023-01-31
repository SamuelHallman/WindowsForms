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
using WindowsFormsApp2.Models;

namespace WindowsFormsApp2
{
    public partial class task : Form
    {
        readonly OleDbConnection connection;
        readonly TaskButton button;

        public bool WindowIsRaised { get; set; }
        
        public task(TaskButton button, OleDbConnection connection)
        {
            InitializeComponent();

            this.button = button;
            this.connection = connection;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!WindowIsRaised)
            {
                Teamview TeamviewForm = new Teamview(connection);
                TeamviewForm.Show(this);
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string contentTopic = textBox2.Text;
                string query = $"INSERT INTO Tasks(Task_Name, status) VALUES ('{contentTopic}', {contentTopic})"; // Lisättävän datan query

                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                e.Handled = true;
            }
        }
    }
}
