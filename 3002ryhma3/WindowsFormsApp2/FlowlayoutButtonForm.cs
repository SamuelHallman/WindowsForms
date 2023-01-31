using Newtonsoft.Json;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;


namespace WindowsFormsApp2
{
    public partial class FlowlayoutButtonForm : Form
    {
        readonly Form parentForm;
        readonly OleDbConnection connection;
        readonly UserstoryButton button;
        readonly int projectid;

        public bool WindowIsRaised { get; private set; }
        
        Timer timer = new Timer()
        {
            Interval = 200
        };

        public FlowlayoutButtonForm(Form parentForm, OleDbConnection connection, UserstoryButton button, int projectID)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            this.connection = connection;
            this.button = button;
            this.projectid = projectID;

            MaximizeBox = false;
            MinimizeBox = false;

            timer.Tick += Timer_Tick;
        }
        
        private void FlowlayoutButtonForm_Load_1(object sender, EventArgs e)
        {
            PopulateStories(button.Userstory.StoryID);
            
            storyName_Label.Text = button.Userstory.Name;
        }

        Point previousMouseLocation = Point.Empty;
        TaskButton pressedButton = null;

        private void Timer_Tick(object sender, EventArgs e) // Timeri joka...
        {
            if (previousMouseLocation != Point.Empty && pressedButton != null)
            {
                if (previousMouseLocation != MousePosition)
                {
                    string jsonString = JsonConvert.SerializeObject(new DraggableTaskData()
                    {
                        TaskID = pressedButton.Task.TaskID.ToString(),
                        Status = pressedButton.Task.Status.ToString()
                    });

                    pressedButton.DoDragDrop(jsonString, DragDropEffects.Move);

                }
                else if (!WindowIsRaised)
                {
                    task flowlayoutButtonForm = new task(pressedButton,connection);
                    flowlayoutButtonForm.Show(this);
                }

                previousMouseLocation = Point.Empty;
                pressedButton = null;
            }

            timer.Stop();
        }

        public void PopulateStories(int storyid) // Täydennetään paneelit tiedolla
        {

            foreach (TaskButton button in ToBeDone_Paneeli.Controls)
            {
                button.Enabled = false;
                button.Dispose();
            }
            ToBeDone_Paneeli.Controls.Clear();

            foreach (TaskButton button in InProcess_Paneeli.Controls)
            {
                button.Enabled = false;
                button.Dispose();
            }
            InProcess_Paneeli.Controls.Clear();

            foreach (TaskButton button in TaskDone_Paneeli.Controls)
            {
                button.Enabled = false;
                button.Dispose();
            }
            TaskDone_Paneeli.Controls.Clear();


            string query = $"SELECT TaskID, Task_Name, TaskDescription, Status, Priority FROM Tasks WHERE FK_StoryID = {storyid}";
            OleDbCommand cmd = new OleDbCommand(query, connection);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int taskID = reader.GetInt32(0);
                string taskName = reader.GetString(1);
                string taskDescription = reader.GetString(2);
                int taskStatus = reader.GetInt32(3);
                int taskPriority = reader.GetInt32(4);

                switch (taskStatus)
                {
                    case 1:
                        TaskButton button = CreateFlowLayoutButton(new Tasks() { TaskID = taskID, Task_name = taskName, Description = taskDescription, Status = taskStatus, Priority = taskPriority }, taskPriority);
                        ToBeDone_Paneeli.Controls.Add(button);
                        break;
                    case 2:
                        TaskButton button2 = CreateFlowLayoutButton(new Tasks() { TaskID = taskID, Task_name = taskName, Description = taskDescription, Status = taskStatus, Priority = taskPriority }, taskPriority);
                        InProcess_Paneeli.Controls.Add(button2);
                        break;
                    case 3:
                        TaskButton button3 = CreateFlowLayoutButton(new Tasks() { TaskID = taskID, Task_name = taskName, Description = taskDescription, Status = taskStatus, Priority = taskPriority }, taskPriority);
                        TaskDone_Paneeli.Controls.Add(button3);
                        break;
                }
            }
            reader.Close();
        }

        public TaskButton CreateFlowLayoutButton(Tasks task, int priority = 0) //Nappien luonti tauluihin, sisältää muotoilun (Method)
        {
            int ButtonPadding = 5; //Napin 'padding' arvo

            TaskButton button = new TaskButton
            {
                Margin = new Padding(ButtonPadding, ButtonPadding, ButtonPadding, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Yellow,
                Size = new Size(ToBeDone_Paneeli.Size.Width - ButtonPadding * 2, 40),
                Anchor = AnchorStyles.None,
                Task = task
            };
            switch (priority)
            {
                case 1:
                    button.BackColor = Color.Red;
                    break;
                case 2:
                    button.BackColor = Color.Orange;
                    break;
                case 3:
                    button.BackColor = Color.Yellow;
                    break;
                default:
                    button.BackColor = Color.LightGray;
                    break;
            }
            button.FlatAppearance.BorderSize = 0;
            button.MouseDoubleClick += new MouseEventHandler(FlowlayoutButton_MouseDoubleClick);
            button.Text = button.Task.Description;
            button.MouseDown += new MouseEventHandler(flowLayoutButton_MouseDown);

            return button;
        }
        private void FlowlayoutButtonForm_Load(object sender, EventArgs e)
        {
            Form form = (Form)sender;
            form.Top = this.Height / 2;
            form.Left = this.Width / 2;

            ((Form1)parentForm).WindowIsRaised = true;
        }

        private void FlowlayoutButtonForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form1)parentForm).WindowIsRaised = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ToDo_Button_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Enter topic here...")
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = "Enter topic here...";
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string contentTopic = Story_Textbox.Text;
                int priorityStatus = Convert.ToInt32(comboBox1.Text);
                string query = $"INSERT INTO User_Stories(StoryName, status, Priority) VALUES ('{contentTopic}', {button.Userstory.Status}, {priorityStatus})";

                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                e.Handled = true;
            }
        }

        private void ToBeDone_Button_Click_1(object sender, EventArgs e)
        {
            Button button = CreateFlowLayoutButton(new Tasks() { Description = "", Status = 1 });

            ToBeDone_Paneeli.Controls.Add(button);
        }

        private void InProcess_Button_Click(object sender, EventArgs e)
        {
            Button button = CreateFlowLayoutButton(new Tasks() { Description = "", Status = 2 });
            
            InProcess_Paneeli.Controls.Add(button);
        }

        private void TaskDone_Button_Click(object sender, EventArgs e)
        {
            Button button = CreateFlowLayoutButton(new Tasks() { Description = "", Status = 3 });

            TaskDone_Paneeli.Controls.Add(button);
        }

        private void Usestory_delete_button_Click(object sender, EventArgs e)
        {
            string query = $"DELETE FROM User_Stories WHERE StoryID = {button.Userstory.StoryID}"; // Poistetaan Userstoryjen relaatiot taskista
            OleDbCommand cmd = new OleDbCommand(query, connection);
            cmd.ExecuteNonQuery();

            ((Form1)parentForm).PopulateStories(projectid);
            this.Close();
        }
        private void FlowlayoutButton_MouseDoubleClick(object sender, EventArgs e)
        {
            if (!WindowIsRaised)
            {
                task TaskForm = new task((TaskButton)sender, connection);
                TaskForm.Show(this);
            }
        }

        private void storyButton_Click_1(object sender, EventArgs e)
        {
            string contentTopic = Story_Textbox.Text;
            string contentDescription = Description_Textbox.Text;
            int priorityStatus = Convert.ToInt32(comboBox1.Text);
            string query = $"INSERT INTO User_Stories(StoryName, status, Priority, FK_SprintID, StoryDescription) VALUES ('{contentTopic}', {button.Userstory.Status}, {priorityStatus}, 1, '{contentDescription}')";
            try
            {
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Tarinan lisääminen onnistui", "User Story", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Virhe:\n\n{ex.Message}", "User Story", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void flowLayoutButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                previousMouseLocation = MousePosition;
                pressedButton = (TaskButton)sender;

                timer.Start();
            }
        }

        private void flowLayoutPanel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void flowLayoutPanel_DragDrop(object sender, DragEventArgs e)
        {
            DraggableTaskData draggableObjectData = JsonConvert.DeserializeObject<DraggableTaskData>(e.Data.GetData(DataFormats.Text).ToString());
            
            int taskId = Convert.ToInt32(draggableObjectData.TaskID);
            //int status = Convert.ToInt32(draggableObjectData.Status);

            string query = $"UPDATE Tasks SET Status = (((id))) WHERE TaskID = {taskId}";

            switch (Convert.ToInt32(((FlowLayoutPanel)sender).Tag))
            {
                case 1:
                    query = query.Replace("(((id)))", "1");
                    break;
                case 2:
                    query = query.Replace("(((id)))", "2");
                    break;
                case 3:
                    query = query.Replace("(((id)))", "3");
                    break;
            }

            if (!query.Contains("(((id)))"))
            {
                OleDbCommand cmd = new OleDbCommand(query, connection);
                cmd.ExecuteNonQuery();
            }

            PopulateStories(button.Userstory.StoryID);
        }

        private void textBox1_leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = "Enter topic here...";
            }
        }

        private void Story_Textbox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Enter topic here...")
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }

        private void Description_leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.ForeColor = Color.Gray;
                textBox.Text = "Enter description here...";
            }
        }

        private void Description_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (textBox.Text == "Enter description here...")
            {
                textBox.ForeColor = Color.Black;
                textBox.Text = "";
            }
        }
    }

    class DraggableTaskData
    {
        public string TaskID { get; set; }
        public string Status { get; set; }
    }
}
