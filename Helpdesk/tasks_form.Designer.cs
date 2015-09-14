namespace Helpdesk
{
    partial class tasks_form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasks_checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addtask_textBox = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.taskurgency = new System.Windows.Forms.DataGridViewImageColumn();
            this.checkboxcolumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taskstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainMenuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.backToMainMenuToolStripMenuItem.Text = "Back to Main Menu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // tasks_checkedListBox
            // 
            this.tasks_checkedListBox.CheckOnClick = true;
            this.tasks_checkedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_checkedListBox.FormattingEnabled = true;
            this.tasks_checkedListBox.HorizontalScrollbar = true;
            this.tasks_checkedListBox.Location = new System.Drawing.Point(51, 78);
            this.tasks_checkedListBox.Name = "tasks_checkedListBox";
            this.tasks_checkedListBox.ScrollAlwaysVisible = true;
            this.tasks_checkedListBox.Size = new System.Drawing.Size(401, 225);
            this.tasks_checkedListBox.TabIndex = 13;
            this.tasks_checkedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.tasks_checkedListBox_ItemCheck);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tasks";
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(179, 421);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(173, 40);
            this.clear_button.TabIndex = 14;
            this.clear_button.Text = "Clear Completed Tasks";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Completed Tasks: 0";
            // 
            // addtask_textBox
            // 
            this.addtask_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtask_textBox.Location = new System.Drawing.Point(167, 335);
            this.addtask_textBox.Name = "addtask_textBox";
            this.addtask_textBox.Size = new System.Drawing.Size(173, 22);
            this.addtask_textBox.TabIndex = 18;
            this.addtask_textBox.TextChanged += new System.EventHandler(this.addtask_textBox_TextChanged);
            // 
            // add_button
            // 
            this.add_button.Enabled = false;
            this.add_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(356, 325);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(68, 40);
            this.add_button.TabIndex = 19;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add a Task:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taskurgency,
            this.checkboxcolumn,
            this.taskdescription,
            this.taskstatus});
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 21;
            // 
            // taskurgency
            // 
            this.taskurgency.HeaderText = "Urgency";
            this.taskurgency.Name = "taskurgency";
            this.taskurgency.Width = 50;
            // 
            // checkboxcolumn
            // 
            this.checkboxcolumn.HeaderText = "";
            this.checkboxcolumn.Name = "checkboxcolumn";
            this.checkboxcolumn.Width = 30;
            // 
            // taskdescription
            // 
            this.taskdescription.HeaderText = "Description";
            this.taskdescription.Name = "taskdescription";
            this.taskdescription.Width = 250;
            // 
            // taskstatus
            // 
            this.taskstatus.HeaderText = "Status";
            this.taskstatus.Name = "taskstatus";
            this.taskstatus.Width = 150;
            // 
            // tasks_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.addtask_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.tasks_checkedListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "tasks_form";
            this.Text = "Tasks";
            this.Load += new System.EventHandler(this.tasks_form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox tasks_checkedListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addtask_textBox;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn taskurgency;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkboxcolumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskdescription;
        private System.Windows.Forms.DataGridViewComboBoxColumn taskstatus;
    }
}