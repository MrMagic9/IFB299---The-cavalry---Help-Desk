using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helpdesk
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_form_reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void username_textBox_TextChanged(object sender, EventArgs e)
        {
            login_button_enabled_disabled();
        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {
            login_button_enabled_disabled();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            login_details_check();
        }

        private void login_button_enabled_disabled()
        {
            if (username_textBox.Text == "" && password_textBox.Text == "")
            {
                login_button.Enabled = false;
            }
            else if (username_textBox.Text != "" && password_textBox.Text != "")
            {
                login_button.Enabled = true;
            }
        }

        private void login_details_check()
        {
            if (username_textBox.Text == "")
            {
                MessageBox.Show("No username has been entered. Please enter your username.");
            }
            else if(password_textBox.Text == "")
            {
                MessageBox.Show("No password has been entered. Please enter your password.");
            }
            else if(username_textBox.Text == "" && password_textBox.Text == "")
            {
                MessageBox.Show("No username or password has been entered. Please enter your username and password.");
            }
            else if (manager_radioButton.Checked == false && volunteer_radioButton.Checked == false)
            {
                MessageBox.Show("No role has been selected. Please select whether you are a manager or volunteer.");
            }
            else
            {
                //open main_form
                MessageBox.Show("Login Successful!");
                new main_form().Show();
            }
        }

        private void login_form_reset()
        {
            username_textBox.ResetText();
            password_textBox.ResetText();
            login_button.Enabled = false;
            username_textBox.Focus();
            manager_radioButton.Checked = false;
            volunteer_radioButton.Checked = false;
        }

        private void manager_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void volunteer_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
