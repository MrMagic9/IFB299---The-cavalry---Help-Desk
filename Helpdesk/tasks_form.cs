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
    public partial class tasks_form : Form
    {
        public tasks_form()
        {
            InitializeComponent();
        }

        private void backToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tasks_form_Load(object sender, EventArgs e)
        {

        }

        private void clear_button_Click(object sender, EventArgs e)
        {

        }

        private void add_button_Click(object sender, EventArgs e)
        {

        }

        private void taskstatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int status_index = taskstatus_comboBox.SelectedIndex;

            if (status_index == 0)
            {
                urgency_pictureBox.BackColor = Color.Red;
            }
            else if (status_index == 1)
            {
                urgency_pictureBox.BackColor = Color.Orange;
            }
            else if (status_index == 2)
            {
                urgency_pictureBox.BackColor = Color.Green;
            }
        }
    }
}
