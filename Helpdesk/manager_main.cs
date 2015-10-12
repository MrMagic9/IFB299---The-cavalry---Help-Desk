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
    public partial class manager_main : Form
    {
        public manager_main()
        {
            InitializeComponent();
        }

        private void tasks_button_Click(object sender, EventArgs e)
        {
            new tasks_form().Show();
        }

        private void providers_button_Click(object sender, EventArgs e)
        {
            new providers_form().Show();
        }

        private void forum_button_Click(object sender, EventArgs e)
        {
            new forum_form().Show();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Open login_form
            this.Close();
        }

        private void volunteers_button_Click(object sender, EventArgs e)
        {
            new volunteers_details().Show();
        }
    }
}
