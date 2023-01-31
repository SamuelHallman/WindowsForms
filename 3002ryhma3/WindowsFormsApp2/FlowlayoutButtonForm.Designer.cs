namespace WindowsFormsApp2
{
    partial class FlowlayoutButtonForm
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
            this.Story_Textbox = new System.Windows.Forms.TextBox();
            this.ToBeDone_Paneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.InProcess_Paneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.TaskDone_Paneeli = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToBeDone_Button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InProcess_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TaskDone_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Usestory_delete_button = new System.Windows.Forms.Button();
            this.Story_Button = new System.Windows.Forms.Button();
            this.storyName_Label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Description_Textbox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Story_Textbox
            // 
            this.Story_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Story_Textbox.ForeColor = System.Drawing.Color.Gray;
            this.Story_Textbox.Location = new System.Drawing.Point(727, 180);
            this.Story_Textbox.Name = "Story_Textbox";
            this.Story_Textbox.Size = new System.Drawing.Size(249, 24);
            this.Story_Textbox.TabIndex = 10;
            this.Story_Textbox.Text = "Enter topic here...";
            this.Story_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Story_Textbox.Enter += new System.EventHandler(this.Story_Textbox_Enter);
            this.Story_Textbox.Leave += new System.EventHandler(this.textBox1_leave);
            // 
            // ToBeDone_Paneeli
            // 
            this.ToBeDone_Paneeli.AllowDrop = true;
            this.ToBeDone_Paneeli.AutoScroll = true;
            this.ToBeDone_Paneeli.BackColor = System.Drawing.Color.SlateGray;
            this.ToBeDone_Paneeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ToBeDone_Paneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ToBeDone_Paneeli.Location = new System.Drawing.Point(165, 106);
            this.ToBeDone_Paneeli.Name = "ToBeDone_Paneeli";
            this.ToBeDone_Paneeli.Size = new System.Drawing.Size(183, 301);
            this.ToBeDone_Paneeli.TabIndex = 11;
            this.ToBeDone_Paneeli.Tag = "1";
            this.ToBeDone_Paneeli.WrapContents = false;
            this.ToBeDone_Paneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.ToBeDone_Paneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // InProcess_Paneeli
            // 
            this.InProcess_Paneeli.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.InProcess_Paneeli.AllowDrop = true;
            this.InProcess_Paneeli.AutoScroll = true;
            this.InProcess_Paneeli.BackColor = System.Drawing.Color.SlateGray;
            this.InProcess_Paneeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InProcess_Paneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.InProcess_Paneeli.Location = new System.Drawing.Point(354, 106);
            this.InProcess_Paneeli.Name = "InProcess_Paneeli";
            this.InProcess_Paneeli.Size = new System.Drawing.Size(183, 301);
            this.InProcess_Paneeli.TabIndex = 12;
            this.InProcess_Paneeli.Tag = "2";
            this.InProcess_Paneeli.WrapContents = false;
            this.InProcess_Paneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.InProcess_Paneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // TaskDone_Paneeli
            // 
            this.TaskDone_Paneeli.AllowDrop = true;
            this.TaskDone_Paneeli.AutoScroll = true;
            this.TaskDone_Paneeli.BackColor = System.Drawing.Color.SlateGray;
            this.TaskDone_Paneeli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaskDone_Paneeli.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.TaskDone_Paneeli.Location = new System.Drawing.Point(543, 106);
            this.TaskDone_Paneeli.Name = "TaskDone_Paneeli";
            this.TaskDone_Paneeli.Size = new System.Drawing.Size(183, 301);
            this.TaskDone_Paneeli.TabIndex = 13;
            this.TaskDone_Paneeli.Tag = "3";
            this.TaskDone_Paneeli.WrapContents = false;
            this.TaskDone_Paneeli.DragDrop += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragDrop);
            this.TaskDone_Paneeli.DragEnter += new System.Windows.Forms.DragEventHandler(this.flowLayoutPanel_DragEnter);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Controls.Add(this.ToBeDone_Button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(165, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 35);
            this.panel2.TabIndex = 14;
            // 
            // ToBeDone_Button
            // 
            this.ToBeDone_Button.BackColor = System.Drawing.Color.Transparent;
            this.ToBeDone_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToBeDone_Button.FlatAppearance.BorderSize = 0;
            this.ToBeDone_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToBeDone_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToBeDone_Button.Location = new System.Drawing.Point(135, 2);
            this.ToBeDone_Button.Name = "ToBeDone_Button";
            this.ToBeDone_Button.Size = new System.Drawing.Size(45, 30);
            this.ToBeDone_Button.TabIndex = 17;
            this.ToBeDone_Button.Text = "+";
            this.ToBeDone_Button.UseVisualStyleBackColor = false;
            this.ToBeDone_Button.Click += new System.EventHandler(this.ToBeDone_Button_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "To be done";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.InProcess_Button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(354, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 35);
            this.panel1.TabIndex = 15;
            // 
            // InProcess_Button
            // 
            this.InProcess_Button.BackColor = System.Drawing.Color.Transparent;
            this.InProcess_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InProcess_Button.FlatAppearance.BorderSize = 0;
            this.InProcess_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InProcess_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InProcess_Button.Location = new System.Drawing.Point(138, 2);
            this.InProcess_Button.Name = "InProcess_Button";
            this.InProcess_Button.Size = new System.Drawing.Size(45, 30);
            this.InProcess_Button.TabIndex = 18;
            this.InProcess_Button.Text = "+";
            this.InProcess_Button.UseVisualStyleBackColor = false;
            this.InProcess_Button.Click += new System.EventHandler(this.InProcess_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "In process";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.TaskDone_Button);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(543, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 35);
            this.panel3.TabIndex = 16;
            // 
            // TaskDone_Button
            // 
            this.TaskDone_Button.BackColor = System.Drawing.Color.Transparent;
            this.TaskDone_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TaskDone_Button.FlatAppearance.BorderSize = 0;
            this.TaskDone_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskDone_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDone_Button.Location = new System.Drawing.Point(138, 2);
            this.TaskDone_Button.Name = "TaskDone_Button";
            this.TaskDone_Button.Size = new System.Drawing.Size(45, 30);
            this.TaskDone_Button.TabIndex = 19;
            this.TaskDone_Button.Text = "+";
            this.TaskDone_Button.UseVisualStyleBackColor = false;
            this.TaskDone_Button.Click += new System.EventHandler(this.TaskDone_Button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Done";
            // 
            // Usestory_delete_button
            // 
            this.Usestory_delete_button.Location = new System.Drawing.Point(26, 65);
            this.Usestory_delete_button.Name = "Usestory_delete_button";
            this.Usestory_delete_button.Size = new System.Drawing.Size(98, 34);
            this.Usestory_delete_button.TabIndex = 17;
            this.Usestory_delete_button.Text = "Delete User story";
            this.Usestory_delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usestory_delete_button.UseVisualStyleBackColor = true;
            this.Usestory_delete_button.Click += new System.EventHandler(this.Usestory_delete_button_Click);
            // 
            // Story_Button
            // 
            this.Story_Button.Location = new System.Drawing.Point(802, 277);
            this.Story_Button.Name = "Story_Button";
            this.Story_Button.Size = new System.Drawing.Size(75, 24);
            this.Story_Button.TabIndex = 18;
            this.Story_Button.Text = "Create Story";
            this.Story_Button.UseVisualStyleBackColor = true;
            this.Story_Button.Click += new System.EventHandler(this.storyButton_Click_1);
            // 
            // storyName_Label
            // 
            this.storyName_Label.AutoSize = true;
            this.storyName_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.storyName_Label.Location = new System.Drawing.Point(23, 21);
            this.storyName_Label.Name = "storyName_Label";
            this.storyName_Label.Size = new System.Drawing.Size(87, 18);
            this.storyName_Label.TabIndex = 19;
            this.storyName_Label.Text = "Story Name";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(816, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(37, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // Description_Textbox
            // 
            this.Description_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Description_Textbox.ForeColor = System.Drawing.Color.Gray;
            this.Description_Textbox.Location = new System.Drawing.Point(728, 210);
            this.Description_Textbox.Name = "Description_Textbox";
            this.Description_Textbox.Size = new System.Drawing.Size(248, 24);
            this.Description_Textbox.TabIndex = 21;
            this.Description_Textbox.Text = "Enter description here...";
            this.Description_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Description_Textbox.Enter += new System.EventHandler(this.Description_Enter);
            this.Description_Textbox.Leave += new System.EventHandler(this.Description_leave);
            // 
            // FlowlayoutButtonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 450);
            this.Controls.Add(this.Description_Textbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.storyName_Label);
            this.Controls.Add(this.Story_Button);
            this.Controls.Add(this.Usestory_delete_button);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TaskDone_Paneeli);
            this.Controls.Add(this.InProcess_Paneeli);
            this.Controls.Add(this.ToBeDone_Paneeli);
            this.Controls.Add(this.Story_Textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FlowlayoutButtonForm";
            this.Text = "User Story";
            this.Load += new System.EventHandler(this.FlowlayoutButtonForm_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Story_Textbox;
        private System.Windows.Forms.FlowLayoutPanel ToBeDone_Paneeli;
        private System.Windows.Forms.FlowLayoutPanel InProcess_Paneeli;
        private System.Windows.Forms.FlowLayoutPanel TaskDone_Paneeli;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ToBeDone_Button;
        private System.Windows.Forms.Button InProcess_Button;
        private System.Windows.Forms.Button TaskDone_Button;
        private System.Windows.Forms.Button Usestory_delete_button;
        private System.Windows.Forms.Button Story_Button;
        private System.Windows.Forms.Label storyName_Label;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Description_Textbox;
    }
}