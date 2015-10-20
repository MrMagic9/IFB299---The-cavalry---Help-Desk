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
    public partial class feedback_form : Form
    {
        public feedback_form()
        {
            InitializeComponent();
        }

        private void feedback_form_Load(object sender, EventArgs e)
        {
            volunteer_comboBox.Items.Add("Lachlan Ashley");
            volunteer_comboBox.Items.Add("Ryan Carroll");
            volunteer_comboBox.Items.Add("Rahul Sehgal");
            volunteer_comboBox.Items.Add("Daniel Choi");
        }

        private void volunteer_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            feedback_textBox.Enabled = true;

            int volunteer_name = volunteer_comboBox.SelectedIndex;

            if (volunteer_name == 0)
            {
                feedback_listBox.Items.Clear();
                feedback_listBox.Items.Add("Lachlan Ashley:");
            }

            else if (volunteer_name == 1)
            {
                feedback_listBox.Items.Clear();
                feedback_listBox.Items.Add("Ryan Carroll:");
            }

            else if (volunteer_name == 2)
            {
                feedback_listBox.Items.Clear();
                feedback_listBox.Items.Add("Rahul Sehgal:");
            }

            else if (volunteer_name == 3)
            {
                feedback_listBox.Items.Clear();
                feedback_listBox.Items.Add("Daniel Choi:");
            }
        }

        private void backToMainMenuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void feedback_textBox_TextChanged_1(object sender, EventArgs e)
        {
            submit_button.Enabled = true;
        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void printPreviewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void submit_button_Click_1(object sender, EventArgs e)
        {
            feedback_listBox.Items.Add(feedback_textBox.Text);
            feedback_textBox.Text = "";
            submit_button.Enabled = false;
        }
    }
}
