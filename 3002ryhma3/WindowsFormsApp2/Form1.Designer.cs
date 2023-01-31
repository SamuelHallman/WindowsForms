namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ToDo_Button = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.InProgress_Button = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Done_Button = new System.Windows.Forms.Button();
            this.ToDoPaneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.InProgressPaneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.DonePaneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.Projects_List = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Report_Button = new System.Windows.Forms.Button();
            this.Project_Display = new System.Windows.Forms.Label();
            this.TeamCreate_Button = new System.Windows.Forms.Button();
            this.ProjectCreate_Button = new System.Windows.Forms.Button();
            this.sprint_Button = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToDo_Button
            // 
            this.ToDo_Button.BackColor = System.Drawing.Color.Transparent;
            this.ToDo_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToDo_Button.FlatAppearance.BorderSize = 0;
            this.ToDo_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToDo_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDo_Button.Location = new System.Drawing.Point(261, 0);
            this.ToDo_Button.Name = "ToDo_Button";
            this.ToDo_Button.Size = new System.Drawing.Size(56, 35);
            this.ToDo_Button.TabIndex = 0;
            this.ToDo_Button.Text = "+";
            this.ToDo_Button.UseVisualStyleBackColor = false;
            this.ToDo_Button.Click += new System.EventHandler(this.ToDo1_Click);
            this.ToDo_Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.ToDo_Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(747, 59);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(39, 35);
            this.button5.TabIndex = 1;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ToDo_Button);
            this.panel2.Location = new System.Drawing.Point(135, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 35);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "To-Do";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SlateGray;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.InProgress_Button);
            this.panel4.Location = new System.Drawing.Point(529, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(317, 35);
            this.panel4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "In progress";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InProgress_Button
            // 
            this.InProgress_Button.BackColor = System.Drawing.Color.Transparent;
            this.InProgress_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InProgress_Button.FlatAppearance.BorderSize = 0;
            this.InProgress_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InProgress_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProgress_Button.Location = new System.Drawing.Point(261, 0);
            this.InProgress_Button.Name = "InProgress_Button";
            this.InProgress_Button.Size = new System.Drawing.Size(56, 35);
            this.InProgress_Button.TabIndex = 0;
            this.InProgress_Button.Text = "+";
            this.InProgress_Button.UseVisualStyleBackColor = false;
            this.InProgress_Button.Click += new System.EventHandler(this.InProgress1_Click);
            this.InProgress_Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.InProgress_Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SlateGray;
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.Done_Button);
            this.panel6.Location = new System.Drawing.Point(931, 59);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(317, 35);
            this.panel6.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Done";
            // 
            // Done_Button
            // 
            this.Done_Button.BackColor = System.Drawing.Color.Transparent;
            this.Done_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Done_Button.FlatAppearance.BorderSize = 0;
            this.Done_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Done_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Done_Button.Location = new System.Drawing.Point(261, 0);
            this.Done_Button.Name = "Done_Button";
            this.Done_Button.Size = new System.Drawing.Size(56, 35);
            this.Done_Button.TabIndex = 0;
            this.Done_Button.Text = "+";
            this.Done_Button.UseVisualStyleBackColor = false;
            this.Done_Button.Click += new System.EventHandler(this.Done1_Click);
            this.Done_Button.MouseEnter += new System.EventHandler(this.Button_MouseEnter);
            this.Done_Button.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // ToDoPaneeli
            // 
            this.ToDoPaneeli.AllowDrop = true;
            this.ToDoPaneeli.AutoScroll = true;
            this.ToDoPaneeli.BackColor = System.Drawing.Color.SlateGray;
            this.ToDoPaneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ToDoPaneeli.Location = new System.Drawing.Point(135, 100);
            this.ToDoPaneeli.Name = "ToDoPaneeli";
            this.ToDoPaneeli.Size = new System.Drawing.Size(317, 371);
            this.ToDoPaneeli.TabIndex = 8;
            this.ToDoPaneeli.Tag = "1";
            this.ToDoPaneeli.WrapContents = false;
            this.ToDoPaneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.ToDoPaneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            this.ToDoPaneeli.Paint += new System.Windows.Forms.PaintEventHandler(this.ToDoPaneeli_Paint);
            // 
            // InProgressPaneeli
            // 
            this.InProgressPaneeli.AllowDrop = true;
            this.InProgressPaneeli.AutoScroll = true;
            this.InProgressPaneeli.BackColor = System.Drawing.Color.SlateGray;
            this.InProgressPaneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InProgressPaneeli.Location = new System.Drawing.Point(529, 100);
            this.InProgressPaneeli.Name = "InProgressPaneeli";
            this.InProgressPaneeli.Size = new System.Drawing.Size(317, 371);
            this.InProgressPaneeli.TabIndex = 9;
            this.InProgressPaneeli.Tag = "2";
            this.InProgressPaneeli.WrapContents = false;
            this.InProgressPaneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.InProgressPaneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // DonePaneeli
            // 
            this.DonePaneeli.AllowDrop = true;
            this.DonePaneeli.AutoScroll = true;
            this.DonePaneeli.BackColor = System.Drawing.Color.SlateGray;
            this.DonePaneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DonePaneeli.Location = new System.Drawing.Point(931, 100);
            this.DonePaneeli.Name = "DonePaneeli";
            this.DonePaneeli.Size = new System.Drawing.Size(317, 371);
            this.DonePaneeli.TabIndex = 10;
            this.DonePaneeli.Tag = "3";
            this.DonePaneeli.WrapContents = false;
            this.DonePaneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.DonePaneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // Projects_List
            // 
            this.Projects_List.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Projects_List.FormattingEnabled = true;
            this.Projects_List.Location = new System.Drawing.Point(1, 2);
            this.Projects_List.Name = "Projects_List";
            this.Projects_List.Size = new System.Drawing.Size(121, 21);
            this.Projects_List.TabIndex = 12;
            this.Projects_List.SelectedIndexChanged += new System.EventHandler(this.Projects_List_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(467, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(428, 24);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Enter topic here...";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Report_Button
            // 
            this.Report_Button.Location = new System.Drawing.Point(1322, 70);
            this.Report_Button.Name = "Report_Button";
            this.Report_Button.Size = new System.Drawing.Size(82, 23);
            this.Report_Button.TabIndex = 14;
            this.Report_Button.Text = "Report";
            this.Report_Button.UseVisualStyleBackColor = true;
            // 
            // Project_Display
            // 
            this.Project_Display.AutoSize = true;
            this.Project_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Project_Display.Location = new System.Drawing.Point(132, 5);
            this.Project_Display.Name = "Project_Display";
            this.Project_Display.Size = new System.Drawing.Size(46, 17);
            this.Project_Display.TabIndex = 15;
            this.Project_Display.Text = "label4";
            // 
            // TeamCreate_Button
            // 
            this.TeamCreate_Button.Location = new System.Drawing.Point(1322, 100);
            this.TeamCreate_Button.Name = "TeamCreate_Button";
            this.TeamCreate_Button.Size = new System.Drawing.Size(82, 35);
            this.TeamCreate_Button.TabIndex = 16;
            this.TeamCreate_Button.Text = "Add Team";
            this.TeamCreate_Button.UseVisualStyleBackColor = true;
            // 
            // ProjectCreate_Button
            // 
            this.ProjectCreate_Button.Location = new System.Drawing.Point(901, 12);
            this.ProjectCreate_Button.Name = "ProjectCreate_Button";
            this.ProjectCreate_Button.Size = new System.Drawing.Size(90, 24);
            this.ProjectCreate_Button.TabIndex = 17;
            this.ProjectCreate_Button.Text = "Create Project";
            this.ProjectCreate_Button.UseVisualStyleBackColor = true;
            this.ProjectCreate_Button.Click += new System.EventHandler(this.ProjectCreate_Button_Click);
            // 
            // sprint_Button
            // 
            this.sprint_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.sprint_Button.Location = new System.Drawing.Point(1322, 442);
            this.sprint_Button.Name = "sprint_Button";
            this.sprint_Button.Size = new System.Drawing.Size(82, 29);
            this.sprint_Button.TabIndex = 18;
            this.sprint_Button.Text = "Add Sprint";
            this.sprint_Button.UseVisualStyleBackColor = true;
            this.sprint_Button.Click += new System.EventHandler(this.sprint_Button_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(1370, 416);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(1290, 416);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(74, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1298, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Start Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1385, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "End Date";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1463, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.sprint_Button);
            this.Controls.Add(this.ProjectCreate_Button);
            this.Controls.Add(this.TeamCreate_Button);
            this.Controls.Add(this.Project_Display);
            this.Controls.Add(this.Report_Button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Projects_List);
            this.Controls.Add(this.DonePaneeli);
            this.Controls.Add(this.InProgressPaneeli);
            this.Controls.Add(this.ToDoPaneeli);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Name = "Form1";
            this.Text = "Project";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ToDo_Button;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InProgress_Button;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Done_Button;
        private System.Windows.Forms.FlowLayoutPanel ToDoPaneeli;
        private System.Windows.Forms.FlowLayoutPanel InProgressPaneeli;
        private System.Windows.Forms.FlowLayoutPanel DonePaneeli;
        private System.Windows.Forms.ComboBox Projects_List;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Report_Button;
        private System.Windows.Forms.Label Project_Display;
        private System.Windows.Forms.Button TeamCreate_Button;
        private System.Windows.Forms.Button ProjectCreate_Button;
        private System.Windows.Forms.Button sprint_Button;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

