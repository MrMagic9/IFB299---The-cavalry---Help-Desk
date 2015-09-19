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
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Open login_form
            this.Close();
        }

        private void main_form_Load(object sender, EventArgs e)
        {
            
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
    }
}
