namespace Helpdesk
{
    partial class manager_main
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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.forum_button = new System.Windows.Forms.Button();
            this.tasks_button = new System.Windows.Forms.Button();
            this.providers_button = new System.Windows.Forms.Button();
            this.volunteers_button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // forum_button
            // 
            this.forum_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forum_button.Location = new System.Drawing.Point(196, 339);
            this.forum_button.Name = "forum_button";
            this.forum_button.Size = new System.Drawing.Size(129, 55);
            this.forum_button.TabIndex = 14;
            this.forum_button.Text = "Forum";
            this.forum_button.UseVisualStyleBackColor = true;
            this.forum_button.Click += new System.EventHandler(this.forum_button_Click);
            // 
            // tasks_button
            // 
            this.tasks_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasks_button.Location = new System.Drawing.Point(196, 77);
            this.tasks_button.Name = "tasks_button";
            this.tasks_button.Size = new System.Drawing.Size(129, 55);
            this.tasks_button.TabIndex = 13;
            this.tasks_button.Text = "Tasks";
            this.tasks_button.UseVisualStyleBackColor = true;
            this.tasks_button.Click += new System.EventHandler(this.tasks_button_Click);
            // 
            // providers_button
            // 
            this.providers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.providers_button.Location = new System.Drawing.Point(196, 250);
            this.providers_button.Name = "providers_button";
            this.providers_button.Size = new System.Drawing.Size(129, 55);
            this.providers_button.TabIndex = 12;
            this.providers_button.Text = "Providers";
            this.providers_button.UseVisualStyleBackColor = true;
            this.providers_button.Click += new System.EventHandler(this.providers_button_Click);
            // 
            // volunteers_button
            // 
            this.volunteers_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volunteers_button.Location = new System.Drawing.Point(196, 162);
            this.volunteers_button.Name = "volunteers_button";
            this.volunteers_button.Size = new System.Drawing.Size(129, 55);
            this.volunteers_button.TabIndex = 15;
            this.volunteers_button.Text = "Volunteers";
            this.volunteers_button.UseVisualStyleBackColor = true;
            this.volunteers_button.Click += new System.EventHandler(this.volunteers_button_Click);
            // 
            // manager_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 473);
            this.Controls.Add(this.volunteers_button);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.forum_button);
            this.Controls.Add(this.tasks_button);
            this.Controls.Add(this.providers_button);
            this.Name = "manager_main";
            this.Text = "Welcome to Helpdesk - Manager View";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button forum_button;
        private System.Windows.Forms.Button tasks_button;
        private System.Windows.Forms.Button providers_button;
        private System.Windows.Forms.Button volunteers_button;
    }
}